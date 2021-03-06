USE [master]
GO
/****** Object:  Database [QLVT_test]    Script Date: 05/16/2020 23:11:49 ******/
CREATE DATABASE [QLVT_test] ON  PRIMARY 
( NAME = N'QLVT_test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLVT_test.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLVT_test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLVT_test_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLVT_test] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLVT_test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLVT_test] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLVT_test] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLVT_test] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLVT_test] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLVT_test] SET ARITHABORT OFF
GO
ALTER DATABASE [QLVT_test] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLVT_test] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLVT_test] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLVT_test] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLVT_test] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLVT_test] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLVT_test] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLVT_test] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLVT_test] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLVT_test] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLVT_test] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLVT_test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLVT_test] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLVT_test] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLVT_test] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLVT_test] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLVT_test] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLVT_test] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLVT_test] SET  READ_WRITE
GO
ALTER DATABASE [QLVT_test] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLVT_test] SET  MULTI_USER
GO
ALTER DATABASE [QLVT_test] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLVT_test] SET DB_CHAINING OFF
GO
USE [QLVT_test]
GO
/****** Object:  Table [dbo].[DEVICES_TBL]    Script Date: 05/16/2020 23:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEVICES_TBL](
	[SERIAL] [nchar](50) NOT NULL,
	[HOSTNAME] [nchar](20) NULL,
	[BRAND] [nchar](10) NOT NULL,
	[MODEL] [nchar](100) NOT NULL,
	[INVOICE_DATE] [date] NULL,
	[HANDOVER_DATE] [date] NULL,
	[WARANTY] [nchar](10) NULL,
	[SUPPLIES] [nchar](20) NULL,
	[REMARK] [nvarchar](150) NULL,
	[ASSET_CODE] [nchar](20) NULL,
	[MEMORY] [nchar](5) NULL,
	[HDD] [nchar](5) NULL,
	[MAC_ADDR] [nchar](17) NULL,
	[IP_ADDR] [nchar](15) NULL,
	[DNS] [nchar](15) NULL,
	[DEFAULT_GW] [nchar](15) NULL,
	[PASSWRD] [nchar](20) NULL,
	[LOG_NAME] [nchar](20) NULL,
	[DTYPE] [nchar](20) NULL,
	[DSTATUS] [nchar](5) NULL,
	[DAREA] [nchar](3) NULL,
	[USRNAME] [nchar](50) NULL,
	[LOCATION] [nchar](30) NULL,
	[POSITION] [nchar](30) NULL,
	[BARCODE] [nchar](12) NULL,
 CONSTRAINT [PK__DEVICES___1CE6D4E6173876EA] PRIMARY KEY CLUSTERED 
(
	[SERIAL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NETWORK_TBL]    Script Date: 05/16/2020 23:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NETWORK_TBL](
	[NetCode] [nchar](5) NOT NULL,
	[Networks] [nchar](5) NULL,
	[IP_WAN] [nchar](15) NULL,
	[WAN_Provider] [nchar](20) NULL,
	[WAN_BandWidth] [nchar](20) NULL,
	[Firewall_Port] [nchar](25) NULL,
	[WAN_Port] [nchar](25) NULL,
	[Synology_Port] [nchar](25) NULL,
	[PPOE_UsrName] [nchar](50) NULL,
	[PPOE_Password] [nchar](50) NULL,
	[WAN_Note] [nchar](150) NULL,
	[LAN_Interface] [nchar](20) NULL,
	[LAN_Type] [nchar](20) NULL,
	[LAN_Port] [nchar](25) NULL,
	[LAN_IP_Netmask] [nchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN_TBL]    Script Date: 05/16/2020 23:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_TBL](
	[manhanvien] [nchar](10) NOT NULL,
	[tennhanvien] [nvarchar](50) NOT NULL,
	[tendangnhap] [nchar](15) NOT NULL,
	[matkhau] [nchar](50) NULL,
	[phongban] [nvarchar](50) NULL,
	[permission] [nvarchar](150) NULL,
 CONSTRAINT [PK__nhanvien__75A28B525AEE82B9] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVER_TBL]    Script Date: 05/16/2020 23:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVER_TBL](
	[SERIAL] [nchar](50) NOT NULL,
	[BRAND] [nchar](10) NULL,
	[MODEL] [nchar](100) NULL,
	[INVOICE_DATE] [date] NULL,
	[HANDOVER_DATE] [date] NULL,
	[SUPPLIER] [nchar](20) NULL,
	[WARRANTY] [nchar](10) NULL,
	[REMARKS] [nchar](150) NULL,
	[DAREA] [nchar](3) NULL,
	[DTYPE] [nchar](20) NULL,
	[DSTATUS] [nchar](5) NULL,
	[LOCATION] [nchar](30) NULL,
	[CPU] [nchar](100) NULL,
	[RAM] [nchar](100) NULL,
	[POWER_SUPPLY] [nchar](100) NULL,
	[STORAGE] [nchar](150) NULL,
	[RAID_CONTROLLER] [nchar](150) NULL,
	[GRAPHIC] [nchar](150) NULL,
	[ETHERNET] [nchar](150) NULL,
	[OPTICAL_DRIVE] [nchar](150) NULL,
	[HOSTNAME] [nchar](20) NULL,
	[ASSET_CODE] [nchar](20) NULL,
 CONSTRAINT [PK_SERVER_TBL] PRIMARY KEY CLUSTERED 
(
	[SERIAL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SERVER_update]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SERVER_update]
@darea nchar(3),
@dtype nchar(20),
@brand nchar(10),
@model nchar(100),
@serial nchar(50),
@invoice_date date,
@handover_date date,
@warranty nchar(10),
@supplies nchar(20),
@remarks nvarchar(150),
@location nchar(30),
@dstatus nchar(5),
@cpu nchar(100),
@ram char(100),
@power_supply nchar(100),
@storage nchar(150),
@raid_controller nchar(150),
@graphic nchar(150),
@ethernet nchar(150),
@optical_drive nchar(150),
@hostname nchar(20),
@assetcode nchar(20),
@message nvarchar(50) output
as
BEGIN
	UPDATE SERVER_TBL 
	set 
DAREA = @darea,
DTYPE = @dtype,
BRAND = @brand,
MODEL = @model,
INVOICE_DATE = @invoice_date ,
HANDOVER_DATE = @handover_date,
WARRANTY = @warranty,
SUPPLIER = @supplies,
REMARKS = @remarks,
LOCATION = @location,
DSTATUS = @dstatus,
CPU = @cpu,
RAM = @ram,
POWER_SUPPLY = @power_supply,
server_tbl.STORAGE = @storage,
server_tbl.RAID_CONTROLLER = @raid_controller,
server_tbl.GRAPHIC = @graphic,
server_tbl.ETHERNET = @ethernet,
server_tbl.OPTICAL_DRIVE = @optical_drive,
server_tbl.HOSTNAME = @hostname,
server_tbl.ASSET_CODE = @assetcode
	
	where  SERIAL   =	@serial
	
	set @message = N'Cập nhật thành công'
END
GO
/****** Object:  StoredProcedure [dbo].[SERVER_Select_Area]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SERVER_Select_Area]
@darea nchar(3)
as
begin
select * from SERVER_TBL where DAREA = @darea
end
GO
/****** Object:  StoredProcedure [dbo].[SERVER_Insert]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SERVER_Insert]
@darea nchar(3),
@dtype nchar(20),
@brand nchar(10),
@model nchar(100),
@serial nchar(50),
@invoice_date date,
@handover_date date,
@warranty nchar(10),
@supplies nchar(20),
@remarks nvarchar(150),
@location nchar(30),
@dstatus nchar(5),
@cpu nchar(100),
@ram char(100),
@power_supply nchar(100),
@storage nchar(150),
@raid_controller nchar(150),
@graphic nchar(150),
@ethernet nchar(150),
@optical_drive nchar(150),
@hostname nchar(20),
@assetcode nchar(20),
@message nvarchar(50) output
as
BEGIN
if not exists(select SERIAL From SERVER_TBL where SERIAL = @serial)
begin
	INSERT INTO SERVER_TBL (SERIAL, BRAND, MODEL, INVOICE_DATE, HANDOVER_DATE,
							SUPPLIER, WARRANTY, REMARKS, DAREA, DTYPE, DSTATUS, LOCATION, CPU, RAM,
							POWER_SUPPLY, STORAGE, RAID_CONTROLLER, GRAPHIC, ETHERNET, OPTICAL_DRIVE, HOSTNAME,ASSET_CODE)
	VALUES (@serial,@brand, @model, @invoice_date, @handover_date,
			@supplies, @warranty, @remarks, @darea, @dtype, @dstatus, @location, @cpu, @ram,
			@power_supply, @storage, @raid_controller, @graphic, @ethernet, @optical_drive, @hostname,@assetcode)
	set @message = N'Đã nhập thành công'
end

else

begin
	set @message = N'Đã tồn tại Serial '
end

END
GO
/****** Object:  StoredProcedure [dbo].[SERVER_Delete]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SERVER_Delete]
@serial nchar(50)
as
BEGIN
	delete from SERVER_TBL where SERIAL = @serial
END
GO
/****** Object:  StoredProcedure [dbo].[SERVER_CB_Select_Warranty]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SERVER_CB_Select_Warranty]
as
begin
select distinct WARRANTY from SERVER_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[SERVER_CB_Select_Supplier]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SERVER_CB_Select_Supplier]
as
begin
select distinct SUPPLIER from SERVER_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[SERVER_CB_Select_Status]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SERVER_CB_Select_Status]
as
begin
select distinct DSTATUS from SERVER_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[SERVER_CB_Select_Dtype_By_Area]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SERVER_CB_Select_Dtype_By_Area]
@DAREA nchar(3)
as
begin
select distinct DTYPE from SERVER_TBL
where DAREA = @DAREA
end
GO
/****** Object:  StoredProcedure [dbo].[SERVER_CB_Select_Brand]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SERVER_CB_Select_Brand]
as
begin
select distinct BRAND from SERVER_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_SelectAll]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHANVIEN_SelectAll]
as
begin
	Select * from NHANVIEN_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Search]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHANVIEN_Search]
@manhanvien nchar(10)
as
begin
if exists(select manhanvien From NHANVIEN_TBL where manhanvien = @manhanvien)
begin
select * from NHANVIEN_TBL
where manhanvien = @manhanvien
end
end
GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_ResetPassword]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHANVIEN_ResetPassword]
@matkhau nchar(50),
@manhanvien nchar(10),
@message nvarchar(50) output
as
begin
update NHANVIEN_TBL
set matkhau = @matkhau
where manhanvien = @manhanvien
set @message = N'Reset Password Successful'
end
GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Login]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHANVIEN_Login]
@tendangnhap nvarchar(15),
@matkhau nvarchar(50),
@kiemtra bit output
as
begin
declare @kt int

select @kt = count(tendangnhap)
	 from NHANVIEN_TBL
	 where tendangnhap = @tendangnhap
	 and matkhau = @matkhau
	 if(@kt != 0)
	 select @kiemtra = 'true' 
	 else
	 select @kiemtra = 'false'
end
GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Delete]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NHANVIEN_Delete]
@manhanvien nchar(10),
@message nvarchar(50) output
as
begin
if exists(select manhanvien From NHANVIEN_TBL where manhanvien = @manhanvien)
begin
delete from NHANVIEN_TBL
where manhanvien = @manhanvien
set @message = N'Xóa thành công'
end
end
GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Change]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHANVIEN_Change]
@manhanvien nchar(10),
@tennhanvien nvarchar(50),
@tendangnhap nchar(15),
@matkhau nchar(50),
@phongban nvarchar(50),
@permission nvarchar(150),
@message nvarchar(50) output
as
begin
if exists(select manhanvien From NHANVIEN_TBL where manhanvien = @manhanvien)
begin
update NHANVIEN_TBL
set tendangnhap = @tendangnhap,
tennhanvien = @tennhanvien,
matkhau = @matkhau,
phongban = @phongban,
permission = @permission
where manhanvien = @manhanvien
set @message = N'Thay đổi thành công'
end
else
begin
set @message = N'Chưa có User có Mã Nhân Viên'
end
end
GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Add]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NHANVIEN_Add]
@manhanvien nchar(10),
@tennhanvien nvarchar(50),
@tendangnhap nchar(15),
@matkhau nchar(50),
@phongban nvarchar(50),
@permission nvarchar(150),
@message nvarchar(50) output
as
begin
if not exists(select manhanvien From NHANVIEN_TBL where manhanvien = @manhanvien)
begin
insert into NHANVIEN_TBL(manhanvien,tennhanvien,tendangnhap,matkhau,phongban,permission) 
values (@manhanvien,@tennhanvien,@tendangnhap,@matkhau,@phongban,@permission)
set @message = N'Đã nhập thành công'
end
else
begin
set @message = N'Đã tồn tại User'
end
end
GO
/****** Object:  StoredProcedure [dbo].[NETWORK_SelectAll]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NETWORK_SelectAll]
as
begin
select * from NETWORK_TBL 
end
GO
/****** Object:  StoredProcedure [dbo].[NETWORK_Insert]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NETWORK_Insert]
@netcode nchar(5),
@networks nchar(5),
@ip_wan nchar(15),
@wan_provider nchar(20),
@wan_bandwidth nchar(20),
@firewall_port nchar(25),
@wan_port nchar(25),
@synology_port nchar(25),
@ppoe_usrname nchar(50),
@ppoe_password nchar(50),
@wan_note nchar(150),
@lan_interface nchar(20),
@lan_type nchar(20),
@lan_port nchar(25),
@lan_ip_netmask nchar(20)
as
begin
if not exists(select NetCode From NETWORK_TBL where NetCode = @netcode)
begin
insert into NETWORK_TBL (NetCode, Networks, IP_WAN, WAN_Provider,WAN_BandWidth,Firewall_Port,WAN_Port,Synology_Port, PPOE_UsrName,
PPOE_Password, WAN_Note, LAN_Interface, LAN_type, LAN_port, LAN_IP_Netmask) values (@netcode,@networks,@ip_wan,@wan_provider,@wan_bandwidth,@firewall_port,
@wan_port,@synology_port,@ppoe_usrname,@ppoe_password,@wan_note,@lan_interface,@lan_type,@lan_port,@lan_ip_netmask)
end
end
GO
/****** Object:  StoredProcedure [dbo].[NETWORK_Delete]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NETWORK_Delete]
@netcode nchar(5)
as
begin
if exists(select NetCode From NETWORK_TBL where NetCode = @netcode)
begin
delete from NETWORK_TBL 
     where NetCode = @netcode 
      
end
end
GO
/****** Object:  StoredProcedure [dbo].[NETWORK_Change]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NETWORK_Change]
@netcode nchar(5),
@networks nchar(5),
@ip_wan nchar(15),
@wan_provider nchar(20),
@wan_bandwidth nchar(20),
@firewall_port nchar(25),
@wan_port nchar(25),
@synology_port nchar(25),
@ppoe_usrname nchar(50),
@ppoe_password nchar(50),
@wan_note nchar(150),
@lan_interface nchar(20),
@lan_type nchar(20),
@lan_port nchar(25),
@lan_ip_netmask nchar(20)
as
begin
if exists(select NetCode From NETWORK_TBL where NetCode = @netcode)
begin
update NETWORK_TBL 

set  Networks = @networks,
 IP_WAN = @ip_wan,
  WAN_Provider = @wan_provider,
  WAN_BandWidth = @wan_bandwidth,
  Firewall_Port = @firewall_port,
  WAN_Port = @wan_port,
  Synology_Port = @synology_port,
   PPOE_UsrName = @ppoe_usrname,
PPOE_Password = @ppoe_password,
 WAN_Note = @wan_note,
  LAN_Interface = @lan_interface,
   LAN_type = @lan_type,
    LAN_port = @lan_port,
     LAN_IP_Netmask = @lan_ip_netmask
     
     where NetCode =@netcode 
      
end
end
GO
/****** Object:  StoredProcedure [dbo].[GenerateBarcode4Dev_TBL]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GenerateBarcode4Dev_TBL]
as
begin
create TABLE #temptbl (
    bcode nchar(12),
    serial nchar(50)
);
insert into #temptbl(bcode,serial) select bcode,SERIAL from(select ROW_NUMBER() OVER (PARTITION BY dtype ORDER BY DTYPE)bcode,SERIAL 
FROM dbo.DEVICES_TBL)bcode
select * from #temptbl

update DEVICES_TBL set BARCODE = #temptbl.bcode
from DEVICES_TBL
join #temptbl
on DEVICES_TBL.SERIAL = #temptbl.serial

update DEVICES_TBL set BARCODE = RTRIM(DTYPE) + BARCODE
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_Update]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_Update]
@serial nchar(50),
@hostname nchar(20),
@brand nchar(10),
@model nchar(100),
@invoice_date date,
@handover_date date,
@warranty nchar(10),
@supplies nchar(20),
@remark nvarchar(150),
@assetcode nchar(20),
@memory nchar(5),
@hdd nchar(5),
@mac_addr nchar(17),
@ip_addr nchar(15),
@dns nchar(15),
@default_gw nchar(15),
@passwrd nchar(20),
@log_name nchar(20),
@dtype nchar(20),
@dstatus nchar(5),
@darea nchar(3),
@usrname nchar(50),
@location nchar(30),
@position nchar(30)
as
BEGIN
	UPDATE DEVICES_TBL 
	set HOSTNAME    =   @hostname,
	BRAND			=	@brand,
	MODEL			=	@model,
	INVOICE_DATE	=	@invoice_date,
	HANDOVER_DATE	=	@handover_date,
	WARANTY			=	@warranty,
	SUPPLIES		=	@supplies,
	REMARK			=	@remark,
	ASSET_CODE		=	@assetcode,
	MEMORY			=	@memory,
	HDD				=	@hdd,
	MAC_ADDR		=	@mac_addr,
	IP_ADDR			=	@ip_addr,
	DNS				=	@dns,
	DEFAULT_GW		=	@default_gw,
	PASSWRD			=	@passwrd,
	LOG_NAME		=	@log_name,
	DTYPE			=	@dtype,
	DSTATUS			=	@dstatus,
	DAREA			=	@darea,
	USRNAME			=	@usrname,
	LOCATION		=	@location,
	POSITION		=	@position
	
	where  SERIAL   =	@serial
END
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_SelectAll]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_SelectAll]
as
begin
	Select SERIAL,HOSTNAME,BRAND,MODEL,INVOICE_DATE,HANDOVER_DATE,
						WARANTY,SUPPLIES,REMARK,ASSET_CODE,MEMORY,HDD,
						MAC_ADDR,IP_ADDR,DNS,DEFAULT_GW,PASSWRD,LOG_NAME,DTYPE,DSTATUS from DEVICES_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_Insert_Form]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_Insert_Form]
@serial nchar(50),
@brand nchar(10),
@model nchar(100),
@invoice_date date,
@handover_date date,
@warranty nchar(10),
@supplies nchar(20),
@remark nvarchar(150),
@mac_addr nchar(17),
@dtype nchar(20),
@dstatus nchar(5),
@darea nchar(3),
@message nvarchar(50) output
as
BEGIN
if not exists(select SERIAL From DEVICES_TBL where SERIAL = @serial)
begin
	INSERT INTO DEVICES_TBL (SERIAL,BRAND,MODEL,INVOICE_DATE,HANDOVER_DATE,
						WARANTY,SUPPLIES,REMARK,MAC_ADDR,
						DTYPE,DSTATUS,DAREA)
	VALUES (@Serial,@brand,@model,@invoice_date,@handover_date,@warranty,
			@supplies,@remark,@mac_addr,@dtype,@dstatus,@darea)
			
	set @message = N'Đã nhập thành công'
end
else
begin
	set @message = N'Đã tồn tại Serial '
end

END
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_Insert]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_Insert]
@serial nchar(50),
@hostname nchar(20),
@brand nchar(10),
@model nchar(100),
@invoice_date date,
@handover_date date,
@warranty nchar(10),
@supplies nchar(20),
@remark nvarchar(150),
@assetcode nchar(20),
@memory nchar(5),
@hdd nchar(5),
@mac_addr nchar(17),
@ip_addr nchar(15),
@dns nchar(15),
@default_gw nchar(15),
@passwrd nchar(20),
@log_name nchar(20),
@dtype nchar(20),
@dstatus nchar(5),
@darea nchar(3),
@usrname nchar(50),
@location nchar(30),
@position nchar(30)
as
BEGIN
if not exists(select SERIAL From DEVICES_TBL where SERIAL = @serial)
begin
	declare @vcount int
	set @vcount = (select COUNT(SERIAL) from DEVICES_TBL where DTYPE = 'SW')+1
	declare @barcode nchar(12)
	set @barcode = (select RTRIM(@dtype)) + @vcount

	INSERT INTO DEVICES_TBL (SERIAL,HOSTNAME,BRAND,MODEL,INVOICE_DATE,HANDOVER_DATE,
						WARANTY,SUPPLIES,REMARK,ASSET_CODE,MEMORY,HDD,MAC_ADDR,
						IP_ADDR,DNS,DEFAULT_GW,PASSWRD,LOG_NAME,DTYPE,DSTATUS,DAREA,USRNAME,LOCATION,POSITION,BARCODE)
	VALUES (@Serial,@hostname,@brand,@model,@invoice_date,@handover_date,@warranty,
			@supplies,@remark,@assetcode,@memory,@hdd,@mac_addr,@ip_addr,@dns,@default_gw,
			@passwrd,@log_name,@dtype,@dstatus,@darea,@usrname,@location,@position,@barcode)
end
END
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_Delete]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DEVICES_Delete]
@serial nchar(50)
as
begin
	delete from DEVICES_TBL where SERIAL = @serial
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_Change]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_Change]
@serial nchar(50),
@ChangValue nchar(13),
@Updated_Cell nchar(150)
--@hostname nchar(20),
--@brand nchar(10),
--@model nchar(100),
--@invoice_date date,
--@handover_date date,
--@warranty nchar(10),
--@supplies nchar(20),
--@remark nvarchar(150),
--@assetcode nchar(20),
--@memory nchar(5),
--@hdd nchar(5),
--@mac_addr nchar(17),
--@ip_addr nchar(15),
--@dns nchar(15),
--@default_gw nchar(15),
--@passwrd nchar(20),
--@log_name nchar(20),
--@dtype nchar(20),
--@dstatus nchar(5),
--@darea nchar(3),
--@usrname nchar(50),
--@location nchar(30),
--@position nchar(30)
as
BEGIN
	UPDATE DEVICES_TBL 
	set @ChangValue = @Updated_Cell
	--HOSTNAME    =   @hostname,
	--BRAND			=	@brand,
	--MODEL			=	@model,
	--INVOICE_DATE	=	@invoice_date,
	--HANDOVER_DATE	=	@handover_date,
	--WARANTY			=	@warranty,
	--SUPPLIES		=	@supplies,
	--REMARK			=	@remark,
	--ASSET_CODE		=	@assetcode,
	--MEMORY			=	@memory,
	--HDD				=	@hdd,
	--MAC_ADDR		=	@mac_addr,
	--IP_ADDR			=	@ip_addr,
	--DNS				=	@dns,
	--DEFAULT_GW		=	@default_gw,
	--PASSWRD			=	@passwrd,
	--LOG_NAME		=	@log_name,
	--DTYPE			=	@dtype,
	--DSTATUS			=	@dstatus,
	--DAREA			=	@darea,
	--USRNAME			=	@usrname,
	--LOCATION		=	@location,
	--POSITION		=	@position
	
	where  SERIAL   =	@Serial
END
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_CB_Select_Supplier]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_CB_Select_Supplier]
as
begin
select distinct SUPPLIES from DEVICES_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_CB_Select_Status]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[DEVICES_CB_Select_Status]
as
begin
select distinct DSTATUS from DEVICES_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_CB_Select_Position]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_CB_Select_Position]
as
begin
select distinct POSITION from DEVICES_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_CB_Select_Dtype_By_Area]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_CB_Select_Dtype_By_Area]
@DAREA nchar(3)
as
begin
select distinct DTYPE from DEVICES_TBL
where DAREA = @DAREA
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_CB_Select_Dtype]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_CB_Select_Dtype]
as
begin
select distinct DTYPE from DEVICES_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_CB_Select_DArea]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_CB_Select_DArea]
as
begin
select distinct DAREA from DEVICES_TBL
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_CB_Select_Brand_By_Dtype]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DEVICES_CB_Select_Brand_By_Dtype]
@DTYPE nchar(20)
as
begin
select distinct BRAND from DEVICES_TBL
where DTYPE = @DTYPE
end
GO
/****** Object:  StoredProcedure [dbo].[DEVICES_CB_Select_Brand]    Script Date: 05/16/2020 23:11:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DEVICES_CB_Select_Brand]
as
begin
select distinct BRAND from DEVICES_TBL
end
GO
