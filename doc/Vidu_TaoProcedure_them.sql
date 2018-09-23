
CREATE PROCEDURE dbo.spBaiSanPham_Them
	-- Add the parameters for the stored procedure here
	@SoDonHang	nvarchar(50),
	@TenSanPham	nvarchar(150),
	@YeuCau	nvarchar(500),
	@DuongDanFile01	nvarchar(255),
	@DuongDanFile02	nvarchar(255),
	@DuongDanFile03	nvarchar(255),
	@TinhTrangBaiSanPham nchar(16),
	@ThoiHan datetime,
	@id int = 0 output
AS
BEGIN
	
	SET NOCOUNT ON;

    insert into dbo.BaiSanPham (SoDonHang, TenSanPham, YeuCau, DuongDanFile01, DuongDanFile02,
		DuongDanFile03, TinhTrangBaiSanPham, ThoiHan)
		values (@SoDonHang, @TenSanPham, @YeuCau, @DuongDanFile01, @DuongDanFile02,
		@DuongDanFile03, @TinhTrangBaiSanPham, @ThoiHan);

	select @id = SCOPE_IDENTITY();
	
END
GO
