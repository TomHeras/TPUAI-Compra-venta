USE [master]
GO
/****** Object:  Database [TPMODELOS]    Script Date: 11/07/2023 18:46:26 ******/
CREATE DATABASE [TPMODELOS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TPMODELOS', FILENAME = N'D:\MSSQL12.TOOM\MSSQL\DATA\TPMODELOS.mdf' , SIZE = 9216KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TPMODELOS_log', FILENAME = N'D:\MSSQL12.TOOM\MSSQL\DATA\TPMODELOS_log.ldf' , SIZE = 625792KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TPMODELOS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TPMODELOS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TPMODELOS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TPMODELOS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TPMODELOS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TPMODELOS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TPMODELOS] SET ARITHABORT OFF 
GO
ALTER DATABASE [TPMODELOS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TPMODELOS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TPMODELOS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TPMODELOS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TPMODELOS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TPMODELOS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TPMODELOS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TPMODELOS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TPMODELOS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TPMODELOS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TPMODELOS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TPMODELOS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TPMODELOS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TPMODELOS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TPMODELOS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TPMODELOS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TPMODELOS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TPMODELOS] SET RECOVERY FULL 
GO
ALTER DATABASE [TPMODELOS] SET  MULTI_USER 
GO
ALTER DATABASE [TPMODELOS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TPMODELOS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TPMODELOS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TPMODELOS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TPMODELOS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TPMODELOS', N'ON'
GO
USE [TPMODELOS]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[IdBitacora] [int] IDENTITY(1,1) NOT NULL,
	[NickUsuario] [nvarchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Criticidad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[IdBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID_clientes] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[direccion] [nvarchar](50) NULL,
	[telefono] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ID_clientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[estados]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estados](
	[IDestado] [int] NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_estados] PRIMARY KEY CLUSTERED 
(
	[IDestado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Etiqueta]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etiqueta](
	[Id_Etiqueta] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Etiqueta] PRIMARY KEY CLUSTERED 
(
	[Id_Etiqueta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[Id_Idioma] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Idioma_Default] [bit] NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[Id_Idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patente]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patente](
	[IdPat] [int] IDENTITY(1,1) NOT NULL,
	[PatNom] [nvarchar](50) NULL,
	[PatDesc] [nvarchar](50) NULL,
	[PatDVH] [nvarchar](50) NULL,
 CONSTRAINT [PK_permiso_1] PRIMARY KEY CLUSTERED 
(
	[IdPat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patente_Patente]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patente_Patente](
	[id_patente_padre] [int] NULL,
	[id_patente_hijo] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pedidocab]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidocab](
	[ID_pedido] [int] NOT NULL,
	[ID_clientes] [int] NOT NULL,
	[estado] [int] NOT NULL,
	[fechagen] [datetime] NOT NULL,
	[fechaact] [datetime] NOT NULL,
 CONSTRAINT [PK_Pedido_estados] PRIMARY KEY CLUSTERED 
(
	[ID_pedido] ASC,
	[ID_clientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pedidosdet]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidosdet](
	[ID_pedido] [int] NOT NULL,
	[ID_clientes] [int] NOT NULL,
	[ID_producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[costo] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[ID_pedido] ASC,
	[ID_producto] ASC,
	[ID_clientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Precios]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Precios](
	[ID_producto] [int] NOT NULL,
	[detalles] [nvarchar](50) NULL,
	[precio] [decimal](18, 2) NULL,
	[medidas] [decimal](18, 2) NULL,
	[Tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Precios] PRIMARY KEY CLUSTERED 
(
	[ID_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[ID_proveedor] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[direccion] [nvarchar](50) NULL,
	[telefono] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stock]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[ID_producto] [int] NOT NULL,
	[medidas] [decimal](18, 2) NULL,
	[cantidad] [int] NULL,
	[Tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[ID_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[Id_Traduccion] [int] IDENTITY(1,1) NOT NULL,
	[Id_Idioma] [int] NOT NULL,
	[Id_Etiqueta] [int] NOT NULL,
	[Traduccion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[Id_Traduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario_Patente]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Patente](
	[IdUsu] [int] NOT NULL,
	[IdPat] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Permiso] PRIMARY KEY CLUSTERED 
(
	[IdUsu] ASC,
	[IdPat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Idusu] [int] IDENTITY(1,1) NOT NULL,
	[IdIdioma] [int] NOT NULL,
	[Usunom] [nvarchar](50) NOT NULL,
	[Usunick] [nvarchar](50) NOT NULL,
	[Usupass] [nvarchar](50) NOT NULL,
	[Usumail] [nvarchar](50) NOT NULL,
	[Usuestado] [bit] NOT NULL,
	[UsubajaL] [bit] NOT NULL,
	[UsuDVH] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Idusu] ASC,
	[Usunick] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1, N'admin', CAST(N'2022-11-04 14:58:35.257' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (2, N'admin', CAST(N'2022-11-04 15:02:18.463' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3, N'admin', CAST(N'2022-11-04 15:03:46.587' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (4, N'admin', CAST(N'2022-11-04 15:04:49.777' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (5, N'admin', CAST(N'2022-11-04 15:05:14.990' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (6, N'admin', CAST(N'2022-11-04 15:06:53.540' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (7, N'admin', CAST(N'2022-11-04 15:09:59.410' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (8, N'admin', CAST(N'2022-11-04 15:11:12.733' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (9, N'admin', CAST(N'2022-11-04 15:32:34.770' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (10, N'admin', CAST(N'2022-11-04 15:36:22.083' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (11, N'admin', CAST(N'2022-11-04 15:37:14.950' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (12, N'admin', CAST(N'2022-11-04 15:37:39.620' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (13, N'admin', CAST(N'2022-11-04 15:39:00.997' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (14, N'admin', CAST(N'2022-11-04 15:42:01.013' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (15, N'admin', CAST(N'2022-11-04 21:13:56.327' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (16, N'admin', CAST(N'2022-11-06 22:30:25.653' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (17, N'admin', CAST(N'2022-11-07 00:07:00.987' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1002, N'admin', CAST(N'2022-11-08 19:15:08.823' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1003, N'admin', CAST(N'2022-11-13 16:38:14.810' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1004, N'admin', CAST(N'2022-11-13 17:53:44.740' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1005, N'admin', CAST(N'2022-11-13 20:08:35.343' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1006, N'admin', CAST(N'2022-11-13 20:27:50.897' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1007, N'admin', CAST(N'2022-11-13 21:58:26.150' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1008, N'admin', CAST(N'2022-11-13 22:12:51.800' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1009, N'admin', CAST(N'2022-11-13 23:51:50.823' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (1010, N'admin', CAST(N'2022-11-14 01:00:48.627' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (2003, N'admin', CAST(N'2023-04-19 00:23:49.473' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (2004, N'admin', CAST(N'2023-04-19 00:24:52.057' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (2005, N'admin', CAST(N'2023-04-19 00:25:46.703' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3003, N'admin', CAST(N'2023-07-09 17:58:47.393' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3004, N'admin', CAST(N'2023-07-09 18:00:46.800' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3005, N'admin', CAST(N'2023-07-09 19:03:08.640' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3006, N'admin', CAST(N'2023-07-09 19:04:56.687' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3007, N'admin', CAST(N'2023-07-09 20:26:37.010' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3008, N'admin', CAST(N'2023-07-09 20:27:40.377' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3009, N'admin', CAST(N'2023-07-09 20:29:12.370' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3010, N'admin', CAST(N'2023-07-09 20:31:30.080' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3011, N'admin', CAST(N'2023-07-09 20:35:24.500' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3012, N'admin', CAST(N'2023-07-09 21:25:32.227' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3013, N'admin', CAST(N'2023-07-09 21:28:26.197' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3014, N'admin', CAST(N'2023-07-09 21:29:38.110' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3015, N'admin', CAST(N'2023-07-09 21:35:26.387' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3016, N'admin', CAST(N'2023-07-09 21:39:12.373' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3017, N'admin', CAST(N'2023-07-09 21:43:47.990' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3018, N'admin', CAST(N'2023-07-09 21:47:46.580' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3019, N'admin', CAST(N'2023-07-09 21:48:30.980' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3020, N'admin', CAST(N'2023-07-09 21:51:19.077' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3021, N'admin', CAST(N'2023-07-09 21:55:17.783' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3022, N'admin', CAST(N'2023-07-09 22:03:49.103' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3023, N'admin', CAST(N'2023-07-09 22:11:43.260' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3024, N'admin', CAST(N'2023-07-09 22:13:23.623' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3025, N'admin', CAST(N'2023-07-09 22:17:19.483' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3026, N'admin', CAST(N'2023-07-09 22:21:41.093' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3027, N'admin', CAST(N'2023-07-09 22:23:28.670' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3028, N'admin', CAST(N'2023-07-09 22:26:40.470' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3029, N'admin', CAST(N'2023-07-09 22:31:19.860' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3030, N'admin', CAST(N'2023-07-09 22:35:52.153' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3031, N'admin', CAST(N'2023-07-09 23:07:51.223' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3032, N'admin', CAST(N'2023-07-09 23:20:03.563' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3033, N'admin', CAST(N'2023-07-09 23:24:01.973' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3034, N'admin', CAST(N'2023-07-09 23:27:57.173' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3035, N'admin', CAST(N'2023-07-09 23:34:21.753' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3036, N'admin', CAST(N'2023-07-09 23:41:35.197' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3037, N'admin', CAST(N'2023-07-09 23:43:47.443' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3038, N'admin', CAST(N'2023-07-09 23:50:18.507' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3039, N'admin', CAST(N'2023-07-10 12:22:42.070' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3040, N'admin', CAST(N'2023-07-10 12:33:29.620' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3041, N'admin', CAST(N'2023-07-10 12:36:57.237' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3042, N'admin', CAST(N'2023-07-10 13:42:38.007' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3043, N'admin', CAST(N'2023-07-10 13:45:51.727' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3044, N'admin', CAST(N'2023-07-10 13:48:55.690' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3045, N'admin', CAST(N'2023-07-10 13:50:21.823' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3046, N'admin', CAST(N'2023-07-10 13:51:01.753' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3047, N'admin', CAST(N'2023-07-10 13:54:03.003' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3048, N'admin', CAST(N'2023-07-10 13:55:24.667' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3049, N'admin', CAST(N'2023-07-10 13:56:23.520' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3050, N'admin', CAST(N'2023-07-10 14:01:54.330' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3051, N'admin', CAST(N'2023-07-10 14:03:57.013' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3052, N'admin', CAST(N'2023-07-10 14:10:26.537' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3053, N'admin', CAST(N'2023-07-10 14:16:29.147' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3054, N'admin', CAST(N'2023-07-10 14:18:37.297' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3055, N'admin', CAST(N'2023-07-10 14:19:01.910' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3056, N'admin', CAST(N'2023-07-10 14:23:26.543' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3057, N'admin', CAST(N'2023-07-10 14:29:34.267' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3058, N'admin', CAST(N'2023-07-10 14:35:57.027' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3059, N'admin', CAST(N'2023-07-10 14:39:28.757' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3060, N'admin', CAST(N'2023-07-10 14:51:49.210' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3061, N'admin', CAST(N'2023-07-10 14:53:33.427' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3062, N'admin', CAST(N'2023-07-10 14:57:20.673' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3063, N'admin', CAST(N'2023-07-10 18:20:32.730' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3064, N'admin', CAST(N'2023-07-10 18:22:06.420' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3065, N'admin', CAST(N'2023-07-10 18:23:07.807' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3066, N'admin', CAST(N'2023-07-10 18:28:49.697' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3067, N'admin', CAST(N'2023-07-10 18:29:31.117' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3068, N'admin', CAST(N'2023-07-10 18:30:57.883' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3069, N'admin', CAST(N'2023-07-10 18:33:02.510' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3070, N'admin', CAST(N'2023-07-10 18:33:28.190' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3071, N'admin', CAST(N'2023-07-10 18:36:13.020' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3072, N'admin', CAST(N'2023-07-10 18:36:50.627' AS DateTime), N'Inicio de sesion', N'baja')
GO
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3073, N'admin', CAST(N'2023-07-10 18:37:24.430' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3074, N'admin', CAST(N'2023-07-10 18:38:36.587' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3075, N'admin', CAST(N'2023-07-10 18:43:50.187' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3076, N'admin', CAST(N'2023-07-10 18:44:48.357' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3077, N'admin', CAST(N'2023-07-10 18:48:25.263' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3078, N'admin', CAST(N'2023-07-10 18:52:47.817' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3079, N'admin', CAST(N'2023-07-10 18:53:28.273' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3080, N'admin', CAST(N'2023-07-10 18:54:18.927' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3081, N'admin', CAST(N'2023-07-10 19:27:37.993' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3082, N'admin', CAST(N'2023-07-10 19:28:29.197' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3083, N'admin', CAST(N'2023-07-10 19:29:22.980' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3084, N'admin', CAST(N'2023-07-10 19:33:15.443' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3085, N'admin', CAST(N'2023-07-10 19:34:46.343' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3086, N'admin', CAST(N'2023-07-10 19:35:46.947' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3087, N'admin', CAST(N'2023-07-10 20:05:57.987' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3088, N'admin', CAST(N'2023-07-10 20:06:52.243' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3089, N'admin', CAST(N'2023-07-10 20:20:46.983' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3090, N'admin', CAST(N'2023-07-10 20:30:23.237' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3091, N'admin', CAST(N'2023-07-10 20:56:41.343' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3092, N'admin', CAST(N'2023-07-10 21:11:48.633' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3093, N'admin', CAST(N'2023-07-10 21:13:33.250' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3094, N'admin', CAST(N'2023-07-10 21:16:19.033' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3095, N'admin', CAST(N'2023-07-10 21:18:14.320' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3096, N'admin', CAST(N'2023-07-10 21:32:20.053' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3097, N'admin', CAST(N'2023-07-10 21:42:37.340' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3098, N'admin', CAST(N'2023-07-10 22:33:59.567' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3099, N'admin', CAST(N'2023-07-10 22:35:27.167' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3100, N'admin', CAST(N'2023-07-10 22:37:08.577' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3101, N'admin', CAST(N'2023-07-10 22:38:05.147' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3102, N'admin', CAST(N'2023-07-10 22:57:31.830' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3103, N'admin', CAST(N'2023-07-10 22:58:04.863' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3104, N'admin', CAST(N'2023-07-10 23:00:34.247' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3105, N'admin', CAST(N'2023-07-10 23:02:10.033' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3106, N'admin', CAST(N'2023-07-10 23:10:04.737' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3107, N'admin', CAST(N'2023-07-10 23:10:52.583' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3108, N'admin', CAST(N'2023-07-10 23:12:46.567' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3109, N'admin', CAST(N'2023-07-10 23:13:39.013' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3110, N'admin', CAST(N'2023-07-10 23:14:27.083' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3111, N'admin', CAST(N'2023-07-10 23:15:13.493' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3112, N'admin', CAST(N'2023-07-10 23:25:20.703' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3113, N'admin', CAST(N'2023-07-10 23:31:57.803' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3114, N'admin', CAST(N'2023-07-10 23:33:40.607' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3115, N'admin', CAST(N'2023-07-10 23:34:39.710' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3116, N'admin', CAST(N'2023-07-10 23:35:26.070' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3117, N'admin', CAST(N'2023-07-10 23:37:25.490' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3118, N'admin', CAST(N'2023-07-10 23:38:25.717' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3119, N'admin', CAST(N'2023-07-10 23:46:18.247' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3120, N'admin', CAST(N'2023-07-10 23:48:55.390' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3121, N'admin', CAST(N'2023-07-10 23:50:00.850' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3122, N'admin', CAST(N'2023-07-10 23:56:39.337' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3123, N'admin', CAST(N'2023-07-10 23:59:05.967' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3124, N'admin', CAST(N'2023-07-11 00:02:03.993' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3125, N'admin', CAST(N'2023-07-11 00:03:09.393' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3126, N'admin', CAST(N'2023-07-11 00:06:33.217' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3127, N'admin', CAST(N'2023-07-11 00:07:37.337' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3128, N'admin', CAST(N'2023-07-11 00:08:09.437' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3129, N'admin', CAST(N'2023-07-11 12:10:40.137' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3130, N'admin', CAST(N'2023-07-11 12:11:40.487' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3131, N'admin', CAST(N'2023-07-11 12:12:09.860' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3132, N'admin', CAST(N'2023-07-11 13:08:22.303' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3133, N'admin', CAST(N'2023-07-11 13:09:18.373' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3134, N'admin', CAST(N'2023-07-11 13:21:06.840' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3135, N'admin', CAST(N'2023-07-11 13:22:29.590' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3136, N'admin', CAST(N'2023-07-11 13:28:49.333' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3137, N'admin', CAST(N'2023-07-11 13:37:23.637' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3138, N'admin', CAST(N'2023-07-11 13:54:40.923' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3139, N'admin', CAST(N'2023-07-11 14:04:50.723' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3140, N'admin', CAST(N'2023-07-11 14:05:47.793' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3141, N'admin', CAST(N'2023-07-11 14:19:29.613' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3142, N'admin', CAST(N'2023-07-11 14:41:35.850' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3143, N'admin', CAST(N'2023-07-11 14:42:16.037' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3144, N'admin', CAST(N'2023-07-11 14:42:37.667' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3145, N'admin', CAST(N'2023-07-11 14:43:20.760' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3146, N'admin', CAST(N'2023-07-11 14:45:45.723' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3147, N'admin', CAST(N'2023-07-11 14:54:15.187' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3148, N'admin', CAST(N'2023-07-11 14:59:19.840' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3149, N'admin', CAST(N'2023-07-11 15:02:51.233' AS DateTime), N'Inicio de sesion', N'baja')
INSERT [dbo].[Bitacora] ([IdBitacora], [NickUsuario], [Fecha], [Descripcion], [Criticidad]) VALUES (3150, N'admin', CAST(N'2023-07-11 18:43:36.560' AS DateTime), N'Inicio de sesion', N'baja')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
INSERT [dbo].[Clientes] ([ID_clientes], [nombre], [direccion], [telefono]) VALUES (1, N'Torvac Sa', N'carlos glade 202', 42023124)
INSERT [dbo].[Clientes] ([ID_clientes], [nombre], [direccion], [telefono]) VALUES (2, N'Torlama SRL', N'Pavon 1500', 42485911)
INSERT [dbo].[estados] ([IDestado], [descripcion]) VALUES (0, N'Creado')
INSERT [dbo].[estados] ([IDestado], [descripcion]) VALUES (1, N'Pagado')
INSERT [dbo].[estados] ([IDestado], [descripcion]) VALUES (2, N'Entregado')
INSERT [dbo].[estados] ([IDestado], [descripcion]) VALUES (3, N'Cancelado')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (1, N'sesion')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (2, N'cambiar_contraseña')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (3, N'cerrarsesion')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (4, N'idioma')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (5, N'seleccionar_idioma')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (6, N'gestionar_idioma')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (7, N'actualizar_lista_idiomas')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (8, N'seguridad')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (9, N'famypat')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (10, N'usuarios')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (11, N'gestion')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (12, N'usuario')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (13, N'negocio')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (14, N'socio')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (15, N'ges_socio')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (16, N'asignar_socio_clase')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (17, N'entrenador')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (18, N'gestionar_entrenador')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (19, N'asignar_entrenador_clase')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (20, N'entrenamiento')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (21, N'gestionar_entrenamiento')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (22, N'asignar_horario')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (23, N'CambiarContraseña ')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (24, N'contraseña_actual')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (25, N'contraseña_nueva')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (26, N'confirmar_contraseña')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (27, N'aceptar')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (28, N'cancelar')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (29, N'clientes')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (30, N'stock')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (31, N'prov')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (32, N'ventas')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (33, N'pedidos')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (34, N'prod')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (35, N'precios')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (36, N'pedidoprov')
INSERT [dbo].[Etiqueta] ([Id_Etiqueta], [Nombre]) VALUES (37, N'compras')
INSERT [dbo].[Idioma] ([Id_Idioma], [Nombre], [Idioma_Default]) VALUES (1, N'Español', 1)
INSERT [dbo].[Idioma] ([Id_Idioma], [Nombre], [Idioma_Default]) VALUES (2, N'Inglés', 1)
INSERT [dbo].[Idioma] ([Id_Idioma], [Nombre], [Idioma_Default]) VALUES (3, N'Chino mandarín ', 0)
INSERT [dbo].[Idioma] ([Id_Idioma], [Nombre], [Idioma_Default]) VALUES (4, N'Alemán ', 0)
SET IDENTITY_INSERT [dbo].[Patente] ON 

INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (1, N'Administrador', NULL, N'123')
INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (25, N'Permisos', N'puedeconfigurarpatentesyfamilias', NULL)
INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (26, N'Usuariospermisos', N'puedeconfigurarseguridadusuarios', NULL)
INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (27, N'ABMusuarios', N'puedeabmusuarios', NULL)
INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (2033, N'AdministradorN', NULL, NULL)
INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (2034, N'Idioma', NULL, NULL)
INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (2035, N'Veridioma', N'puedeveridioma', NULL)
INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (2036, N'ConfigIdioma', N'puedeconfiguraridioma', NULL)
INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (2037, N'Cambiaridioma', N'puedecambiaridioma', NULL)
INSERT [dbo].[Patente] ([IdPat], [PatNom], [PatDesc], [PatDVH]) VALUES (2038, N'ConfigLista', N'puedeconfigurarlista', NULL)
SET IDENTITY_INSERT [dbo].[Patente] OFF
INSERT [dbo].[Patente_Patente] ([id_patente_padre], [id_patente_hijo]) VALUES (2033, 26)
INSERT [dbo].[Patente_Patente] ([id_patente_padre], [id_patente_hijo]) VALUES (2033, 25)
INSERT [dbo].[Patente_Patente] ([id_patente_padre], [id_patente_hijo]) VALUES (2033, 27)
INSERT [dbo].[Patente_Patente] ([id_patente_padre], [id_patente_hijo]) VALUES (2034, 2035)
INSERT [dbo].[Patente_Patente] ([id_patente_padre], [id_patente_hijo]) VALUES (2034, 2036)
INSERT [dbo].[Patente_Patente] ([id_patente_padre], [id_patente_hijo]) VALUES (2034, 2037)
INSERT [dbo].[Patente_Patente] ([id_patente_padre], [id_patente_hijo]) VALUES (2034, 2038)
INSERT [dbo].[Pedidocab] ([ID_pedido], [ID_clientes], [estado], [fechagen], [fechaact]) VALUES (1, 2, 2, CAST(N'2023-07-10 21:32:33.233' AS DateTime), CAST(N'2023-07-10 23:25:59.160' AS DateTime))
INSERT [dbo].[Pedidocab] ([ID_pedido], [ID_clientes], [estado], [fechagen], [fechaact]) VALUES (2, 1, 0, CAST(N'2023-07-10 23:49:10.080' AS DateTime), CAST(N'2023-07-10 23:49:10.080' AS DateTime))
INSERT [dbo].[Pedidocab] ([ID_pedido], [ID_clientes], [estado], [fechagen], [fechaact]) VALUES (3, 2, 3, CAST(N'2023-07-10 23:50:28.197' AS DateTime), CAST(N'2023-07-10 23:59:45.497' AS DateTime))
INSERT [dbo].[Pedidocab] ([ID_pedido], [ID_clientes], [estado], [fechagen], [fechaact]) VALUES (4, 1, 0, CAST(N'2023-07-10 23:56:53.987' AS DateTime), CAST(N'2023-07-10 23:56:53.987' AS DateTime))
INSERT [dbo].[Pedidocab] ([ID_pedido], [ID_clientes], [estado], [fechagen], [fechaact]) VALUES (5, 1, 0, CAST(N'2023-07-10 23:59:16.760' AS DateTime), CAST(N'2023-07-10 23:59:16.760' AS DateTime))
INSERT [dbo].[Pedidosdet] ([ID_pedido], [ID_clientes], [ID_producto], [Cantidad], [costo]) VALUES (1, 2, 7, 1, CAST(15000.00 AS Decimal(18, 2)))
INSERT [dbo].[Pedidosdet] ([ID_pedido], [ID_clientes], [ID_producto], [Cantidad], [costo]) VALUES (1, 2, 11, 1, CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[Pedidosdet] ([ID_pedido], [ID_clientes], [ID_producto], [Cantidad], [costo]) VALUES (2, 1, 7, 1, CAST(15000.00 AS Decimal(18, 2)))
INSERT [dbo].[Pedidosdet] ([ID_pedido], [ID_clientes], [ID_producto], [Cantidad], [costo]) VALUES (3, 2, 10, 1, CAST(34560.00 AS Decimal(18, 2)))
INSERT [dbo].[Pedidosdet] ([ID_pedido], [ID_clientes], [ID_producto], [Cantidad], [costo]) VALUES (4, 1, 10, 1, CAST(34560.00 AS Decimal(18, 2)))
INSERT [dbo].[Pedidosdet] ([ID_pedido], [ID_clientes], [ID_producto], [Cantidad], [costo]) VALUES (5, 1, 10, 1, CAST(34560.00 AS Decimal(18, 2)))
INSERT [dbo].[Precios] ([ID_producto], [detalles], [precio], [medidas], [Tipo]) VALUES (7, N'q', CAST(15000.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), N'cruz')
INSERT [dbo].[Precios] ([ID_producto], [detalles], [precio], [medidas], [Tipo]) VALUES (10, N'c', CAST(34560.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), N'cruz')
INSERT [dbo].[Precios] ([ID_producto], [detalles], [precio], [medidas], [Tipo]) VALUES (11, N'1', CAST(6000.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), N'cruz')
INSERT [dbo].[Precios] ([ID_producto], [detalles], [precio], [medidas], [Tipo]) VALUES (12, N'a', CAST(5000.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), N'cruz')
INSERT [dbo].[Stock] ([ID_producto], [medidas], [cantidad], [Tipo]) VALUES (7, CAST(25.00 AS Decimal(18, 2)), 25000, N'cruz')
INSERT [dbo].[Stock] ([ID_producto], [medidas], [cantidad], [Tipo]) VALUES (9, CAST(25.00 AS Decimal(18, 2)), 25000, N'cruz')
INSERT [dbo].[Stock] ([ID_producto], [medidas], [cantidad], [Tipo]) VALUES (10, CAST(25.00 AS Decimal(18, 2)), 25000, N'cruz')
INSERT [dbo].[Stock] ([ID_producto], [medidas], [cantidad], [Tipo]) VALUES (11, CAST(25.00 AS Decimal(18, 2)), 25000, N'cruz')
INSERT [dbo].[Stock] ([ID_producto], [medidas], [cantidad], [Tipo]) VALUES (12, CAST(25.00 AS Decimal(18, 2)), 25000, N'cruz')
SET IDENTITY_INSERT [dbo].[Traduccion] ON 

INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (1, 1, 1, N'Sesión')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (2, 1, 2, N'Cambiar Contraseña')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (3, 1, 3, N'Cerrar Sesión')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (4, 1, 4, N'Idioma')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (5, 1, 5, N'Seleccionar Idioma')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (6, 1, 6, N'Gestionar Idioma')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (7, 1, 7, N'Actualizar Lista Idiomas')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (8, 1, 8, N'Seguridad')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (9, 1, 9, N'Familia y Patentes')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (10, 1, 10, N'Usuarios')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (11, 1, 11, N'Gestión')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (12, 1, 12, N'Usuarios')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (13, 1, 13, N'Negocio')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (14, 1, 14, N'Socio')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (15, 1, 15, N'Gestionar Socio')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (16, 1, 16, N'Asignar Socio Clase')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (17, 1, 17, N'Entrenador')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (18, 1, 18, N'Gestionar Entrenador')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (19, 1, 19, N'Asignar Entrenador Clase')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (20, 1, 20, N'Entrenamiento')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (21, 1, 21, N'Gestionar Entrenamiento')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (22, 1, 22, N'Asignar Horario')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (23, 1, 23, N'CAMBIAR CONTRASEÑA')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (24, 1, 24, N'Contraseña Actual :')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (25, 1, 25, N'Contraseña Nueva :')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (26, 1, 26, N'Confirmar Nueva Contraseña :')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (27, 1, 27, N'Aceptar')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (28, 1, 28, N'Cancelar')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (29, 2, 1, N'Session')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (30, 2, 2, N'Change Password')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (31, 2, 3, N'Logout')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (32, 2, 4, N'Language')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (33, 2, 5, N'Select Language')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (34, 2, 6, N'Configure Language')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (35, 2, 7, N'Refresh List Language')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (36, 2, 8, N'Security')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (37, 2, 9, N'Family and Permission')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (38, 2, 10, N'Users')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (39, 2, 11, N'Configure')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (40, 2, 12, N'User')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (41, 2, 13, N'Business')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (42, 2, 14, N'Client')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (43, 2, 15, N'Configure Client')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (44, 2, 16, N'Client and Class')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (45, 2, 17, N'Trainer')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (46, 2, 18, N'Configure Trainer')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (47, 2, 19, N'Trainer and Class')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (48, 2, 20, N'Training')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (49, 2, 21, N'Configure Training')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (50, 2, 22, N'Configure Time')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (51, 2, 23, N'CHANGE PASSWORD')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (52, 2, 24, N'Your Password')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (53, 2, 25, N'New Password')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (54, 2, 26, N'Confirm Password')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (55, 2, 27, N'Ok')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (56, 2, 28, N'Dimiss')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (57, 3, 1, N'Culio')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (58, 3, 2, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (59, 3, 3, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (60, 3, 4, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (61, 3, 5, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (62, 3, 6, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (63, 3, 7, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (64, 3, 8, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (65, 3, 9, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (66, 3, 10, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (67, 3, 11, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (68, 3, 12, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (69, 3, 13, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (70, 3, 14, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (71, 3, 15, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (72, 3, 16, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (73, 3, 17, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (74, 3, 18, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (75, 3, 19, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (76, 3, 20, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (77, 3, 21, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (78, 3, 22, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (79, 3, 23, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (80, 3, 24, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (81, 3, 25, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (82, 3, 26, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (83, 3, 27, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (84, 3, 28, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (85, 4, 1, N'kraken')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (86, 4, 2, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (87, 4, 3, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (88, 4, 4, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (89, 4, 5, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (90, 4, 6, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (91, 4, 7, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (92, 4, 8, N'hhhhhh')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (93, 4, 9, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (94, 4, 10, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (95, 4, 11, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (96, 4, 12, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (97, 4, 13, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (98, 4, 14, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (99, 4, 15, N'default')
GO
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (100, 4, 16, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (101, 4, 17, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (102, 4, 18, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (103, 4, 19, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (104, 4, 20, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (105, 4, 21, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (106, 4, 22, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (107, 4, 23, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (108, 4, 24, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (109, 4, 25, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (110, 4, 26, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (111, 4, 27, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (112, 4, 28, N'default')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (113, 2, 29, N'Clients')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (114, 2, 30, N's')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (115, 2, 31, N's')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (116, 2, 32, N'd')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (117, 2, 33, N'dd')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (118, 2, 34, N'Products')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (119, 2, 35, N'h')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (120, 2, 36, N'h')
INSERT [dbo].[Traduccion] ([Id_Traduccion], [Id_Idioma], [Id_Etiqueta], [Traduccion]) VALUES (121, 2, 37, N'd')
SET IDENTITY_INSERT [dbo].[Traduccion] OFF
INSERT [dbo].[Usuario_Patente] ([IdUsu], [IdPat]) VALUES (2, 25)
INSERT [dbo].[Usuario_Patente] ([IdUsu], [IdPat]) VALUES (2, 26)
INSERT [dbo].[Usuario_Patente] ([IdUsu], [IdPat]) VALUES (2, 2034)
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Idusu], [IdIdioma], [Usunom], [Usunick], [Usupass], [Usumail], [Usuestado], [UsubajaL], [UsuDVH]) VALUES (1, 1, N'administrador', N'admin', N'!#/)zW??C?JJ??', N'tom_heras@hotmail.com', 1, 1, 1)
INSERT [dbo].[Usuarios] ([Idusu], [IdIdioma], [Usunom], [Usunick], [Usupass], [Usumail], [Usuestado], [UsubajaL], [UsuDVH]) VALUES (2, 1, N'user', N'cliente', N'!#/)zW??C?JJ??', N'toom@gmail.com', 1, 1, 1)
INSERT [dbo].[Usuarios] ([Idusu], [IdIdioma], [Usunom], [Usunick], [Usupass], [Usumail], [Usuestado], [UsubajaL], [UsuDVH]) VALUES (3, 1, N'', N'', N'???? ???	???B~', N'', 1, 0, 1)
INSERT [dbo].[Usuarios] ([Idusu], [IdIdioma], [Usunom], [Usunick], [Usupass], [Usumail], [Usuestado], [UsubajaL], [UsuDVH]) VALUES (4, 1, N'Tom', N'Toomh', N'!#/)zW??C?JJ??', N'addd', 1, 0, 1)
INSERT [dbo].[Usuarios] ([Idusu], [IdIdioma], [Usunom], [Usunick], [Usupass], [Usumail], [Usuestado], [UsubajaL], [UsuDVH]) VALUES (5, 0, N'122', N'toomh', N'!#/)zW??C?JJ??', N'toj@yahho.com', 1, 0, 1)
INSERT [dbo].[Usuarios] ([Idusu], [IdIdioma], [Usunom], [Usunick], [Usupass], [Usumail], [Usuestado], [UsubajaL], [UsuDVH]) VALUES (6, 0, N'faf', N'toomh', N'D???l,$?,?-$??', N'adad', 1, 0, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Patente_Patente]  WITH CHECK ADD  CONSTRAINT [FK_patente_patente_Patente] FOREIGN KEY([id_patente_padre])
REFERENCES [dbo].[Patente] ([IdPat])
GO
ALTER TABLE [dbo].[Patente_Patente] CHECK CONSTRAINT [FK_patente_patente_Patente]
GO
ALTER TABLE [dbo].[Pedidocab]  WITH CHECK ADD  CONSTRAINT [FK_estados_ped] FOREIGN KEY([estado])
REFERENCES [dbo].[estados] ([IDestado])
GO
ALTER TABLE [dbo].[Pedidocab] CHECK CONSTRAINT [FK_estados_ped]
GO
ALTER TABLE [dbo].[Pedidocab]  WITH CHECK ADD  CONSTRAINT [FK_Pedidocab_Clientes] FOREIGN KEY([ID_clientes])
REFERENCES [dbo].[Clientes] ([ID_clientes])
GO
ALTER TABLE [dbo].[Pedidocab] CHECK CONSTRAINT [FK_Pedidocab_Clientes]
GO
ALTER TABLE [dbo].[Pedidosdet]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Clientes] FOREIGN KEY([ID_clientes])
REFERENCES [dbo].[Clientes] ([ID_clientes])
GO
ALTER TABLE [dbo].[Pedidosdet] CHECK CONSTRAINT [FK_Pedidos_Clientes]
GO
ALTER TABLE [dbo].[Pedidosdet]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Stock] FOREIGN KEY([ID_producto])
REFERENCES [dbo].[Stock] ([ID_producto])
GO
ALTER TABLE [dbo].[Pedidosdet] CHECK CONSTRAINT [FK_Pedidos_Stock]
GO
ALTER TABLE [dbo].[Pedidosdet]  WITH CHECK ADD  CONSTRAINT [FK_Pedidosdet_Pedidocab] FOREIGN KEY([ID_pedido], [ID_clientes])
REFERENCES [dbo].[Pedidocab] ([ID_pedido], [ID_clientes])
GO
ALTER TABLE [dbo].[Pedidosdet] CHECK CONSTRAINT [FK_Pedidosdet_Pedidocab]
GO
ALTER TABLE [dbo].[Precios]  WITH CHECK ADD  CONSTRAINT [FK_Precios_Stock] FOREIGN KEY([ID_producto])
REFERENCES [dbo].[Stock] ([ID_producto])
GO
ALTER TABLE [dbo].[Precios] CHECK CONSTRAINT [FK_Precios_Stock]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Etiqueta] FOREIGN KEY([Id_Etiqueta])
REFERENCES [dbo].[Etiqueta] ([Id_Etiqueta])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Etiqueta]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([Id_Idioma])
REFERENCES [dbo].[Idioma] ([Id_Idioma])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
ALTER TABLE [dbo].[Usuario_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Patente_Patente] FOREIGN KEY([IdPat])
REFERENCES [dbo].[Patente] ([IdPat])
GO
ALTER TABLE [dbo].[Usuario_Patente] CHECK CONSTRAINT [FK_Usuario_Patente_Patente]
GO
/****** Object:  StoredProcedure [dbo].[altacliente]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[altacliente]
@nombre nvarchar(50), @direccion nvarchar(50), @telefono int
as
begin
declare @idcl int
set @idcl =(Select MAX (ID_clientes) FROM Clientes)+1
	
	if @idcl is null
		select @idcl=1
Insert into Clientes
values (@idcl,@nombre,@direccion,@telefono)
end
GO
/****** Object:  StoredProcedure [dbo].[altaprecio]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[altaprecio]
@ID_producto int, @detalles nvarchar,@precio decimal, @medidas decimal, @tipo nvarchar(50)
as
begin
insert into Precios (ID_producto, detalles, precio, medidas,Tipo)
values(@ID_producto,@detalles,@precio,@medidas,@tipo)
end


GO
/****** Object:  StoredProcedure [dbo].[altaproducto]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[altaproducto]
@medidas decimal, @cantidad int, @tipo nvarchar(50)
as
begin
declare @idprod int
set @idprod =(Select MAX (ID_producto) FROM Stock)+1
	
	if @idprod is null
		select @idprod=1
insert into Stock (ID_producto, medidas, cantidad,Tipo)
values( @idprod,@medidas,@cantidad,@tipo)
end
GO
/****** Object:  StoredProcedure [dbo].[Altausuario2]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Altausuario2]
@Ididioma int, @Usunom nvarchar(50), @Usunick nvarchar(50), @Usupass nvarchar(50), @Usumail nvarchar(50), @Usuestado bit, @UsubajaL bit, @UsuDVH int
as
begin
declare @Usuid int
SET @Usuid = (SELECT MAX(Idusu) FROM Usuarios)+1

    if @Usuid is null
        select @Usuid = 1

insert into Usuarios
Values(@Ididioma,@Usunom,@Usunick,@Usupass, @Usumail,@Usuestado, @UsubajaL,@UsuDVH)
end
GO
/****** Object:  StoredProcedure [dbo].[Bajaclientes]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Bajaclientes]
@ID_clientes int
as
begin
delete from Clientes
where	 ID_clientes=@ID_clientes
end

GO
/****** Object:  StoredProcedure [dbo].[bajaprecio]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[bajaprecio]
@ID_producto int
as
begin
delete
from Precios
where ID_producto=@ID_producto
end
GO
/****** Object:  StoredProcedure [dbo].[bajaproducto]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[bajaproducto]
@ID_producto int
as
begin
delete from Stock
where ID_producto=@ID_producto
end
GO
/****** Object:  StoredProcedure [dbo].[cargarcabecera]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargarcabecera]
@Idcliente int, @estado int, @fechagen datetime, @fechaact datetime, @returnvalue int OUTPUT
as
begin
declare @Idpedido int
set @Idpedido =(select MAx(ID_pedido)from Pedidocab)+1
	if @Idpedido is null
		select @Idpedido=1
insert into Pedidocab
values (@Idpedido, @Idcliente, @estado , @fechagen , @fechaact) 
select @returnvalue=@Idpedido 
end
GO
/****** Object:  StoredProcedure [dbo].[cargardetalle]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargardetalle]
@Idpedido int, @Idcliente int, @idproducto int, @cantidad int, @costo decimal(18,2)
as
begin
insert into Pedidosdet
values (@Idpedido, @Idcliente, @idproducto , @cantidad , @costo )
end


GO
/****** Object:  StoredProcedure [dbo].[Change_Password]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Change_Password]
@user nvarchar(50)
as
begin
select Usupass from Usuarios
where Usunom = @user
end


GO
/****** Object:  StoredProcedure [dbo].[Editar_Traduccion]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Editar_Traduccion]
@Nombre nvarchar(50),@id int,@Trad nvarchar(50)
as
begin
UPDATE Traduccion
SET Traduccion.Traduccion = @Trad
FROM Traduccion t
INNER JOIN Idioma id
on t.Id_Idioma = id.Id_Idioma
where id.Nombre = @Nombre and Id_Etiqueta=@id 
end


GO
/****** Object:  StoredProcedure [dbo].[Editarcliente]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Editarcliente]
@ID_cliente int, @nombre nvarchar(50), @direccion nvarchar(50), @telefono int
as
begin
update Clientes set nombre=@nombre, direccion=@direccion, telefono=@telefono
where ID_clientes=@ID_cliente
end

GO
/****** Object:  StoredProcedure [dbo].[Editarprecio]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Editarprecio]
@ID_producto int, @detalles nvarchar, @precio decimal, @medidas decimal,@tipo nvarchar(50)
as
begin
update Precios set detalles=@detalles, precio=@precio, medidas= @medidas, Tipo=@tipo
where ID_producto=@ID_producto
end

GO
/****** Object:  StoredProcedure [dbo].[Editarproducto]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Editarproducto]
@IDprod int, @medidas decimal, @cantidad int, @tipo nvarchar(50)
as
begin
update Stock set  medidas=@medidas, cantidad=@cantidad, tipo=@tipo
where ID_producto=@IDprod
end

GO
/****** Object:  StoredProcedure [dbo].[iner]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[iner]
as
begin
select t1.Idpat, t1.Patnom, t2.id_patente_hijo from Patente t1 inner join Patente_patente t2 on t1.IdPat=t2.id_patente_padre

end
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Etiquetas]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_Etiquetas]
@idI int,@idE int,@T nvarchar(50)
as
begin
insert into Traduccion
values (@idI,@idE,@T)
end


GO
/****** Object:  StoredProcedure [dbo].[Insertar_Idioma]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_Idioma]
@nombre nvarchar(50),@default bit
as
begin
declare @UId int
SET @UId = (SELECT MAX(Id_Idioma) FROM Idioma)+1

    if @UId is null
        select @UId = 1
insert into Idioma
values(@UId,@nombre,@default)
end


GO
/****** Object:  StoredProcedure [dbo].[InsertarBitacora]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarBitacora]
@NickUsuario nvarchar(50),@Fecha datetime,@Descripcion nvarchar(50),@Criticidad nvarchar(50)
as
begin
insert into Bitacora (NickUsuario,Fecha,Descripcion,Criticidad)
values (@NickUsuario,@Fecha,@Descripcion,@Criticidad)
END

GO
/****** Object:  StoredProcedure [dbo].[Listadeusuarios]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Listadeusuarios]
as
begin
select Idusu,IdIdioma,UsuNom,UsuNick,Usupass,UsuMail,UsuEstado from Usuarios 
end


GO
/****** Object:  StoredProcedure [dbo].[ListarBitacora]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListarBitacora]
as
begin
select NickUsuario,Fecha,Descripcion,Criticidad from Bitacora
end

GO
/****** Object:  StoredProcedure [dbo].[listarcabecera]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listarcabecera]
as
begin
select*
from Pedidocab
end
GO
/****** Object:  StoredProcedure [dbo].[Listarclientes]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Listarclientes]
as
begin
select*
from Clientes
end

GO
/****** Object:  StoredProcedure [dbo].[listardetalles]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[listardetalles]
as
begin
select*
from Pedidosdet
end
GO
/****** Object:  StoredProcedure [dbo].[listarID_TIPO]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[listarID_TIPO]
as
begin
select ID_producto
from Stock
end
GO
/****** Object:  StoredProcedure [dbo].[listarprecios]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listarprecios]
as
begin
select*
from Precios
end
GO
/****** Object:  StoredProcedure [dbo].[Listarprod]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Listarprod]
as
begin
select*
from Stock
end

GO
/****** Object:  StoredProcedure [dbo].[ListarUsuarios]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ListarUsuarios]
as
begin
select Idusu,UsuNom,UsuNick,UsuMail,UsuEstado,Usubajal,UsuDVH from Usuarios 
end


GO
/****** Object:  StoredProcedure [dbo].[llenartabla]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[llenartabla]
as
begin
insert into Precios(ID_producto,medidas,tipo)
select a.ID_producto,a.medidas,a.Tipo
from Stock a
left join Precios b
on a.ID_producto=b.ID_producto
where b.ID_producto is null
end

GO
/****** Object:  StoredProcedure [dbo].[modificarcabecera]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificarcabecera]
@Idpedido int, @Idcliente int, @estado int, @fechagen datetime, @fechaact datetime
as
begin
update Pedidocab set  ID_clientes= @Idcliente, estado=@estado , fechagen=@fechagen , fechaact=@fechaact
where ID_pedido=@Idpedido
end
GO
/****** Object:  StoredProcedure [dbo].[modificarestado]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[modificarestado]
@Idpedido int, @estado int,@fechacam datetime
AS
BEGIN
UPDATE	Pedidocab set estado=@estado, fechaact=@fechacam
where Id_pedido=@Idpedido
END

GO
/****** Object:  StoredProcedure [dbo].[ObtenerIdTraduccion]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ObtenerIdTraduccion]
@nombre nvarchar(50)
as
select Id_Etiqueta from Etiqueta
where Nombre=@nombre


GO
/****** Object:  StoredProcedure [dbo].[Search_User]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Search_User]
@usu varchar(50)
as
select IdUsu,UsuNick,UsuPass from Usuarios where UsuNick=@usu 


GO
/****** Object:  StoredProcedure [dbo].[update_password]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_password]
@user nvarchar(50),@pass nvarchar(50)
as
begin
UPDATE Usuarios
SET Usupass = @pass
where Usunom=@user
end
GO
/****** Object:  StoredProcedure [dbo].[updatea0]    Script Date: 11/07/2023 18:46:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updatea0]
as
begin
update Precios Set precio=0.0
where precio is null	
end
GO
USE [master]
GO
ALTER DATABASE [TPMODELOS] SET  READ_WRITE 
GO
