
USE QL_CAFE_BALCONY
GO
ALTER PROC HienthiDouong
AS
BEGIN
    SELECT * FROM dbo.DOUONG
END

GO
EXEC dbo.HienthiDouong
---
GO
CREATE PROC HienthiDouongkhongbia
AS
BEGIN
    SELECT * FROM dbo.DOUONG WHERE LoaiDoUong!='BEER'
END

GO 
EXEC dbo.HienthiDouongkhongbia

--insert
GO
CREATE PROC InsertDoUong(@madouong VARCHAR(10), @tendouong NVARCHAR(50), @loaidouong VARCHAR(10), @dotangkem VARCHAR(10), @dongia MONEY)
AS
BEGIN
	INSERT INTO dbo.DOUONG
	(
	    MaDoUong,
	    TenDoUong,
	    LoaiDoUong,
	    DoTangKem,
	    DonGiaDoUong
	)
	VALUES
	(   @madouong,  -- MaDoUong - varchar(10)
	    @tendouong, -- TenDoUong - nvarchar(50)
	    @loaidouong,  -- LoaiDoUong - varchar(10)
	    @dotangkem,  -- DoTangKem - varchar(10)
	    @dongia -- DonGiaDoUong - money
	    )
END

GO
EXEC dbo.InsertDoUong @madouong , @tendouong ,  @loaidouong ,  @dotangkem , @dongia

----
GO
CREATE PROC UpdateDoUong(@madouong VARCHAR(10), @tendouong NVARCHAR(50), @loaidouong VARCHAR(10), @dotangkem VARCHAR(10), @dongia MONEY)
AS
BEGIN
    UPDATE dbo.DOUONG
	SET TenDoUong=@tendouong, LoaiDoUong=@loaidouong, DoTangKem=@dotangkem, DonGiaDoUong=@dongia
	WHERE MaDoUong=@madouong
END

GO
EXEC dbo.UpdateDoUong @madouong = '',   -- varchar(10)
                      @tendouong = N'', -- nvarchar(50)
                      @loaidouong = '', -- varchar(10)
                      @dotangkem = '',  -- varchar(10)
                      @dongia = NULL    -- money

---

GO
CREATE PROC DeleteDoUong(@madouong VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.DOUONG WHERE MaDoUong=@madouong
END

GO
EXEC dbo.DeleteDoUong @madouong = '' -- varchar(10)
---Lấy đơn giá đồ uống by madouong
GO
CREATE PROC LayDongiaDoUongByID(@madouong VARCHAR(10))
AS
BEGIN
    SELECT DonGiaDoUong FROM dbo.DOUONG WHERE MaDoUong=@madouong
END
--
EXEC dbo.LayDongiaDoUongByID @madouong = '' -- varchar(10)

-----------
GO
ALTER PROC HienthiMenuDouong
AS
BEGIN
    SELECT TenDoUong 'Tên đồ uống', DonGiaDoUong 'Đơn giá', TenDoTangKem 'Đồ tặng kèm', TenLoai 'Loại đồ uống'
	FROM dbo.DOUONG, dbo.LOAIDOUONG, dbo.DOTANGKEM
	WHERE LoaiDoUong=MaLoai AND	DoTangKem=MaDoTangKem
END
--
EXEC dbo.HienthiMenuDouong
------


---------------------------

GO
ALTER PROC HienthiCombo
AS
BEGIN
    SELECT * FROM dbo.COMBO
END
---LayDongiaComboByID
GO
CREATE PROC LayDongiaComboByID(@macombo VARCHAR(10))
AS
BEGIN
    SELECT DongiaCombo FROM dbo.COMBO WHERE MaCombo=@macombo
END
--
GO
EXEC dbo.LayDongiaComboByID @macombo = '' -- varchar(10)

---insert combo normal
GO
CREATE PROC InsertCombo(@macombo VARCHAR(10), @tencombo NVARCHAR(50), @dongia MONEY)
AS
BEGIN
    INSERT INTO dbo.COMBO
    (
        MaCombo,
        TenCombo,
        DongiaCombo
    )
    VALUES
    (   @macombo,  -- MaCombo - varchar(10)
        @tencombo, -- TenCombo - nvarchar(50)
        @dongia -- DongiaCombo - money
        )
END
--
GO
EXEC dbo.InsertCombo @macombo @tencombo @dongia
---
GO
CREATE PROC updateDongiaCombobyID(@macombo VARCHAR(10), @dongia MONEY)
AS
BEGIN
    UPDATE dbo.COMBO SET DongiaCombo=@dongia WHERE MaCombo=@macombo
END
--
GO
EXEC dbo.updateDongiaCombobyID @macombo , @dongia 
---deleteComboByID
GO
CREATE PROC deleteComboByID(@macombo VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.COMBO WHERE MaCombo=@macombo
END
--
GO
EXEC dbo.deleteComboByID @macombo = '' -- varchar(10)
---updateComboByID
GO
CREATE PROC updateComboByID(@macombo VARCHAR(10), @tencombo NVARCHAR(50))
AS
BEGIN
    UPDATE dbo.COMBO SET TenCombo=@tencombo WHERE MaCombo=@macombo
END
--
GO
EXEC dbo.updateComboByID @macombo , @tencombo
---------
GO
CREATE PROC DeleteChitietcomboByIDdouong(@madouong VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.CHITIETCOMBO WHERE ListDoUong=@madouong
END

GO
EXEC dbo.DeleteChitietcomboByIDdouong @madouong = '' -- varchar(10)
---delete chi tiet combo by id combo
GO
CREATE PROC DeleteChitietcomboByIDCombo(@macombo VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.CHITIETCOMBO WHERE Macombo=@macombo
END

GO
EXEC dbo.DeleteChitietcomboByIDCombo @macombo = '' -- varchar(10)
---insert chi tiet combo
GO
ALTER PROC insertChitietCombo(@macombo VARCHAR(10), @listdouong VARCHAR(10), @soluong INT)
AS
BEGIN
    INSERT INTO dbo.CHITIETCOMBO
    (
        Macombo,
        ListDoUong,
		SoLuong
    )
    VALUES
    (   @macombo, -- Macombo - varchar(10)
        @listdouong,  -- ListDoUong - varchar(10)
		@soluong
        )
END
--
GO
EXEC dbo.insertChitietCombo @macombo , @listdouong , @soluong
---delete chi tiet combo
GO
ALTER PROC deleteChitietCombo(@macombo VARCHAR(10), @madouong VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.CHITIETCOMBO WHERE Macombo=@macombo AND ListDoUong=@madouong
END
--
GO
EXEC dbo.deleteChitietCombo @macombo , @madouong
------
GO
ALTER PROC DataChitietComboTheoID(@macombo VARCHAR(10))
AS
BEGIN
    SELECT * FROM dbo.CHITIETCOMBO WHERE Macombo=@macombo
END

GO
EXEC dbo.DataChitietComboTheoID @macombo = '' -- varchar(10)

-------
GO
EXEC dbo.HienthiCombo
---
GO
ALTER PROC HienthiMenuCombo
AS
BEGIN
    SELECT TenCombo 'Tên Combo', ListDoUong 'Đồ uống', DongiaCombo 'Đơn giá'
	FROM dbo.COMBO, dbo.CHITIETCOMBO
	WHERE CHITIETCOMBO.Macombo=COMBO.MaCombo
END

GO 
EXEC dbo.HienthiMenuCombo
---Menu list do uong by id combo
GO
ALTER PROC HienthiMenuListDouongByIDCombo(@idcombo VARCHAR(10))
AS
BEGIN
    SELECT ListDoUong 'Tên đồ uống', SoLuong 'Số lượng'
	FROM dbo.CHITIETCOMBO
	WHERE Macombo=@idcombo
END
--
EXEC dbo.HienthiMenuListDouongByIDCombo	 @idcombo = '' -- varchar(10)


---Lay id phieu Ban Hang = ngay ban hang
GO
CREATE PROC LayMaPhieuByNgayBH(@ngaybh DATETIME)
AS
BEGIN
    SELECT MaphieuBH FROM dbo.PHIEUBH WHERE NgayBH=@ngaybh
END
--
EXEC dbo.LayMaPhieuByNgayBH @ngaybh = '2017-11-07 16:33:55' -- datetime


---insert Phieu Ban Hang
GO
ALTER FUNCTION NextHoaDonIndentity()--Thiết lập thuộc tính tự tăng của mã hóa đơn
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @lastvalue VARCHAR(10)
	SET @lastvalue = (SELECT MAX(MaphieuBH) FROM dbo.PHIEUBH)
	IF (@lastvalue IS NULL) SET @lastvalue = 'HD0000000'
	DECLARE @i INT
	SET @i = RIGHT(@lastvalue,7) + 1
	RETURN 'HD' + RIGHT('000000' + CONVERT(VARCHAR(10),@i),7);
END
--
GO
ALTER PROC insertPhieuBanHang(@ngaybh DATETIME, @loaibh VARCHAR(10), @tenkh NVARCHAR(50), @sdt VARCHAR(20))
AS
BEGIN
    INSERT INTO dbo.PHIEUBH
    (
        MaphieuBH,
        NgayBH,
        LoaiBH,
        TenKH,
        SoDienthoai,
		TongTien,
		TrangThai
    )
    VALUES
    (   dbo.NextHoaDonIndentity(),        -- MaphieuBH - varchar(10)
        @ngaybh, -- NgayBH - datetime
        @loaibh,        -- LoaiBH - varchar(10)
        @tenkh,       -- TenKH - nvarchar(50)
        @sdt,         -- SoDienthoai - varchar(20)
		0,
		0
        )
END
--
GO
EXEC dbo.insertPhieuBanHang @ngaybh , @loaibh , @tenkh , @sdt 
---delete Phieu Ban Hang
GO
ALTER PROC deletePhieuBH(@maphieu VARCHAR(10))
AS
BEGIN
    DELETE FROM dbo.PHIEUBH WHERE MaphieuBH=@maphieu
	DELETE FROM dbo.CHITIETPHIEUBH WHERE MaphieuBH=@maphieu
END
--
GO
EXEC dbo.deletePhieuBH @maphieu = '' -- char(10)

---Lay tinh trang phieu BH
GO
ALTER PROC LayTrangThaiPhieuBH(@maphieu VARCHAR(10))
AS
BEGIN
    SELECT TrangThai FROM dbo.PHIEUBH WHERE MaphieuBH=@maphieu
END
--
EXEC dbo.LayTrangThaiPhieuBH @maphieu = 'HD0000001' -- char(10)

---update phieubh
GO
ALTER PROC UpdatePhieuBH(@maphieu CHAR(10), @ngaybh DATETIME, @loaibh VARCHAR(10), @tenkh NVARCHAR(50), @sdt VARCHAR(20))
AS
BEGIN
    UPDATE dbo.PHIEUBH SET NgayBH=@ngaybh, LoaiBH=@loaibh, TenKH=@tenkh, SoDienthoai=@sdt
	WHERE MaphieuBH=@maphieu
END
--
GO
EXEC dbo.UpdatePhieuBH @maphieu , @ngaybh @loaibh , @tenkh , @sdt

---insert chi tiet PhieuBH
GO
ALTER PROC InsertChitietPhieuBH(@maphieu VARCHAR(10), @mathanhphan VARCHAR(10), @tenthanhphan NVARCHAR(50), @soluong INT, @dongia MONEY, @ghichu NVARCHAR(50))
AS
BEGIN
    INSERT INTO dbo.CHITIETPHIEUBH
    (
        MaphieuBH,
        MaThanhPhan,
		TenThanhphan,
        Soluong,
		Dongia,
        Ghichu
    )
    VALUES
    (   @maphieu,   -- MaphieuBH - varchar(10)
        @mathanhphan,
		@tenthanhphan,
        @soluong,    -- Soluong - int
		@dongia,
        @ghichu   -- Ghichu - nvarchar(50)
        )
	UPDATE dbo.PHIEUBH
	SET TongTien=TongTien+@dongia
	WHERE MaphieuBH=@maphieu
END
--
GO
EXEC dbo.InsertChitietPhieuBH @maphieu , @mathanhphan , @tenthanhphan , @soluong , @dongia  , @ghichu = N''      -- nvarchar(50)

---delete chi tiet Phieu BH
GO
CREATE PROC deleteCTPhieuBHByID(@maphieu VARCHAR(10), @mathanhphan VARCHAR(10))
AS
BEGIN
	DECLARE @dongia MONEY
	SELECT @dongia= Dongia FROM dbo.CHITIETPHIEUBH WHERE MaphieuBH=@maphieu AND MaThanhPhan=@mathanhphan
	UPDATE dbo.PHIEUBH
	SET TongTien=TongTien-@dongia
	WHERE MaphieuBH=@maphieu
    DELETE FROM	dbo.CHITIETPHIEUBH WHERE MaphieuBH=@maphieu AND MaThanhPhan=@mathanhphan
END
--
EXEC dbo.deleteCTPhieuBHByID @maphieu , @mathanhphan = '' -- varchar(10)




