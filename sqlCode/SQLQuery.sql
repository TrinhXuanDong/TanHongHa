use master
go
if exists (select * from sysdatabases where name='TanHongHa_db')
	drop database TanHongHa_db
go
create database TanHongHa_db
on primary
(
	name= TanHongHa_dbdat,
	filename='E:\TanHongHa_dbdat.mdf',
	size=10, 
	maxsize=100,
	filegrowth=10
)
log on
(
	name=TanHongHa_dblog,
	filename='E:\TanHongHa_dblog.ldf',
	size=1,
	filegrowth=5
)
go
use TanHongHa_db

CREATE TABLE TaiKhoan (
	ID	INTEGER,
	TaiKhoan	NVARCHAR(50),
	MatKhau	NVARCHAR(50)
);

CREATE TABLE Xe (
	BienSo	NVARCHAR(10) primary key,
	LoaiXe	NVARCHAR(50),
	GhiChu	NVARCHAR(100)
);

CREATE TABLE ThongSoBaoDuong (
	MaThongSoBaoDuong	NVARCHAR(10) primary key,
	MoTa	NVARCHAR(100),
	SoKmCanBaoDuong	INTEGER,
	SaiSoChoPhep	INTEGER
);

CREATE TABLE KmHangNgay (
	Ngay	INTEGER,
	Thang	INTEGER,
	Nam	INTEGER,
	BienSo	NVARCHAR(10),
	TenLaiXe	NVARCHAR(50),
	KmDi	INTEGER,
	KmVe	INTEGER,
	KmDiDuoc	INTEGER,
	KmTua	INTEGER,
	PRIMARY KEY(Ngay,Thang,Nam,BienSo),
	foreign key (BienSo) references Xe(BienSo)
);
CREATE TABLE BaoDuongXe (
	MaBaoDuong	NVARCHAR(10) primary key,
	Ngay	INTEGER,
	Thang	INTEGER,
	Nam	INTEGER,
	BienSo	NVARCHAR(10),
	KmBaoDuong	INTEGER,
	TenXuongMay	NVARCHAR(100),
	TongTien	REAL,
	foreign key (BienSo) references Xe(BienSo)
);

CREATE TABLE ChiTietBaoDuongXe (
	MaChiTiet	NVARCHAR(10),
	MaBaoDuong	NVARCHAR(10),
	MaThongSoBaoDuong	NVARCHAR(10),
	PhatSinhNgoaiLe	NVARCHAR(50),
	DonViTinh	NVARCHAR(10),
	SoLuong	INTEGER,
	DonGia	REAL,
	ThanhTien	REAL,
	NguoiChiuTrachNhiem	NVARCHAR(50),
	PRIMARY KEY(MaChiTiet,MaBaoDuong),
	foreign key (MaBaoDuong) references BaoDuongXe(MaBaoDuong),
	foreign key (MaThongSoBaoDuong) references ThongSoBaoDuong(MaThongSoBaoDuong)
);