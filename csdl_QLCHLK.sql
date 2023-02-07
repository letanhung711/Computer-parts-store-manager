CREATE Database csdl_QLCHLK
GO

USE csdl_QLCHLK
GO

------Tao bang------
CREATE TABLE NhomLK
(
	MaNhomLK	VarChar(10) primary key,
	TenNhomLK	nVarChar(50)
);
GO

CREATE TABLE ChucVu
(
	MaCV		VarChar(10) primary key,
	TenCV		nVarChar(50)
);
GO

CREATE TABLE LoaiLK
(
	MaLoaiLK	VarChar(10) primary key,
	TenLoai		nVarChar(50),
	NgayTao		Datetime,
	NgayCapNhat Datetime,
	MaNhomLK	VarChar(10)
	--Tao khoa ngoai---
	CONSTRAINT FK_LoaiLK_NHOMLK FOREIGN KEY (MaNhomLK) REFERENCES NhomLK(MaNhomLK)
);
GO

CREATE TABLE NhanVien
(
	MaNV		VarChar(10) primary key,
	MatKhau		VarChar(10),
	TenNV		nVarChar(50),
	SDT			Char(30),
	GioiTinh	Bit,
	DiaChi		nVarChar(50),
	MaCV		VarChar(10)
	--Tao khoa ngoai---
	CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY (MaCV) REFERENCES ChucVu(MaCV)
);
GO

CREATE TABLE ThuongHieu
(
	MaTH		VarChar(10) primary key,
	TenTH		nVarChar(50),
	MaNhomLK	VarChar(10),
	NgayTao		Datetime,
	NgayCapNhat Datetime
		
	--Tao khoa ngoai---
	CONSTRAINT FK_ThuongHieu_NHOMLK FOREIGN KEY (MaNhomLK) REFERENCES NhomLK(MaNhomLK)	
);
GO

CREATE TABLE QLLK
(
	MaLK		VarChar(10) primary key,
	TenLK		nVarChar(50),
	Gia			VarChar(50),
	MaTH		VarChar(10),
	MaLoaiLK	VarChar(10),
	BaoHanh		Char(10),
	MaNhomLK	VarChar(10),
	Mota		nVarChar(60)
	--Tao khoa ngoai---
	CONSTRAINT FK_QLLK_NHOMLK FOREIGN KEY (MaNhomLK) REFERENCES NhomLK(MaNhomLK),
	CONSTRAINT FK_QLLK_LoaiLK FOREIGN KEY (MaLoaiLK) REFERENCES LoaiLK(MaLoaiLK),
	CONSTRAINT FK_QLLK_ThuongHieu FOREIGN KEY (MaTH) REFERENCES ThuongHieu(MaTH)
);
GO


CREATE TABLE KhachHang
(
	MaKH		VarChar(10) primary key,
	TenKH		nVarChar(50),
	SDT			Char(30),
	DiaChi		nVarChar(50),
	NgayTao		Datetime,
	NgayCapNhat Datetime
);
GO

CREATE TABLE NhapKho
(
	MaPNhap		VarChar(10) primary key,
	MaNV		VarChar(10),
	NgayNhap	Datetime,
	TongSL		int,
	TongTien	int,
	--Tao khoa ngoai---
	CONSTRAINT FK_NhapKho_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
GO
CREATE TABLE SPNhap
(
	STT			int,
	MaLK		varchar(10),
	MaPNhap		varchar(10),
	GiaNhap		int,
	SLNhap		int
	--Tao khoa ngoai---
	CONSTRAINT FK_SPNhap_QLLK FOREIGN KEY (MaLK) REFERENCES QLLK(MaLK),
	CONSTRAINT FK_SPNhap_NhapKho FOREIGN KEY (MaPNhap) REFERENCES NhapKho(MaPNhap)
);
GO

CREATE TABLE XuatKho
(
	MaPXuat		VarChar(10) primary key,
	MaNV		VarChar(10),
	MaKH		VarChar(10),
	NgayXuat	Datetime,
	TongSl		int,
	TongTien	int
	--Tao khoa ngoai---
	CONSTRAINT FK_XuatKho_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
	CONSTRAINT FK_XuatKho_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);
GO
CREATE TABLE SPXuat
(
	STT			int,
	MaLK		varchar(10),
	MaPXuat		varchar(10),
	GiaXuat		int,
	SLXuat		int
	--Tao khoa ngoai---
	CONSTRAINT FK_SPXuat_QLLK FOREIGN KEY (MaLK) REFERENCES QLLK(MaLK),
	CONSTRAINT FK_SPXuat_XuatKho FOREIGN KEY (MaPXuat) REFERENCES XuatKho(MaPXuat)
);
GO

----Them du lieu------
---NhomLK----
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('CASE',N'CASE-Thùng máy')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('CPU',N'CPU-Bộ vi xử lí')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('HDD',N'HDD-Ổ cứng PC')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('MAIN',N'MainBoard-Bo mạch chủ')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('PSU',N'PSU-Bộ nguồn')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('RAM',N'RAM-Bộ nhớ trong')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('SSD',N'SSD-Ổ cứng rắn')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('VGA',N'VGA-Card màn hình')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('ODD',N'ODD-Ổ đĩa quang')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('KEYBOARD',N'Keyboard-Bàn phím')
INSERT INTO NhomLK([MaNhomLK], [TenNhomLK])VALUES('MOUSE',N'Mouse-Chuột')

----ChucVu------
INSERT INTO ChucVu([MaCV], [TenCV])VALUES('CV01',N'Quản lí')
INSERT INTO ChucVu([MaCV], [TenCV])VALUES('CV02',N'Nhân viên')

----LoaiLK----
--case---
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('CASE01',N'Mini Tower','CASE','09/24/2021','10/04/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('CASE02',N'Mid Tower','CASE','09/24/2021','04/27/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('CASE03',N'Full Tower','CASE','05/13/2021','01/31/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('CASE04',N'Ultra Tower/ Super Tower','CASE','06/29/2021','03/17/2022')
---cpu---
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('Intel','Intel Core','CPU','06/23/2022','08/12/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('AMD','AMD Ryzen','CPU','07/14/2022','11/10/2022')
---hdd--
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('HDD01','HDD 2.5','HDD','05/23/2021','03/12/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('HDD02','HDD 3.5','HDD','06/13/2021','08/05/2021')
--main---
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('MAIN01','ATX','MAIN','02/07/2022','04/12/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('MAIN02','Extended ATX','MAIN','11/07/2021','01/28/2022')
---psu--
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('PSU01','PSU-500W','PSU','12/28/2021','01/11/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('PSU02','PSU-550W','PSU','05/02/2022','07/10/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('PSU03','PSU-600W','PSU','05/05/2022','04/28/2022')
--ram--
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('RAM01','DDR3','RAM','02/16/2021','05/11/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('RAM02','DDR4','RAM','02/16/2021','04/28/2022')
---ssd--
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('SSD01','SSD mSATA','SSD','04/16/2021','07/19/2021')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('SSD02','SSD M2 SATA','SSD','05/23/2021','08/29/2021')
--vga--
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('VGA01',N'Card Onboard','VGA','02/16/2021','04/17/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('VGA02',N'Card rời','VGA','09/13/2022','12/21/2022')
--odd--
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('ODD01',N'Đĩa quang rời','ODD','01/16/2021','05/11/2022')
--keyboard--
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('KEY01','Blue Switch','KEYBOARD','05/01/2022','05/28/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('KEY02','Red Switch','KEYBOARD','06/16/2021','07/27/2022')
--mouse---
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('MOUSE01',N'Có dây','MOUSE','01/16/2021','05/11/2022')
INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('MOUSE02',N'Không dây','MOUSE','01/29/2021','03/12/2022')

-----NhanVien-------
INSERT INTO NhanVien([MaNV],[TenNV],[GioiTinh],[DiaChi],[SDT],[MatKhau],[MaCV])VALUES('NV0001',N'Lê Văn A',1,N'Tiền Giang','0787234567','ql123','CV01')
INSERT INTO NhanVien([MaNV],[TenNV],[GioiTinh],[DiaChi],[SDT],[MatKhau],[MaCV])VALUES('NV0002',N'Nguyễn Van B',1,N'Long An','0787265473','nv123','CV02')

----KhachHang----
INSERT INTO KhachHang([MaKH],[TenKH],[SDT],[DiaChi],[NgayTao],[NgayCapNhat])VALUES('KH0001',N'Nguyễn Văn A','0901765823',N'Đà Nẵng','05/15/2022','05/15/2022')

---Thuonghieu---
---case---
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('COR','Corsair','CASE','03/23/2021','04/12/2021')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('MSI','MSI','CASE','03/23/2021','04/05/2021')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('CM','Cooler Master','CASE','03/23/2021','04/15/2021')
---cpu---
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('INT','Intel','CPU','05/27/2022','06/12/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('AMD','AMD','CPU','05/27/2022','07/21/2022')
----hdd---
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('SEA','Seagate','HDD','01/27/2022','06/26/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('WD','Western Digital (WD)','HDD','01/27/2022','03/12/2022')
----main---
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('AS','ASUS','MAIN','02/22/2022','05/03/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('GGB','GIGABYTE','MAIN','02/22/2022','05/03/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('ASR','ASRock','MAIN','02/22/2022','05/03/2022')
----psu----
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('Sc','Seasonic','PSU','02/25/2022','07/18/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('EVGA','EVGA','PSU','02/25/2022','07/29/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('TMT','Thermaltake','PSU','02/25/2022','07/29/2022')
----ram---
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('KT','Kingston','RAM','11/25/2021','05/11/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('HX','HyperX','RAM','12/23/2022','04/13/2022')
---ssd---
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('SS','SamSung','SSD','02/25/2022','07/29/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('AR','Apacer','SSD','03/08/2021','11/25/2021')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('LEX','Lexar','SSD','05/03/2022','08/11/2022')
--vga----
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('VAS','ASUS','VGA','04/22/2022','05/12/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('VMSI','MSI','VGA','04/22/2022','04/29/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('VGGB','GIGABYTE','PSU','04/23/2022','05/29/2022')
---odd----
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('OAS','ASUS','ODD','02/25/2022','07/29/2022')
---keyboard---
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('KCR','Corsair','KEYBOARD','02/25/2022','07/29/2022')
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('FIL','FILCO','KEYBOARD','02/25/2022','07/29/2022')
----mouse-----
INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('GEN','Genius','MOUSE','02/25/2022','09/11/2022')

---LINHKIEN----
--case---
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1001',N'Corsair Air 240 White','1200000','COR','CASE01','0','CASE',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1002',N'Corsair 4000D Airflow TG Black','1990000','COR','CASE02','1','CASE',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1003',N'CORSAIR iCUE 7000X','6990000','COR','CASE03','0','CASE',N'')

INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1004',N'MSI MAG FORGE 110R','899000','MSI','CASE02','0','CASE',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1005',N'MSI MAG FORGE M100A','850000','MSI','CASE01','2','CASE',N'')

INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1006',N'COOLER MASTER COSMOS C700M','11999000','CM','CASE03','2','CASE',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1007',N'Coolermaster Masterbox NR200','989000','CM','CASE01','0','CASE',N'')

---cpu----
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1101',N'Intel Core I5-12400F','2990000','INT','Intel','0','CPU',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1102',N'Intel Core I3-9100F','1599000','INT','Intel','1','CPU',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1103',N'Intel Core I3-5005U','599000','INT','Intel','0','CPU',N'')

INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1104',N'AMD Ryzen 5 5600G','5099000','AMD','AMD','1','CPU',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1105',N'AMD Ryzen 5 7600X ','8199000','AMD','AMD','1','CPU',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1106',N'AMD Ryzen 5 4500 ','2949000','AMD','AMD','0','CPU',N'')
---hdd---
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1201',N'WD Blue 1TB','1190000','WD','HDD01','0','HDD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1202',N'WD Blue 4TB','2359000','WD','HDD02','0','HDD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1203',N'Seagate Barracuda 1TB','920000','SEA','HDD01','1','HDD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP1204',N'Seagate Barracuda 2TB','1550000','SEA','HDD02','0','HDD',N'')
---main----
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2101',N'ASUS ROG STRIX B660-A','5199000','AS','MAIN01','1','MAIN',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2102',N'ASUS ROG MAXIMUS Z690','49999000','AS','MAIN02','3','MAIN',N'')

INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2103',N'Gigabyte Z690 UD AX DDR4 V2','5999000','GGB','MAIN01','1','MAIN',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2104',N'GIGABYTE Z690 AORUS XTREME','25490000','GGB','MAIN02','2','MAIN',N'')

INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2105',N'Asrock X670E Pro RS DDR5','8999000','ASR','MAIN01','0','MAIN',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2106',N'Asrock X670E Taichi DDR5','15699000','ASR','MAIN02','0','MAIN',N'')
----psu---
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2131',N'SeaSonic S12III-500','1090000','Sc','PSU01','2','PSU',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2132',N'Seasonic 550w S12III-550','1299000','Sc','PSU01','2','PSU',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2133',N'Seasonic PRIME 600','1549000','Sc','PSU03','3','PSU',N'')

INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2134',N'EVGA 100-BV-0500-K1 500W','1259000','EVGA','PSU01','2','PSU',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2135',N'EVGA 600 BR – 80+ BRONZE 600W','1390000','EVGA','PSU03','2','PSU',N'')

INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2136',N'Thermaltake Smart RGB 500W','1150000','TMT','PSU01','2','PSU',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2137',N'Thermaltake TR2 S 550W','1150000','TMT','PSU02','2','PSU',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP2138',N'Thermaltake Smart RGB 600W','1359000','TMT','PSU03','2','PSU',N'')
---ram---
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4051',N'Kingston KVR16N11S8/4 (1x4GB) DDR3 1600MHz','950000','KT','RAM01','1','RAM',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4052',N'Ram Kingston 8GB DDR3-1600 KVR16N11/8','1190000','KT','RAM01','1','RAM',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4053',N'Kingston 8G 1600MHZ DDR3 CL10 Dimm','1360000','HX','RAM01','1','RAM',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4054',N'HyperX Fury Black (8GB DDR4 1x8G 2666)','990000','HX','RAM02','1','RAM',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4055',N'Kingston DDR4 16Gb 2666','1390000','KT','RAM02','2','RAM',N'')
---ssd---
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4071',N'Samsung 860 Evo 500GB','2350000','SS','SSD01','1','SSD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4072',N'APACER AS340 240GB 2.5','709000','AR','SSD01','1','SSD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4073',N'Lexar NK100 mSATA 128GB','699000','LEX','SSD01','1','SSD',N'')

INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4074',N'Samsung 860 Evo 250GB M.2 2280','1350000','SS','SSD02','1','SSD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4075',N'Apacer M.2 2280 120GB','890000','AR','SSD02','1','SSD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4076',N'LEXAR LNM100 128GB','590000','LEX','SSD02','1','SSD',N'')
---vga------
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4131',N'ASUS TUF Gaming GeForce GTX 1650 4GB','4399000','VAS','VGA02','2','VGA',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4132',N'MSI GTX 1050 Ti 4GT OCV1','4799000','VMSI','VGA02','2','VGA',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4133',N'GIGABYTE GeForce GTX 1660','5999000','VGGB','VGA02','2','VGA',N'')
----odd----
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP4431',N'Asus SDRW-08D2S-U','750000','OAS','ODD01','1','ODD',N'')
--keyboard----
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP5011',N'Corsair K70 RGB MK2','2799000','KCR','KEY01','1','KEYBOARD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP5012',N'Corsair K70 RGB MK2','3399000','KCR','KEY02','1','KEYBOARD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP5013',N'Filco Majestouch 2','3320000','FIL','KEY01','1','KEYBOARD',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP5014',N'Filco Majestouch 2 Ninja','3400000','FIL','KEY02','1','KEYBOARD',N'')
-----mouse---
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP5031',N'Genius DX-125 Đen','100000','GEN','MOUSE01','0','MOUSE',N'')
INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('SP5032',N'Genius NX 7010','200000','GEN','MOUSE02','1','MOUSE',N'')

----Nhap Kho----
INSERT INTO NhapKho([MaPNhap],[MaNV],[NgayNhap],[TongSL],[TongTien]) VALUES ('PN001','NV0001','11/14/2022',0,0)

INSERT INTO SPNhap([STT],[MaLK],[MaPNhap],[GiaNhap],[SLNhap]) VALUES (1,'SP1001','PN001',150000,3)
INSERT INTO SPNhap([STT],[MaLK],[MaPNhap],[GiaNhap],[SLNhap]) VALUES (2,'SP1002','PN001',180000,2)
INSERT INTO SPNhap([STT],[MaLK],[MaPNhap],[GiaNhap],[SLNhap]) VALUES (3,'SP1007','PN001',190000,3)

----Xuatkho------
INSERT INTO XuatKho([MaPXuat],[MaNV],[MaKH],[NgayXuat],[TongSl],[TongTien]) VALUES ('PX001','NV0001','KH0001','11/14/2022',0,0)

INSERT INTO SPXuat([STT],[MaLK],[MaPXuat],[GiaXuat],[SLXuat]) VALUES (1,'SP1001','PX001',150000,3)
INSERT INTO SPXuat([STT],[MaLK],[MaPXuat],[GiaXuat],[SLXuat]) VALUES (2,'SP1002','PX001',180000,1)
INSERT INTO SPXuat([STT],[MaLK],[MaPXuat],[GiaXuat],[SLXuat]) VALUES (3,'SP1007','PX001',190000,2)



