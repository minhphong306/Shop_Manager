USE [master]
GO
/****** Object:  Database [banquanao]    Script Date: 27-May-17 10:56:16 AM ******/
CREATE DATABASE [banquanao]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'banquanao', FILENAME = N'E:\SQL--re\MSSQL11.MSSQLSERVER\MSSQL\DATA\banquanao.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'banquanao_log', FILENAME = N'E:\SQL--re\MSSQL11.MSSQLSERVER\MSSQL\DATA\banquanao_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [banquanao] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [banquanao].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [banquanao] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [banquanao] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [banquanao] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [banquanao] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [banquanao] SET ARITHABORT OFF 
GO
ALTER DATABASE [banquanao] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [banquanao] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [banquanao] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [banquanao] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [banquanao] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [banquanao] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [banquanao] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [banquanao] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [banquanao] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [banquanao] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [banquanao] SET  DISABLE_BROKER 
GO
ALTER DATABASE [banquanao] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [banquanao] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [banquanao] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [banquanao] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [banquanao] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [banquanao] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [banquanao] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [banquanao] SET RECOVERY FULL 
GO
ALTER DATABASE [banquanao] SET  MULTI_USER 
GO
ALTER DATABASE [banquanao] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [banquanao] SET DB_CHAINING OFF 
GO
ALTER DATABASE [banquanao] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [banquanao] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'banquanao', N'ON'
GO
USE [banquanao]
GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MABOPHAN] [bigint] IDENTITY(1,1) NOT NULL,
	[TENBOPHAN] [nvarchar](100) NULL,
	[DAXOA] [bit] NOT NULL,
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[MABOPHAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETHOADONNHAP]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADONNHAP](
	[MAHOADON] [bigint] NOT NULL,
	[MASANPHAM] [bigint] NULL,
	[DONGIA] [bigint] NULL,
	[SOLUONG] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETHOADONXUAT]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADONXUAT](
	[MAHOADON] [bigint] NULL,
	[MASANPHAM] [bigint] NULL,
	[DONGIA] [bigint] NULL,
	[SOLUONG] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANHMUC]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUC](
	[MADANHMUC] [bigint] IDENTITY(1,1) NOT NULL,
	[TENDANHMUC] [nvarchar](100) NULL,
	[DAXOA] [bit] NOT NULL,
 CONSTRAINT [PK_DANHMUC] PRIMARY KEY CLUSTERED 
(
	[MADANHMUC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADONNHAP]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONNHAP](
	[MAHOADON] [bigint] IDENTITY(1,1) NOT NULL,
	[MANHANVIEN] [bigint] NULL,
	[MANHACUNGCAP] [bigint] NULL,
	[NGAYNHAP] [nchar](10) NULL,
	[DAXOA] [bit] NOT NULL,
 CONSTRAINT [PK_HOADONNHAP] PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADONXUAT]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONXUAT](
	[MAHOADON] [bigint] IDENTITY(1,1) NOT NULL,
	[MANHANVIEN] [bigint] NULL,
	[MAKHACHHANG] [bigint] NULL,
	[NGAYNHAP] [date] NULL,
	[DAXOA] [bit] NOT NULL,
 CONSTRAINT [PK_HOADONXUAT] PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKHACHHANG] [bigint] IDENTITY(1,1) NOT NULL,
	[TENKHACHHANG] [nvarchar](100) NULL,
	[EMAIL] [varchar](100) NULL,
	[SODIENTHOAI] [varchar](20) NULL,
	[NGAYSINH] [varchar](50) NOT NULL,
	[DIACHI] [nvarchar](200) NULL,
	[DAXOA] [bit] NOT NULL,
	[GIOITINH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MAKHACHHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANHACUNGCAP] [bigint] IDENTITY(1,1) NOT NULL,
	[TENNHACUNGCAP] [nvarchar](100) NULL,
	[DAXOA] [bit] NOT NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MANHACUNGCAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANHANVIEN] [bigint] IDENTITY(1,1) NOT NULL,
	[TENNHANVIEN] [nvarchar](100) NOT NULL,
	[SODIENTHOAI] [varchar](20) NULL,
	[EMAIL] [varchar](100) NULL,
	[DIACHI] [nvarchar](200) NULL,
	[MABOPHAN] [bigint] NULL,
	[TRANGTHAI] [int] NOT NULL,
	[TENTAIKHOAN] [varchar](100) NOT NULL,
	[MATKHAU] [varchar](100) NOT NULL,
	[DAXOA] [bit] NOT NULL,
	[GIOITINH] [nvarchar](50) NULL,
	[NGAYSINH] [varchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASANPHAM] [bigint] IDENTITY(1,1) NOT NULL,
	[MADANHMUC] [bigint] NOT NULL,
	[TENSANPHAM] [nvarchar](100) NOT NULL,
	[DONGIANHAP] [bigint] NULL,
	[DONGIAXUAT] [bigint] NOT NULL,
	[SOLUONGTON] [int] NOT NULL,
	[HINHANH] [varchar](200) NULL,
	[MOTA] [nvarchar](200) NULL,
	[MATHUONGHIEU] [bigint] NOT NULL,
	[DAXOA] [bit] NOT NULL,
	[LOAISANPHAM] [nvarchar](50) NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MASANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THUONGHIEU]    Script Date: 27-May-17 10:56:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUONGHIEU](
	[MATHUONGHIEU] [bigint] IDENTITY(1,1) NOT NULL,
	[TENTHUONGHIEU] [nvarchar](200) NULL,
	[DAXOA] [bit] NOT NULL,
 CONSTRAINT [PK_THUONGHIEU] PRIMARY KEY CLUSTERED 
(
	[MATHUONGHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BOPHAN] ON 

INSERT [dbo].[BOPHAN] ([MABOPHAN], [TENBOPHAN], [DAXOA]) VALUES (1, N'Quản lý', 0)
INSERT [dbo].[BOPHAN] ([MABOPHAN], [TENBOPHAN], [DAXOA]) VALUES (2, N'Nhân viên bán hàng', 0)
SET IDENTITY_INSERT [dbo].[BOPHAN] OFF
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (5, 4, 140000, 2)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (5, 4, 140000, 2)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (5, 7, 1000, 4)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (5, 7, 1000, 4)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (6, 2, 200000, 2)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (6, 2, 200000, 2)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (6, 2, 200000, 2)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (7, 4, 140000, 3)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (7, 4, 140000, 3)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (8, 7, 1000, 3)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (8, 7, 1000, 3)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (8, 7, 1000, 3)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (8, 8, 3000000, 3)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (8, 8, 3000000, 3)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (8, 8, 3000000, 3)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (6, 3, 100000, 2)
INSERT [dbo].[CHITIETHOADONXUAT] ([MAHOADON], [MASANPHAM], [DONGIA], [SOLUONG]) VALUES (6, 3, 100000, 2)
SET IDENTITY_INSERT [dbo].[DANHMUC] ON 

INSERT [dbo].[DANHMUC] ([MADANHMUC], [TENDANHMUC], [DAXOA]) VALUES (1, N'Áo', 0)
INSERT [dbo].[DANHMUC] ([MADANHMUC], [TENDANHMUC], [DAXOA]) VALUES (2, N'Quần', 0)
INSERT [dbo].[DANHMUC] ([MADANHMUC], [TENDANHMUC], [DAXOA]) VALUES (3, N'Giầy', 0)
INSERT [dbo].[DANHMUC] ([MADANHMUC], [TENDANHMUC], [DAXOA]) VALUES (4, N'Mũ', 0)
INSERT [dbo].[DANHMUC] ([MADANHMUC], [TENDANHMUC], [DAXOA]) VALUES (5, N'Ao 2', 1)
INSERT [dbo].[DANHMUC] ([MADANHMUC], [TENDANHMUC], [DAXOA]) VALUES (6, N'Khăn len', 1)
SET IDENTITY_INSERT [dbo].[DANHMUC] OFF
SET IDENTITY_INSERT [dbo].[HOADONXUAT] ON 

INSERT [dbo].[HOADONXUAT] ([MAHOADON], [MANHANVIEN], [MAKHACHHANG], [NGAYNHAP], [DAXOA]) VALUES (1, 3, 1, CAST(0xDB3C0B00 AS Date), 0)
INSERT [dbo].[HOADONXUAT] ([MAHOADON], [MANHANVIEN], [MAKHACHHANG], [NGAYNHAP], [DAXOA]) VALUES (2, 1, 1, CAST(0x2C1C0B00 AS Date), 0)
INSERT [dbo].[HOADONXUAT] ([MAHOADON], [MANHANVIEN], [MAKHACHHANG], [NGAYNHAP], [DAXOA]) VALUES (3, 1, 1, CAST(0x2C1C0B00 AS Date), 0)
INSERT [dbo].[HOADONXUAT] ([MAHOADON], [MANHANVIEN], [MAKHACHHANG], [NGAYNHAP], [DAXOA]) VALUES (4, 3, 1, CAST(0xDB3C0B00 AS Date), 0)
INSERT [dbo].[HOADONXUAT] ([MAHOADON], [MANHANVIEN], [MAKHACHHANG], [NGAYNHAP], [DAXOA]) VALUES (5, 3, 1, CAST(0xDB3C0B00 AS Date), 0)
INSERT [dbo].[HOADONXUAT] ([MAHOADON], [MANHANVIEN], [MAKHACHHANG], [NGAYNHAP], [DAXOA]) VALUES (6, 3, 1, CAST(0xDB3C0B00 AS Date), 0)
INSERT [dbo].[HOADONXUAT] ([MAHOADON], [MANHANVIEN], [MAKHACHHANG], [NGAYNHAP], [DAXOA]) VALUES (7, 3, 3, CAST(0xDB3C0B00 AS Date), 0)
INSERT [dbo].[HOADONXUAT] ([MAHOADON], [MANHANVIEN], [MAKHACHHANG], [NGAYNHAP], [DAXOA]) VALUES (8, 3, 1, CAST(0xDB3C0B00 AS Date), 0)
SET IDENTITY_INSERT [dbo].[HOADONXUAT] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MAKHACHHANG], [TENKHACHHANG], [EMAIL], [SODIENTHOAI], [NGAYSINH], [DIACHI], [DAXOA], [GIOITINH]) VALUES (1, N'Nguyễn Văn An 1', N'nguyenan@gmail.com', N'01696245678', N'20/02/1986', N'Dương Quảng Hàm - Cầu Giấy - Hà Nội', 0, N'NAM')
INSERT [dbo].[KHACHHANG] ([MAKHACHHANG], [TENKHACHHANG], [EMAIL], [SODIENTHOAI], [NGAYSINH], [DIACHI], [DAXOA], [GIOITINH]) VALUES (2, N'Trần Thị Bình', N'tranbinh@hotmail.com', N'0156784256', N'22/02/1986', N'Kim Đồng - Giáp Bát - Hà Nội', 1, N'NỮ')
INSERT [dbo].[KHACHHANG] ([MAKHACHHANG], [TENKHACHHANG], [EMAIL], [SODIENTHOAI], [NGAYSINH], [DIACHI], [DAXOA], [GIOITINH]) VALUES (3, N'Hoàng Văn Cương', N'hoangcuong@gmail.com', N'01652345788', N'27/07/1955', N'Bắc Giang', 0, N'NAM')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([MANHACUNGCAP], [TENNHACUNGCAP], [DAXOA]) VALUES (1, N'Zara', 0)
INSERT [dbo].[NHACUNGCAP] ([MANHACUNGCAP], [TENNHACUNGCAP], [DAXOA]) VALUES (2, N'Thuận Thành', 0)
INSERT [dbo].[NHACUNGCAP] ([MANHACUNGCAP], [TENNHACUNGCAP], [DAXOA]) VALUES (3, N'Hồng Ngọc Hà Đông', 0)
INSERT [dbo].[NHACUNGCAP] ([MANHACUNGCAP], [TENNHACUNGCAP], [DAXOA]) VALUES (4, N'Twenty Five 1', 1)
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [SODIENTHOAI], [EMAIL], [DIACHI], [MABOPHAN], [TRANGTHAI], [TENTAIKHOAN], [MATKHAU], [DAXOA], [GIOITINH], [NGAYSINH]) VALUES (1, N'nv001', N'0', N'-', N'Hà Đông - Hà Nội - Hải Phòng', 1, 0, N'nv001', N'a', 1, N'NAM', N'20/01/1994')
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [SODIENTHOAI], [EMAIL], [DIACHI], [MABOPHAN], [TRANGTHAI], [TENTAIKHOAN], [MATKHAU], [DAXOA], [GIOITINH], [NGAYSINH]) VALUES (2, N'Ngọc Sơn', N'01685234578', N'ngocson123@gmail.com', N'Cầu Giấy - Hà Nội', 2, 1, N'ngocson', N'a', 0, N'NỮ', N'20/05/1991')
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [SODIENTHOAI], [EMAIL], [DIACHI], [MABOPHAN], [TRANGTHAI], [TENTAIKHOAN], [MATKHAU], [DAXOA], [GIOITINH], [NGAYSINH]) VALUES (3, N'Thu Huyền', N'01235487659', N'thuhuyen123@gmail.com', N'Long Biên - Hà Nội', 2, 0, N'thuhuyen', N'a', 0, N'NAM', N'27/05/1994')
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [SODIENTHOAI], [EMAIL], [DIACHI], [MABOPHAN], [TRANGTHAI], [TENTAIKHOAN], [MATKHAU], [DAXOA], [GIOITINH], [NGAYSINH]) VALUES (4, N'Vũ Dương', N'0168457844', N'vuduong@gmail.com', N'Hồ Tùng Mậu - Hà Nội', 1, 1, N'vuduong', N'a', 0, N'NAM', N'22/05/1994')
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [SODIENTHOAI], [EMAIL], [DIACHI], [MABOPHAN], [TRANGTHAI], [TENTAIKHOAN], [MATKHAU], [DAXOA], [GIOITINH], [NGAYSINH]) VALUES (5, N'Quang Đông', N'0126589576', N'quangdong123@gmail.com', N'Hồ Tùng Mậu - Hà Nội', 1, 1, N'quangdong', N'a', 0, N'NAM', N'10/05/1994')
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [SODIENTHOAI], [EMAIL], [DIACHI], [MABOPHAN], [TRANGTHAI], [TENTAIKHOAN], [MATKHAU], [DAXOA], [GIOITINH], [NGAYSINH]) VALUES (6, N'Nguyễn Thị Hằng', N'01657849568', N'hangnguyen38@gmail.com', N'Hưng Yên', 2, 1, N'hangnguyen', N'a', 0, N'NỮ', N'20/12/1994')
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [SODIENTHOAI], [EMAIL], [DIACHI], [MABOPHAN], [TRANGTHAI], [TENTAIKHOAN], [MATKHAU], [DAXOA], [GIOITINH], [NGAYSINH]) VALUES (11, N'Dương Hoàng Tiến', N'0123475895', N'duongtien@gmail.com', N'Thái Bình', 2, 1, N'tien', N'a', 0, N'NAM', N'11/05/1986')
INSERT [dbo].[NHANVIEN] ([MANHANVIEN], [TENNHANVIEN], [SODIENTHOAI], [EMAIL], [DIACHI], [MABOPHAN], [TRANGTHAI], [TENTAIKHOAN], [MATKHAU], [DAXOA], [GIOITINH], [NGAYSINH]) VALUES (12, N'Nguyễn Văn Nam', N'015664897', N'vannam@gmail.com', N'Văn Điển', 2, 1, N'vannam', N'a', 0, N'NAM', N'27/05/2017')
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([MASANPHAM], [MADANHMUC], [TENSANPHAM], [DONGIANHAP], [DONGIAXUAT], [SOLUONGTON], [HINHANH], [MOTA], [MATHUONGHIEU], [DAXOA], [LOAISANPHAM]) VALUES (2, 2, N'Quần âu 1', 100000, 200000, 14, N'macdinh.jpg', N'Quần âu cao cấp', 3, 0, N'Đồ nam')
INSERT [dbo].[SANPHAM] ([MASANPHAM], [MADANHMUC], [TENSANPHAM], [DONGIANHAP], [DONGIAXUAT], [SOLUONGTON], [HINHANH], [MOTA], [MATHUONGHIEU], [DAXOA], [LOAISANPHAM]) VALUES (3, 4, N'Mũ nồi', 50000, 100000, 16, N'1425295_M.jpg', N'Mũ nồi thời trang', 3, 0, N'Đồ nam')
INSERT [dbo].[SANPHAM] ([MASANPHAM], [MADANHMUC], [TENSANPHAM], [DONGIANHAP], [DONGIAXUAT], [SOLUONGTON], [HINHANH], [MOTA], [MATHUONGHIEU], [DAXOA], [LOAISANPHAM]) VALUES (4, 1, N'Áo phông', 70000, 140000, 19, N'macdinh.jpg', N'Áo phông chất tốt, cá tính', 2, 0, N'Đồ nam')
INSERT [dbo].[SANPHAM] ([MASANPHAM], [MADANHMUC], [TENSANPHAM], [DONGIANHAP], [DONGIAXUAT], [SOLUONGTON], [HINHANH], [MOTA], [MATHUONGHIEU], [DAXOA], [LOAISANPHAM]) VALUES (5, 2, N'Quần sooc', 80000, 160000, 21, N'quan-sooc-nam-kaki-han-quoc-o132pt010p-7.jpg', N'Quần âu cao cấp', 2, 0, N'Đồ nam')
INSERT [dbo].[SANPHAM] ([MASANPHAM], [MADANHMUC], [TENSANPHAM], [DONGIANHAP], [DONGIAXUAT], [SOLUONGTON], [HINHANH], [MOTA], [MATHUONGHIEU], [DAXOA], [LOAISANPHAM]) VALUES (6, 3, N'Giày thể thao', 500000, 1000000, 15, N'giay-the-thao-nu-phong-cach-Han-Quoc-TT023X.jpg', N'Giày thể thao Hàn Quốc', 3, 0, N'Đồ nam')
INSERT [dbo].[SANPHAM] ([MASANPHAM], [MADANHMUC], [TENSANPHAM], [DONGIANHAP], [DONGIAXUAT], [SOLUONGTON], [HINHANH], [MOTA], [MATHUONGHIEU], [DAXOA], [LOAISANPHAM]) VALUES (7, 3, N'Giày converse', 1000, 1000, 25, N'giay-converse.jpg', N'Giày converse cá tính', 3, 0, N'Đồ nam')
INSERT [dbo].[SANPHAM] ([MASANPHAM], [MADANHMUC], [TENSANPHAM], [DONGIANHAP], [DONGIAXUAT], [SOLUONGTON], [HINHANH], [MOTA], [MATHUONGHIEU], [DAXOA], [LOAISANPHAM]) VALUES (8, 3, N'Giày thể thao Trung Quốc', 1000000, 3000000, 16, N'giay-the-thao-nu-phong-cach-Han-Quoc-TT023X.jpg', N'Giày thể thao Trung Quốc chất lượng cao', 2, 0, N'Đồ nam')
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
SET IDENTITY_INSERT [dbo].[THUONGHIEU] ON 

INSERT [dbo].[THUONGHIEU] ([MATHUONGHIEU], [TENTHUONGHIEU], [DAXOA]) VALUES (1, N'Zara', 0)
INSERT [dbo].[THUONGHIEU] ([MATHUONGHIEU], [TENTHUONGHIEU], [DAXOA]) VALUES (2, N'Vuiton LX', 0)
INSERT [dbo].[THUONGHIEU] ([MATHUONGHIEU], [TENTHUONGHIEU], [DAXOA]) VALUES (3, N'Zara 3', 0)
INSERT [dbo].[THUONGHIEU] ([MATHUONGHIEU], [TENTHUONGHIEU], [DAXOA]) VALUES (4, N'Việt Tiến', 0)
INSERT [dbo].[THUONGHIEU] ([MATHUONGHIEU], [TENTHUONGHIEU], [DAXOA]) VALUES (5, N'LX', 1)
SET IDENTITY_INSERT [dbo].[THUONGHIEU] OFF
ALTER TABLE [dbo].[BOPHAN] ADD  CONSTRAINT [DF_BOPHAN_DAXOA]  DEFAULT ((0)) FOR [DAXOA]
GO
ALTER TABLE [dbo].[DANHMUC] ADD  CONSTRAINT [DF_DANHMUC_DAXOA]  DEFAULT ((0)) FOR [DAXOA]
GO
ALTER TABLE [dbo].[HOADONNHAP] ADD  CONSTRAINT [DF_HOADONNHAP_DAXOA]  DEFAULT ((0)) FOR [DAXOA]
GO
ALTER TABLE [dbo].[HOADONXUAT] ADD  CONSTRAINT [DF_HOADONXUAT_DAXOA]  DEFAULT ((0)) FOR [DAXOA]
GO
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [DF_KHACHHANG_NGAYSINH]  DEFAULT (((1)/(1))/(1994)) FOR [NGAYSINH]
GO
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [DF_KHACHHANG_DAXOA]  DEFAULT ((0)) FOR [DAXOA]
GO
ALTER TABLE [dbo].[KHACHHANG] ADD  CONSTRAINT [DF_KHACHHANG_GIOITINH]  DEFAULT (N'NAM') FOR [GIOITINH]
GO
ALTER TABLE [dbo].[NHACUNGCAP] ADD  CONSTRAINT [DF_NHACUNGCAP_DAXOA]  DEFAULT ((0)) FOR [DAXOA]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [DF_NHANVIEN_DAXOA]  DEFAULT ((0)) FOR [DAXOA]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [DF_NHANVIEN_GIOITINH]  DEFAULT (N'Nam') FOR [GIOITINH]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [DF_NHANVIEN_NGAYSINH]  DEFAULT (((1)/(1))/(1994)) FOR [NGAYSINH]
GO
ALTER TABLE [dbo].[SANPHAM] ADD  CONSTRAINT [DF_SANPHAM_SOLUONGTON]  DEFAULT ((0)) FOR [SOLUONGTON]
GO
ALTER TABLE [dbo].[SANPHAM] ADD  CONSTRAINT [DF_SANPHAM_DAXOA]  DEFAULT ((0)) FOR [DAXOA]
GO
ALTER TABLE [dbo].[SANPHAM] ADD  CONSTRAINT [DF_SANPHAM_LOAISANPHAM]  DEFAULT (N'Đồ nam') FOR [LOAISANPHAM]
GO
ALTER TABLE [dbo].[THUONGHIEU] ADD  CONSTRAINT [DF_THUONGHIEU_DAXOA]  DEFAULT ((0)) FOR [DAXOA]
GO
ALTER TABLE [dbo].[CHITIETHOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADONNHAP_HOADONNHAP] FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADONNHAP] ([MAHOADON])
GO
ALTER TABLE [dbo].[CHITIETHOADONNHAP] CHECK CONSTRAINT [FK_CHITIETHOADONNHAP_HOADONNHAP]
GO
ALTER TABLE [dbo].[CHITIETHOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADONNHAP_SANPHAM] FOREIGN KEY([MASANPHAM])
REFERENCES [dbo].[SANPHAM] ([MASANPHAM])
GO
ALTER TABLE [dbo].[CHITIETHOADONNHAP] CHECK CONSTRAINT [FK_CHITIETHOADONNHAP_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIETHOADONXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADONXUAT_SANPHAM] FOREIGN KEY([MASANPHAM])
REFERENCES [dbo].[SANPHAM] ([MASANPHAM])
GO
ALTER TABLE [dbo].[CHITIETHOADONXUAT] CHECK CONSTRAINT [FK_CHITIETHOADONXUAT_SANPHAM]
GO
ALTER TABLE [dbo].[HOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_HOADONNHAP_NHACUNGCAP] FOREIGN KEY([MANHACUNGCAP])
REFERENCES [dbo].[NHACUNGCAP] ([MANHACUNGCAP])
GO
ALTER TABLE [dbo].[HOADONNHAP] CHECK CONSTRAINT [FK_HOADONNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[HOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_HOADONNHAP_NHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
GO
ALTER TABLE [dbo].[HOADONNHAP] CHECK CONSTRAINT [FK_HOADONNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[HOADONXUAT]  WITH CHECK ADD  CONSTRAINT [FK_HOADONXUAT_KHACHHANG] FOREIGN KEY([MAKHACHHANG])
REFERENCES [dbo].[KHACHHANG] ([MAKHACHHANG])
GO
ALTER TABLE [dbo].[HOADONXUAT] CHECK CONSTRAINT [FK_HOADONXUAT_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADONXUAT]  WITH CHECK ADD  CONSTRAINT [FK_HOADONXUAT_NHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
GO
ALTER TABLE [dbo].[HOADONXUAT] CHECK CONSTRAINT [FK_HOADONXUAT_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BOPHAN] FOREIGN KEY([MABOPHAN])
REFERENCES [dbo].[BOPHAN] ([MABOPHAN])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BOPHAN]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_DANHMUC] FOREIGN KEY([MADANHMUC])
REFERENCES [dbo].[DANHMUC] ([MADANHMUC])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_DANHMUC]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_THUONGHIEU] FOREIGN KEY([MATHUONGHIEU])
REFERENCES [dbo].[THUONGHIEU] ([MATHUONGHIEU])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SANPHAM_THUONGHIEU]
GO
USE [master]
GO
ALTER DATABASE [banquanao] SET  READ_WRITE 
GO
