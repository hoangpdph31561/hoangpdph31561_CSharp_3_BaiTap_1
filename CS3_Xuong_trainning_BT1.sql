--TẠO DATABASE
DROP DATABASE QUANLYXEMAY_CS3_XUONG
CREATE DATABASE QUANLYXEMAY_CS3_XUONG
USE QUANLYXEMAY_CS3_XUONG
--TẠO BẢNG LOẠI XE
IF OBJECT_ID ('LoaiXe') IS NOT NULL
DROP TABLE LoaiXe
GO
CREATE TABLE LoaiXe
(
idLoaiXe uniqueidentifier not null,
tenLoaiXe nvarchar(50) null,
constraint pk_LoaiXe primary key (idLoaiXe)
)
--tạo bảng xe máy
IF OBJECT_ID ('XeMay') is not null
DROP TABLE XeMay
GO
CREATE TABLE XeMay
(
idXeMay uniqueidentifier not null,
tenXeMay nvarchar(50) null,
giaNhap int null,
soLuong int null,
moTa nvarchar(100) null,
idLoaiXe uniqueidentifier null,
constraint fk_XeMay_LoaiXe foreign key (idLoaiXe) references LoaiXe(idLoaiXe),
constraint pk_XeMay primary key (idXeMay)
)

SELECT * FROM LoaiXe
INSERT INTO LoaiXe (tenLoaiXe) VALUES
(N'YAMAHA'),
(N'HONDA'),
(N'SUZUKI')
select * from XeMay