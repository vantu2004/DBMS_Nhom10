CREATE TRIGGER [dbo].[trg_Update_DonBan]
ON [dbo].[CT_DON_BAN]
AFTER INSERT, DELETE
AS
BEGIN
    -- Update Tri_gia and SL_dien_thoai in DON_BAN
    UPDATE DON_BAN
    SET Tri_gia = (
            SELECT SUM(DIEN_THOAI.Gia_ban * (100 + DIEN_THOAI.Thue) / 100)
            FROM CT_DON_BAN
            JOIN DIEN_THOAI ON CT_DON_BAN.Ma_Imei = DIEN_THOAI.Ma_Imei
            WHERE CT_DON_BAN.Ma_don_ban = inserted.Ma_don_ban
        ),
        SL_dien_thoai = (
            SELECT COUNT(*)
            FROM CT_DON_BAN
            WHERE CT_DON_BAN.Ma_don_ban = inserted.Ma_don_ban
        )
    FROM inserted
    WHERE DON_BAN.Ma_don_ban = inserted.Ma_don_ban;
    
    -- Update Trang_thai in DIEN_THOAI
    UPDATE DIEN_THOAI
    SET Trang_thai = N'Đã bán'
    WHERE Ma_Imei IN (SELECT Ma_Imei FROM inserted);
END;
GO


CREATE TRIGGER [dbo].[trg_update_don_nhap]
ON [dbo].[CT_DON_NHAP]
AFTER INSERT, DELETE
AS
BEGIN
    IF EXISTS (SELECT * FROM INSERTED)
    BEGIN
        UPDATE DON_NHAP
        SET SL_dien_thoai = (SELECT COUNT(*) FROM CT_DON_NHAP WHERE Ma_don_nhap = INSERTED.Ma_don_nhap),
            Tri_gia = (SELECT SUM(DIEN_THOAI.Gia_nhap) 
                       FROM CT_DON_NHAP
                       JOIN DIEN_THOAI ON CT_DON_NHAP.Ma_Imei = DIEN_THOAI.Ma_Imei
                       WHERE CT_DON_NHAP.Ma_don_nhap = INSERTED.Ma_don_nhap)
        FROM INSERTED
        WHERE DON_NHAP.Ma_don_nhap = INSERTED.Ma_don_nhap;
    END

    -- Tính toán lại số lượng và trị giá khi xóa bản ghi khỏi CT_DON_NHAP
    IF EXISTS (SELECT * FROM DELETED)
    BEGIN
        UPDATE DON_NHAP
        SET SL_dien_thoai = (SELECT COUNT(*) FROM CT_DON_NHAP WHERE Ma_don_nhap = DELETED.Ma_don_nhap),
            Tri_gia = (SELECT SUM(DIEN_THOAI.Gia_nhap) 
                       FROM CT_DON_NHAP
                       JOIN DIEN_THOAI ON CT_DON_NHAP.Ma_Imei = DIEN_THOAI.Ma_Imei
                       WHERE CT_DON_NHAP.Ma_don_nhap = DELETED.Ma_don_nhap)
        FROM DELETED
        WHERE DON_NHAP.Ma_don_nhap = DELETED.Ma_don_nhap;
    END
END;
GO


CREATE TRIGGER [dbo].[trg_CapNhatGhiNo]
ON [dbo].[DON_BAN]
AFTER INSERT, UPDATE
AS
BEGIN
    -- Biến để lưu trữ thông tin đơn bán
    DECLARE @Ma_don_ban CHAR(9),
			@Ma_khach_hang CHAR(9), 
			@Ngay_tao_don DATE, 
			@So_tien_tra NUMERIC(18,2), 
			@Tri_gia NUMERIC(18,2), 
			@Chua_thanh_toan NUMERIC(18,2),
			@STT_ghi_no INT;

    -- Lấy dữ liệu từ bảng inserted (bảng chứa giá trị mới)
    SELECT	@Ma_don_ban = i.Ma_don_ban, 
			@Ma_khach_hang = i.Ma_khach_hang, 
			@Ngay_tao_don = i.Ngay_tao_don, 
			@So_tien_tra = i.So_tien_tra, 
			@Tri_gia = i.Tri_gia
    FROM inserted i;

    -- Tính toán số tiền chưa thanh toán
    SET @Chua_thanh_toan = @Tri_gia - @So_tien_tra;

    -- Nếu số tiền chưa thanh toán lớn hơn 0, tạo record trong bảng GHI_NO
    IF @Chua_thanh_toan > 0
    BEGIN
		SELECT @STT_ghi_no = ISNULL(MAX(STT_ghi_no), 0) + 1 FROM GHI_NO;


        INSERT INTO GHI_NO (STT_ghi_no, Ma_khach_hang, Ngay_ghi_no, Chua_thanh_toan)
        VALUES (@STT_ghi_no, @Ma_khach_hang, @Ngay_tao_don, @Chua_thanh_toan);
    END
END;
GO


CREATE TRIGGER [dbo].[trgBeforeInsertDonBan]
ON [dbo].[DON_BAN]
INSTEAD OF INSERT --, UPDATE
AS

BEGIN
    DECLARE @NgayTaoDon DATE, @SoLuongBan INT, @TongThu NUMERIC(18,2);
    SELECT @NgayTaoDon = Ngay_tao_don FROM INSERTED;
    
    -- Check if Ngay_thong_ke already exists
    IF NOT EXISTS (SELECT 1 FROM THONG_KE_NGAY WHERE Ngay_thong_ke = @NgayTaoDon)
    BEGIN
        INSERT INTO THONG_KE_NGAY(Ngay_thong_ke, So_luong_ban, Tong_thu)
        VALUES (@NgayTaoDon, 0, 0);
    END
    
    -- Calculate the total number of phones and total revenue for the day
    SELECT @SoLuongBan = COUNT(*), @TongThu = SUM(Tri_gia)
    FROM DON_BAN
    WHERE Ngay_tao_don = @NgayTaoDon;
    
    -- Update THONG_KE_NGAY with calculated values
    UPDATE THONG_KE_NGAY
    SET So_luong_ban = @SoLuongBan, Tong_thu = @TongThu
    WHERE Ngay_thong_ke = @NgayTaoDon;

    -- Insert the new DON_BAN entry
    INSERT INTO DON_BAN (Ma_don_ban, Ngay_tao_don, Gio_tao_don, Tri_gia, SL_dien_thoai, So_tien_tra, Trang_thai, Ma_khach_hang, Ma_nhan_vien, Ma_khuyen_mai)
    SELECT Ma_don_ban, Ngay_tao_don, Gio_tao_don, Tri_gia, SL_dien_thoai, So_tien_tra, Trang_thai, Ma_khach_hang, Ma_nhan_vien, Ma_khuyen_mai
    FROM INSERTED;
END;
GO