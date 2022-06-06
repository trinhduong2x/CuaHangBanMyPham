use master
go
create database QLCHMP
go
use QLCHMP
go

create table DanhMuc
(	
	MaDM char(10) not null,
	TenDM nvarchar(30) not null default N'Trống',
	primary key(MaDM)
)
go

create table NhanVien
(
	MaNV char(10) not null,
	TenNV nvarchar(30) not null default N'Trống',
	Luong int null default N'Trống',
	SDT nvarchar(20) not null default N'Trống',
	DiaChi nvarchar(100) not null default N'Trống',
	primary key (MaNV)
)
go
 
create table NCC
(	
	MaNCC char(10) not null,
	TenNCC nvarchar(20) not null default N'Trống',
	SDT nvarchar(20) not null default N'Trống',
	DiaChi nvarchar(100) not null default N'Trống',
	primary key (MaNCC)
)
go 

create table SanPham
(
	MaSP char(10) not null,
	MaDM char(10) not null ,
	MaNCC char(10) not null,
	TenSP nvarchar(30) not null default N'Trống',
	Gia int not null default N'Trống',
	SLTon int not null default N'Trống',
	Mota ntext null,
	primary key (MaSP)
)
go

create table KhachHang
(
	MaKH char(10) not null,
	TenKH nvarchar(30) not null default N'Trống',
	SDT nvarchar(20) not null default N'Trống',
	DiaChi nvarchar(100) not null default N'Trống',
	primary key (MaKH)
)
go

create table HoaDon
(
	MaHD char(10) not null,
	MaKH char(10) not null,
	MaNV char(10) not null,
	NgayLap datetime not null default N'Trống',
	primary key (MaHD)
)
go

create table ChiTietHD
(
	MaHD char(10) not null,
	MaSP char(10) not null,
	SLBan int not null default N'Trống',
	primary key (MaSP,MaHD)
)
go

alter table SanPham add foreign key(MaDM) references DanhMuc (MaDM) on update no action on delete no action 
go
alter table Sanpham add foreign key(MaNCC) references NCC  (MaNCC) on update no action on delete no action 
go
alter table HoaDon add foreign key(MaKH) references KhachHang  (MaKH) on update no action on delete no action 
go
alter table HoaDon add foreign key(MaNV) references NhanVien  (MaNV) on update no action on delete no action 
go
alter table ChiTietHD add foreign key(MaSP) references SanPham (MaSP) on update no action on delete no action 
go
alter table ChiTietHD add foreign key(MaHD) references HoaDon (MaHD) on update no action on delete no action 
go

--Thêm dữ liệu cho bảng danh mục
insert into DanhMuc(MaDM,TenDM) values ('DM01',N'Trang điểm')
insert into DanhMuc(MaDM,TenDM) values ('DM02',N'Chăm sóc da')
insert into DanhMuc(MaDM,TenDM) values ('DM03',N'Chăm sóc cơ thể')
insert into DanhMuc(MaDM,TenDM) values ('DM04',N'Nước hoa')
insert into DanhMuc(MaDM,TenDM) values ('DM05',N'Chăm sóc tóc')
go
--
select * from DanhMuc

--Thêm dữ liệu vào bảng nhân viên
insert into NhanVien(MaNV,TenNV,SDT, DiaChi,Luong) values ('NV01',N'Hoàng Trịnh Dương','0358147473',N'Thanh Hóa',10000000)
insert into NhanVien(MaNV,TenNV,SDT, DiaChi,Luong) values ('NV02',N'Lê Đức Khải','0325648515',N'Nam Định',9000000)
insert into NhanVien(MaNV,TenNV,SDT, DiaChi,Luong) values ('NV03',N'Đỗ Văn Hiếu','0326594154',N'Tuyên Quang',8000000)
go
--

--Thêm dữ liệu vào bảng nhà cung cấp
insert into NCC(MaNCC,TenNCC,SDT,DiaChi) values('NCC01','W.lab','0888888888',N'Hàn Quốc')
insert into NCC(MaNCC,TenNCC,SDT,DiaChi) values('NCC02','Eveline','021554155',N'Ba Lan')
insert into NCC(MaNCC,TenNCC,SDT,DiaChi) values('NCC03','Treaclemoon','0245812369',N'Anh Quốc')
insert into NCC(MaNCC,TenNCC,SDT,DiaChi) values('NCC04','AquaVera','0125486255',N'Thổ Nhĩ Kỳ')
insert into NCC(MaNCC,TenNCC,SDT,DiaChi) values('NCC05','SO.DI.CO','0568942521',N'Italia')
--

--Thêm dữ liệu vào bẳng Sản phẩm
insert into SanPham(MaSP,MaDM,MaNCC,TenSP,SLTon,Gia,Mota) values('SP01','DM01','NCC01',N'Kem che khuyết điểm',100,345000 ,N' Kết hợp hoàn hảo của kem nền và che khuyết điểm')
insert into SanPham(MaSP,MaDM,MaNCC,TenSP,SLTon,Gia,Mota) values('SP02','DM02','NCC02',N'Gel tẩy da chết',200,275000 ,N'Tích hợp 2 chức năng làm sạch dầu và tẩy tế bào chết trên da')
insert into SanPham(MaSP,MaDM,MaNCC,TenSP,SLTon,Gia,Mota) values('SP03','DM03','NCC03',N'Tẩy da chết toàn thân',250 , 165000,N' Loại bỏ các lớp tế bào chết, bụi bẩn, dầu thừa trên da')
insert into SanPham(MaSP,MaDM,MaNCC,TenSP,SLTon,Gia,Mota) values('SP04','DM04','NCC04',N'Nước hoa nữ AquaVera Exalt', 150,225000,N'Mùi hương nồng nàn, quyến rũ ')
insert into SanPham(MaSP,MaDM,MaNCC,TenSP,SLTon,Gia,Mota) values('SP05','DM05','NCC05',N'Dầu gội và dưỡng tóc trẻ em', 300,125000 ,N'nuôi dưỡng mái tóc luôn suôn mềm, lưu lại hương thơm nhẹ nhàng, lôi cuốn ')
insert into SanPham(MaSP,MaDM,MaNCC,TenSP,SLTon,Gia,Mota) values('SP06','DM01','NCC02',N'Son dưỡng môi',400 ,90000 ,N'bảo vệ và nuôi dưỡng đôi môi tươi tắn cùng hương dừa nhiệt đới ngọt ngào ')
go
--

--Thêm dữ liệu vào bảng Khách hàng
insert into KhachHang(MaKH,TenKH,SDT,DiaChi) values('KH01',N'Lê Thị Thảo','0326598415',N'Hà Nội')
insert into KhachHang(MaKH,TenKH,SDT,DiaChi) values('KH02',N'Nguyễn Trung Anh','0326514589',N'Thanh Hóa')
insert into KhachHang(MaKH,TenKH,SDT,DiaChi) values('KH03',N'Nguyễn Tấn Dũng','03261548585',N'Hà Nam')
go
--

----Thêm dữ liệu vào bảng Hóa đơn
--insert into HoaDon(MaHD,NgayLap,MaKH,MaNV) values('HD01','10-10-2021','KH01','NV01')
--insert into HoaDon(MaHD,NgayLap,MaKH,MaNV) values('HD02','11-11-2021','KH01','NV01')
insert into HoaDon(MaHD,NgayLap,MaKH,MaNV) values('HD03','12-12-2021','KH01','NV01')
--go
----

----Thêm dữ liệu vào bảng chi tiết hóa đơn
--insert into ChiTietHD(MaHD,MaSP,SLBan) values('HD01','SP02',50)
--insert into ChiTietHD(MaHD,MaSP,SLBan) values('HD02','SP02',150)
insert into ChiTietHD(MaHD,MaSP,SLBan) values('HD03','SP03',200)
--go
----

select * from DanhMuc
select * from NhanVien
select * from NCC
select * from SanPham
select * from KhachHang
select * from HoaDon
select * from ChiTietHD

delete from ChiTietHD where MaSP = 'SP01'
delete from ChiTietHD
delete from HoaDon

--Trigger kiểm soát số lượng bán
go
create trigger trginsertChiTietHD
on ChiTietHD
for insert
as
begin
		declare @MaSP char(10)
		set @MaSP = (select MaSP from inserted)
		if(not exists(select * from SanPham where MaSP=@MaSP))
				begin
					raiserror(N'Lỗi không có sản phẩm',16,1)
					rollback transaction
				end
		else
			begin
			declare @SLTon int
			declare @SLBan int
			select @SLTon = SLTon from SanPham inner join inserted on SanPham.MaSP = inserted.MaSP
			select @SLBan = inserted.SLBan from inserted
			if(@SLTon<@SLBan)
				begin
					raiserror(N'Bạn không đủ hàng',16,1)
					rollback transaction
				end
			else
				update SanPham set SLTon = SLTon - @SLBan
				from SanPham inner join inserted on SanPham.MaSP = inserted.MaSP
			end
end
go


create table TaiKhoan
(
	ID int identity(1,1) primary key,
	MaNV char(10),
	UserName nvarchar(30),
	PassWord nvarchar(30),
	Role bit
)
go
alter table TaiKhoan add foreign key(MaNV) references NhanVien (MaNV) on update no action on delete no action 
go
insert into TaiKhoan(MaNV,UserName, PassWord,Role) values('NV01','admin','1234','true')
insert into TaiKhoan(MaNV,UserName, PassWord,Role) values('NV02','staff','1234','false')
go
select *from TaiKhoan

