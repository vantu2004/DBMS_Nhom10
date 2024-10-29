
-- Dùng mã khuyến mãi để lấy chiết khấu, dựa vào KHUYEN_MAI
CREATE FUNCTION [dbo].[Fn_LayChietKhau]
(
    @Ma_khuyen_mai CHAR(50)
)
RETURNS NUMERIC(4,2)
AS
BEGIN
    DECLARE @ChietKhau NUMERIC(4,2);

    SELECT @ChietKhau = Chiet_khau
    FROM KHUYEN_MAI
    WHERE Ma_khuyen_mai = @Ma_khuyen_mai;

    -- Trả về giá trị chiết khấu hoặc 0 nếu mã khuyến mãi không tồn tại
    RETURN ISNULL(@ChietKhau, 0);
END;
GO

-- Truy vấn lấy Ma_khach_hang từ bảng KHACH_HANG dựa trên số điện thoại, dựa vào KHACH_HANG
-- Cần code lại để ràng buộc đảm bảo 1 số chỉ tạo 1 lần
CREATE FUNCTION [dbo].[Fn_LayMaKhachHang]
(
    @SDT VARCHAR(18)
)
RETURNS CHAR(9)
AS
BEGIN
    DECLARE @MaKhachHang CHAR(9);

    SELECT @MaKhachHang = Ma_khach_hang
    FROM KHACH_HANG
    WHERE SDT = @SDT;

    -- Trả về kết quả
    RETURN @MaKhachHang;
END;
GO

-- Tính tổng tiền 1 đơn hàng dựa vào mã đơn hàng, tính dựa vào view Dgv_ChiTietDonHang
CREATE FUNCTION [dbo].[Fn_TongTien1DonHang]
(
    @Ma_don_ban NVARCHAR(50)
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @NetTotalAmount DECIMAL(18, 2);

    SELECT @NetTotalAmount = SUM([Giá bán]-[Thuế] * [Giá bán] / 100)
    FROM dbo.Dgv_ChiTietDonHang
    WHERE [Mã đơn bán] = @Ma_don_ban;

    RETURN ISNULL(@NetTotalAmount, 0); -- Trả về 0 nếu không có sản phẩm nào
END;
GO

-- Lấy 4 thuộc tính dưới để vào các combobox dựa vào view Dgv_DanhSachDienThoai
CREATE FUNCTION [dbo].[Fn_LoadFilterDienThoaiCoSan]()
RETURNS TABLE
AS
RETURN
(
    SELECT
        [Tên dòng máy],
        [Kích thước màn hình],
        [Dung lượng pin],
        [Màu sắc]
    FROM 
        [dbo].[Dgv_DanhSachDienThoai]
);
GO

-- Lấy thông tin điện thoại dựa vào các thuộc tính truyền vào từ view Dgv_DanhSachDienThoaiSanCo
CREATE FUNCTION [dbo].[Fn_TimDienThoaiTheoFilter]
(
    @TenDongMay NVARCHAR(255) = NULL,
    @KichThuoc NVARCHAR(255) = NULL,
    @DungLuongPin NVARCHAR(255) = NULL,
    @MauSac NVARCHAR(255) = NULL
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        [Mã dòng máy],
        [Tên dòng máy],
        [Kích thước màn hình],
        [Dung lượng pin],
        [Mã Imei],
        [Màu sắc],
        [Trạng thái],
        [Thuế],
        [Giá bán],
        [Giá nhập],
        [Hình ảnh]
    FROM 
        [dbo].[Dgv_DanhSachDienThoaiSanCo]
    WHERE 
        (@TenDongMay IS NULL OR [Tên dòng máy] = @TenDongMay)
        AND (@KichThuoc IS NULL OR [Kích thước màn hình] = @KichThuoc)
        AND (@DungLuongPin IS NULL OR [Dung lượng pin] = @DungLuongPin)
        AND (@MauSac IS NULL OR [Màu sắc] = @MauSac)
);
GO

-- Lấy thông tin điện thoại dựa vào Imei từ view Dgv_DanhSachDienThoaiSanCo
CREATE FUNCTION [dbo].[Fn_LayDienThoaiDuaVAoImei] 
(
    @Imei NVARCHAR(255)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM 
        dbo.Dgv_DanhSachDienThoaiSanCo
    WHERE 
        TRIM([Mã Imei]) = TRIM(@Imei)
);
GO

-- Lấy thông tin đơn hàng dựa vào số điện thoại từ view Dgv_DanhSachDonHang
CREATE FUNCTION [dbo].[Fn_TimKiemTheoSoDienThoai]
(
    @SoDienThoai NVARCHAR(20)
)
RETURNS TABLE
AS
RETURN
(
    SELECT * 
    FROM Dgv_DanhSachDonHang
    WHERE [Số điện thoại khách hàng] = @SoDienThoai
);
GO

-- Lấy tất cả số điện thoại nhân viên để load vào combobox
CREATE FUNCTION [dbo].[Fn_LayTatCaSoDienThoaiNhanVien]()
RETURNS TABLE
AS
RETURN
(
    SELECT SDT 
    FROM NHAN_VIEN
);
GO

-- Lấy tất cả số điện thoại khách hàng để load vào combobox
CREATE FUNCTION [dbo].[Fn_LayTatCaSoDienThoaiKhachHang]()
RETURNS TABLE
AS
RETURN
(
    SELECT SDT 
    FROM KHACH_HANG
);
GO

-- Xem xét gộp 3 cái trên thành 1
-- Lấy tất cả số điện thoại khách hàng để load vào combobox
CREATE FUNCTION [dbo].[Fn_LayTatCaMaKhuyenMai]()
RETURNS TABLE
AS
RETURN
(
    SELECT Ma_khuyen_mai 
    FROM KHUYEN_MAI
);
GO

-- Lấy thông tin chi tiết đơn bán dựa vào mã đơn bán, bổ sung thêm sđt nhân viên để làm j quên mất 
CREATE FUNCTION [dbo].[GetOrderDetails]
(
    @Ma_don_ban NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN 
(
    SELECT 
        db.Ma_don_ban AS [Mã đơn bán],
        db.Ngay_tao_don AS [Ngày tạo đơn],
        db.So_tien_tra AS [Số tiền khách đã trả],
        db.SL_dien_thoai AS [Số lượng điện thoại],
        db.Tri_gia AS [Trị giá],
        db.Trang_thai AS [Trạng thái],
        kh.Ma_khach_hang AS [Mã khách hàng],
        kh.SDT AS [Số điện thoại khách hàng],
        kh.Ten_khach_hang AS [Tên khách hàng],
        km.Ma_khuyen_mai AS [Mã khuyến mãi],
        km.Chiet_khau AS [Chiết khấu],
        nv.Ma_nhan_vien AS [Mã nhân viên],
        nv.Ten_nhan_vien AS [Tên nhân viên],
        nv.SDT AS [Số điện thoại nhân viên]  -- Bổ sung số điện thoại nhân viên
    FROM 
        DON_BAN db
        LEFT JOIN KHACH_HANG kh ON db.Ma_khach_hang = kh.Ma_khach_hang
        LEFT JOIN KHUYEN_MAI km ON db.Ma_khuyen_mai = km.Ma_khuyen_mai
        LEFT JOIN NHAN_VIEN nv ON db.Ma_nhan_vien = nv.Ma_nhan_vien
    WHERE 
        db.Ma_don_ban = @Ma_don_ban
);
GO

-- Sửa đơn bán
CREATE PROCEDURE [dbo].[Fn_SuaDonBan]
(
    @Ma_don_ban CHAR(50),
    @Ma_khach_hang CHAR(50),
    @Ma_khuyen_mai CHAR(50),
    @So_tien_tra NUMERIC(18,2),
    @Tri_gia NUMERIC(18,2)
)
AS
BEGIN
    -- Kiểm tra nếu đơn bán tồn tại dựa vào mã đơn bán
    IF EXISTS (SELECT 1 FROM DON_BAN WHERE Ma_don_ban = @Ma_don_ban)
    BEGIN
        -- Cập nhật các cột Ma_khach_hang, Ma_khien_mai, So_tien_tra và Tri_gia
        UPDATE DON_BAN
        SET Ma_khach_hang = @Ma_khach_hang,
            Ma_khuyen_mai = @Ma_khuyen_mai,
            So_tien_tra = @So_tien_tra,
            Tri_gia = @Tri_gia,
            Trang_thai = CASE 
                            WHEN @So_tien_tra >= @Tri_gia THEN N'Hoàn thành'
                            ELSE N'Chưa hoàn thành'
                         END
        WHERE Ma_don_ban = @Ma_don_ban;
    END
    ELSE
    BEGIN
        -- Thông báo nếu đơn bán không tồn tại
        PRINT 'Không tìm thấy đơn bán với mã đơn bán đã cung cấp.';
    END
END;
GO

-- Tạo đơn bán trong bảng DON_BAN
CREATE PROCEDURE [dbo].[Fn_ThemMoiDonHang]
    @Ma_don_ban NVARCHAR(50),
    @Ngay_tao_don DATE,
    @Gio_tao_don TIME,
    @Tri_gia DECIMAL(18, 2),
    @SL_dien_thoai INT,
    @So_tien_tra DECIMAL(18, 2),
    @Trang_thai NVARCHAR(20),
    @Ma_khach_hang NVARCHAR(50),
    @Ma_nhan_vien NVARCHAR(50) = NULL, -- Cho phép NULL nếu không có mã nhân viên
    @Ma_khuyen_mai NVARCHAR(50) = NULL -- Cho phép NULL nếu không có mã khuyến mãi
AS
BEGIN
    INSERT INTO DON_BAN (
        Ma_don_ban, Ngay_tao_don, Gio_tao_don, Tri_gia, SL_dien_thoai, So_tien_tra, Trang_thai, Ma_khach_hang, Ma_nhan_vien, Ma_khuyen_mai
    )
    VALUES (
        @Ma_don_ban, @Ngay_tao_don, @Gio_tao_don, @Tri_gia, @SL_dien_thoai, @So_tien_tra, @Trang_thai, @Ma_khach_hang, @Ma_nhan_vien, @Ma_khuyen_mai
    );
END
GO

-- Tạo đơn bán thì tạo chi tiết đơn hàng trong bảng CT_DON_BAN
CREATE PROCEDURE [dbo].[Fn_ThemVaoChiTietDonHang]
(
    @Ma_Imei CHAR(50),
    @Ma_don_ban CHAR(50)
)
AS
BEGIN
    -- Chèn bản ghi mới vào bảng CT_DON_BAN
    INSERT INTO CT_DON_BAN (Ma_Imei, Ma_don_ban)
    VALUES (@Ma_Imei, @Ma_don_ban);
END
GO

-- Cập nhật thông tin khách hàng
CREATE PROCEDURE [dbo].[sp_CapNhatThongTinKhachHang]
    @SDT NVARCHAR(15),
    @TenKhachHang NVARCHAR(50),
    @DiaChi NVARCHAR(100),
    @Gmail NVARCHAR(100)
AS
BEGIN
    UPDATE Dgv_DanhSachKhachHang
    SET [Tên khách hàng] = @TenKhachHang,
        [Địa chỉ] = @DiaChi,
        [Gmail] = @Gmail
    WHERE [Số điện thoại] = @SDT;
END
GO

-- Update số tiền còn lại
CREATE PROCEDURE [dbo].[sp_UpdateSoTienConLai]
    @MaDonBan NVARCHAR(50),
    @SoTienTraThem DECIMAL(18, 2)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @STT_ghi_no INT;
    DECLARE @SoTienConLai DECIMAL(18, 2);

    -- Find the corresponding STT_ghi_no from the GHI_NO table
    SELECT @STT_ghi_no = STT_ghi_no, 
           @SoTienConLai = Chua_thanh_toan
    FROM GHI_NO AS gn
    JOIN DON_BAN AS db ON db.Ma_khach_hang = gn.Ma_khach_hang
                      AND db.Ma_don_ban = @MaDonBan
                      AND db.Ngay_tao_don = gn.Ngay_ghi_no;

    -- Check if the remaining amount is sufficient
    IF @SoTienConLai >= @SoTienTraThem
    BEGIN
        -- Update the remaining amount in GHI_NO
        UPDATE GHI_NO
        SET Chua_thanh_toan = Chua_thanh_toan - @SoTienTraThem
        WHERE STT_ghi_no = @STT_ghi_no;

        -- Optional: Update the So_tien_tra in the DON_BAN table if needed
        UPDATE DON_BAN
        SET So_tien_tra = So_tien_tra + @SoTienTraThem
        WHERE Ma_don_ban = @MaDonBan;

        SELECT 1 AS Success, 'Cập nhật thành công!' AS Message;
    END
    ELSE
    BEGIN
        SELECT 0 AS Success, 'Số tiền trả thêm vượt quá số tiền còn lại. Vui lòng nhập số tiền nhỏ hơn.' AS Message;
    END
END;
GO

-- Thêm khách hàng
CREATE PROCEDURE [dbo].[ThemKhachHang]
    @Ma_khach_hang CHAR(50),
    @SDT VARCHAR(18),
    @Ten_khach_hang NVARCHAR(36) = NULL,
    @Dia_chi NVARCHAR(63) = NULL,
    @Gmail VARCHAR(36) = NULL
AS
BEGIN
    -- Thêm khách hàng mới vào bảng
    INSERT INTO KHACH_HANG (Ma_khach_hang, SDT, Ten_khach_hang, Dia_chi, Gmail)
    VALUES (@Ma_khach_hang, @SDT, @Ten_khach_hang, @Dia_chi, @Gmail);
END;
GO

-- Đơn bán theo mã ??? Có lỗi logic, chỉ xóa nhưng đơn ko có sản phẩm nào bên trong
CREATE PROCEDURE [dbo].[XoaDonBanTheoMa]
    @MaDonBan CHAR(50) -- Tham số đầu vào là mã đơn bán
AS
BEGIN
    SET NOCOUNT ON; -- Ngăn ngừa thông báo số hàng ảnh hưởng

    BEGIN TRY
        -- Xóa bản ghi từ bảng DON_BAN dựa vào mã đơn bán
        DELETE FROM DON_BAN
        WHERE Ma_don_ban = @MaDonBan;

        -- Kiểm tra xem có thực hiện xóa thành công không
        IF @@ROWCOUNT = 0
        BEGIN
            PRINT 'Không tìm thấy mã đơn bán để xóa.';
        END
        ELSE
        BEGIN
            PRINT 'Xóa thành công mã đơn bán: ' + @MaDonBan;
        END
    END TRY
    BEGIN CATCH
        -- Xử lý lỗi nếu có
        PRINT 'Có lỗi xảy ra: ' + ERROR_MESSAGE();
    END CATCH
END;
GO