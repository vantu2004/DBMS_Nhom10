-- Lấy danh sách điện thoại kết hợp dòng máy
CREATE VIEW [dbo].[Dgv_DanhSachDienThoai] AS
SELECT 
    dm.Ma_dong_may AS [Mã dòng máy],
    dm.Ten_dong_may AS [Tên dòng máy],
    dm.Kich_thuoc AS [Kích thước màn hình],
    dm.Dung_luong_pin AS [Dung lượng pin],
    dt.Ma_Imei AS [Mã Imei],
    dt.Mau_sac AS [Màu sắc],
    dt.Trang_thai AS [Trạng thái],
    dt.Thue AS [Thuế],
    dt.Gia_ban AS [Giá bán],
    dt.Gia_nhap AS [Giá nhập],
	dt.Hinh_anh AS [Hình ảnh]
FROM 
    DIEN_THOAI dt
    LEFT JOIN DONG_MAY dm ON dt.Ma_dong_may = dm.Ma_dong_may;
GO


-- Lấy danh sách điện thoại có trạng thái chưa bán
CREATE VIEW [dbo].[Dgv_DanhSachDienThoaiSanCo]
AS
SELECT    dm.Ma_dong_may AS [Mã dòng máy], dm.Ten_dong_may AS [Tên dòng máy], dm.Kich_thuoc AS [Kích thước màn hình], dm.Dung_luong_pin AS [Dung lượng pin], dt.Ma_Imei AS [Mã Imei], dt.Mau_sac AS [Màu sắc], 
                      dt.Trang_thai AS [Trạng thái], dt.Thue AS Thuế, dt.Gia_ban AS [Giá bán], dt.Gia_nhap AS [Giá nhập], dt.Hinh_anh AS [Hình ảnh]
FROM         dbo.DIEN_THOAI AS dt LEFT OUTER JOIN
                      dbo.DONG_MAY AS dm ON dt.Ma_dong_may = dm.Ma_dong_may
WHERE     (TRIM(dt.Trang_thai) <> N'Đã bán')
GO

-- Lấy thông tin chi tiết đơn hàng
CREATE VIEW [dbo].[Dgv_ChiTietDonHang] AS
SELECT 
    db.Ma_don_ban AS [Mã đơn bán],  -- Thêm cột Ma_don_ban
    dm.Ma_dong_may AS [Mã dòng máy],
    dm.Ten_dong_may AS [Tên dòng máy],
    dm.Kich_thuoc AS [Kích thước màn hình],
    dm.Dung_luong_pin AS [Dung lượng pin],
    dt.Ma_Imei AS [Mã Imei],
    dt.Mau_sac AS [Màu sắc],
    dt.Trang_thai AS [Trạng thái],
    dt.Thue AS [Thuế],
    dt.Gia_ban AS [Giá bán],
    dt.Gia_nhap AS [Giá nhập],
    dt.Hinh_anh AS [Hình ảnh]
FROM 
    CT_DON_BAN cdb
JOIN 
    DIEN_THOAI dt ON cdb.Ma_Imei = dt.Ma_Imei
JOIN 
    DON_BAN db ON cdb.Ma_don_ban = db.Ma_don_ban
JOIN 
    DONG_MAY dm ON dt.Ma_dong_may = dm.Ma_dong_may;
GO

-- Lấy thông tin chi tiết của đơn nhập
CREATE VIEW [dbo].[Dgv_ChiTietDonNhap] AS
SELECT 
    dn.Ma_don_nhap AS [Mã đơn nhập], -- Thêm thuộc tính mã đơn nhập
    dm.Ma_dong_may AS [Mã dòng máy],
    dm.Ten_dong_may AS [Tên dòng máy],
    dm.Kich_thuoc AS [Kích thước màn hình],
    dm.Dung_luong_pin AS [Dung lượng pin],
    dt.Ma_Imei AS [Mã Imei],
    dt.Mau_sac AS [Màu sắc],
    dt.Trang_thai AS [Trạng thái],
    dt.Thue AS [Thuế],
    dt.Gia_ban AS [Giá bán],
    dt.Gia_nhap AS [Giá nhập],
    dt.Hinh_anh AS [Hình ảnh]
FROM 
    CT_DON_NHAP ctn
JOIN 
    DIEN_THOAI dt ON ctn.Ma_Imei = dt.Ma_Imei
JOIN 
    DON_NHAP dn ON ctn.Ma_don_nhap = dn.Ma_don_nhap
JOIN 
    DONG_MAY dm ON dt.Ma_dong_may = dm.Ma_dong_may;
GO

-- Chi tiết thanh toán
CREATE VIEW [dbo].[Dgv_ChiTietThanhToan] AS
SELECT DISTINCT
    MIN(gn.STT_ghi_no) AS [Số thứ tự], 
    gn.Ma_khach_hang AS [Mã khách hàng], 
    gn.Ngay_ghi_no AS [Ngày thanh toán], 
    gn.Chua_thanh_toan AS [Số tiền còn lại chưa thanh toán], 
    db.Ma_don_ban AS [Mã đơn bán],  
    db.Tri_gia AS [Tổng giá trị], 
    db.So_tien_tra AS [Số tiền đã trả]
FROM dbo.GHI_NO AS gn
LEFT OUTER JOIN dbo.DON_BAN AS db 
    ON db.Ma_khach_hang = gn.Ma_khach_hang 
    AND db.Ngay_tao_don = gn.Ngay_ghi_no
GROUP BY 
    gn.Ma_khach_hang, 
    gn.Ngay_ghi_no, 
    gn.Chua_thanh_toan, 
    db.Ma_don_ban, 
    db.Tri_gia, 
    db.So_tien_tra;
GO

-- Danh sách đơn nhập
CREATE VIEW [dbo].[Dgv_DanhSachDonNhap] AS
SELECT 
    ncc.Ma_NCC AS [Mã nhà cung cấp],
    ncc.Ten_NCC AS [Tên nhà cung cấp],
    ncc.SDT AS [Số điện thoại nhà cung cấp],
    ncc.Dia_chi AS [Địa chỉ],
    dn.Ma_don_nhap AS [Mã đơn nhập],
    dn.Ngay_nhap AS [Ngày nhập],
    dn.Tri_gia AS [Trị giá],
    dn.SL_dien_thoai AS [Số lượng],
    nv.Ma_nhan_vien AS [Mã nhân viên],
    nv.Ten_nhan_vien AS [Tên nhân viên]
FROM 
    DON_NHAP dn
    LEFT JOIN NHA_CUNG_CAP ncc ON dn.Ma_NCC = ncc.Ma_NCC
    LEFT JOIN NHAN_VIEN nv ON dn.Ma_nhan_vien = nv.Ma_nhan_vien;
GO

-- Danh sách khách hàng
CREATE VIEW [dbo].[Dgv_DanhSachKhachHang] AS
SELECT 
    kh.Ma_khach_hang AS [Mã khách hàng],
    kh.SDT AS [Số điện thoại],
    kh.Gmail AS [Gmail],
    kh.Dia_chi AS [Địa chỉ],
    kh.Ten_khach_hang AS [Tên khách hàng]
FROM 
    KHACH_HANG kh;
GO

-- Danh sách khuyến mãi
CREATE VIEW [dbo].[Dgv_DanhSachMaKhuyenMai] AS
SELECT 
    km.Ma_khuyen_mai AS [Mã khuyến mãi],
    km.Chiet_khau AS [Chiết khấu],
    km.Ngay_ap_dung AS [Ngày áp dụng],
    km.Ngay_ket_thuc AS [Ngày kết thúc],
    km.Ten_chuong_trinh AS [Tên chương trình],
    km.SL_ap_dung AS [Số lượng áp dụng]
FROM 
    KHUYEN_MAI km;
GO

-- Danh sách sản phẩm
CREATE VIEW [dbo].[Dgv_DanhSachSanPham] AS
SELECT 
    dm.Ma_dong_may AS [Mã dòng máy],
    dm.Ten_dong_may AS [Tên dòng máy],
    dm.Kich_thuoc AS [Kích thước màn hình],
    dm.Dung_luong_pin AS [Dung lượng pin],
    dt.Ma_Imei AS [Mã Imei],
    dt.Mau_sac AS [Màu sắc],
    dt.Trang_thai AS [Trạng thái],
    dt.Thue AS [Thuế],
    dt.Gia_ban AS [Giá bán],
    dt.Gia_nhap AS [Giá nhập],
	dt.Hinh_anh AS [Hình ảnh]
FROM 
    DIEN_THOAI dt
    LEFT JOIN DONG_MAY dm ON dt.Ma_dong_may = dm.Ma_dong_may;
GO

-- Danh sách điện thoại đã thêm ??? Có vẻ hơi thừa
CREATE VIEW [dbo].[Dgv_DienThoaiDaThem] AS
SELECT 
    dm.Ma_dong_may AS [Mã dòng máy],
    dm.Ten_dong_may AS [Tên dòng máy],
    dm.Kich_thuoc AS [Kích thước màn hình],
    dm.Dung_luong_pin AS [Dung lượng pin],
    dt.Ma_Imei AS [Mã Imei],
    dt.Mau_sac AS [Màu sắc],
    dt.Trang_thai AS [Trạng thái],
    dt.Thue AS [Thuế],
    dt.Gia_ban AS [Giá bán],
    dt.Gia_nhap AS [Giá nhập],
	dt.Hinh_anh AS [Hình ảnh]
FROM 
    DIEN_THOAI dt
    LEFT JOIN DONG_MAY dm ON dt.Ma_dong_may = dm.Ma_dong_may;
GO

-- Sản phẩm cần cập nhật ??? Có vẻ hơi thừa
CREATE VIEW [dbo].[dgv_SanPhamCanCapNhat] AS
SELECT 
    dm.Ma_dong_may AS [Mã dòng máy],
    dm.Ten_dong_may AS [Tên dòng máy],
    dm.Kich_thuoc AS [Kích thước màn hình],
    dm.Dung_luong_pin AS [Dung lượng pin],
    dt.Ma_Imei AS [Mã Imei],
    dt.Mau_sac AS [Màu sắc],
    dt.Trang_thai AS [Trạng thái],
    dt.Thue AS [Thuế],
    dt.Gia_ban AS [Giá bán],
    dt.Gia_nhap AS [Giá nhập],
	dt.Hinh_anh AS [Hình ảnh]
FROM 
    DIEN_THOAI dt
    LEFT JOIN DONG_MAY dm ON dt.Ma_dong_may = dm.Ma_dong_may;
GO

-- Danh sách đơn bán
CREATE VIEW [dbo].[Dgv_DanhSachDonHang] AS
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
    LEFT JOIN NHAN_VIEN nv ON db.Ma_nhan_vien = nv.Ma_nhan_vien;
GO

