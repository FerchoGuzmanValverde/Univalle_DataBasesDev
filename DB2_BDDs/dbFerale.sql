-- FERNANDO GUZMAN VALVERDE
-- DORA SOLARES ALARCON

USE [master]
GO
/****** Object:  Database [dbFerale]    Script Date: 04/04/2019 14:37:26 ******/
CREATE DATABASE [dbFerale]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbFerale', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbFerale.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbFerale_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbFerale_log.ldf' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbFerale] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbFerale].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbFerale] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbFerale] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbFerale] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbFerale] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbFerale] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbFerale] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbFerale] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbFerale] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbFerale] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbFerale] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbFerale] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbFerale] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbFerale] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbFerale] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbFerale] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbFerale] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbFerale] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbFerale] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbFerale] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbFerale] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbFerale] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbFerale] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbFerale] SET RECOVERY FULL 
GO
ALTER DATABASE [dbFerale] SET  MULTI_USER 
GO
ALTER DATABASE [dbFerale] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbFerale] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbFerale] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbFerale] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbFerale] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbFerale', N'ON'
GO
USE [dbFerale]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Administrador](
	[idAdministrador] [int] NOT NULL,
	[profesion] [varchar](80) NOT NULL,
	[cargo] [varchar](80) NOT NULL,
 CONSTRAINT [PK_Administrador] PRIMARY KEY CLUSTERED 
(
	[idAdministrador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AreaTrabajo]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AreaTrabajo](
	[idEmpleado] [int] NOT NULL,
	[idSeccion] [tinyint] NOT NULL,
 CONSTRAINT [PK_AreaTrabajo] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC,
	[idSeccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Capacitacion]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Capacitacion](
	[idCapacitacion] [smallint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](120) NOT NULL,
	[archivoDetalle] [varbinary](max) NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Capacitacion] PRIMARY KEY CLUSTERED 
(
	[idCapacitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CapacitacionCapacitador]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CapacitacionCapacitador](
	[idCapacitacion] [smallint] NOT NULL,
	[idCapacitador] [smallint] NOT NULL,
	[temaExpuesto] [varchar](80) NOT NULL,
 CONSTRAINT [PK_CapacitacionCapacitador] PRIMARY KEY CLUSTERED 
(
	[idCapacitacion] ASC,
	[idCapacitador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Capacitador]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Capacitador](
	[idCapacitador] [smallint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[primerApellido] [varchar](60) NOT NULL,
	[segundoApellido] [varchar](60) NULL,
	[profesion] [varchar](50) NOT NULL,
	[nroCapacitaciones] [tinyint] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Capacitador] PRIMARY KEY CLUSTERED 
(
	[idCapacitador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Certificados]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Certificados](
	[idCertificados] [smallint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](80) NOT NULL,
	[archivo] [varbinary](max) NOT NULL,
	[idCapacitador] [smallint] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Certificados] PRIMARY KEY CLUSTERED 
(
	[idCertificados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciudad](
	[idCiudad] [int] IDENTITY(1,1) NOT NULL,
	[nombreCiudad] [varchar](80) NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
	[idPais] [tinyint] NOT NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[idCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] NOT NULL,
	[tipoCliente] [tinyint] NOT NULL,
	[razonSocial] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Consulta]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consulta](
	[idEmpleado] [int] NOT NULL,
	[idDocumento] [smallint] NOT NULL,
	[fechaHoraConsulta] [datetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ControlPlaga]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlPlaga](
	[idPlaga] [tinyint] NOT NULL,
	[idPlaguicida] [tinyint] NOT NULL,
 CONSTRAINT [PK_ControlPlaga] PRIMARY KEY CLUSTERED 
(
	[idPlaga] ASC,
	[idPlaguicida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[idVenta] [int] NOT NULL,
	[idProducto] [tinyint] NOT NULL,
	[cantidad] [smallint] NOT NULL,
	[precioUnitario] [money] NOT NULL,
 CONSTRAINT [PK_ProductoVenta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC,
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Documento]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Documento](
	[idDocumento] [smallint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](80) NOT NULL,
	[archivoDocumento] [varbinary](max) NOT NULL,
	[fechaExpiracion] [date] NOT NULL,
	[tipoDocumento] [tinyint] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Documento] PRIMARY KEY CLUSTERED 
(
	[idDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Domicilio]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Domicilio](
	[idDomicilio] [int] IDENTITY(1,1) NOT NULL,
	[longitudLatitud] [geography] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Domicilio] PRIMARY KEY CLUSTERED 
(
	[idDomicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[sexo] [tinyint] NOT NULL,
	[nroCuentaBancaria] [varchar](20) NOT NULL,
	[tipoEmpleado] [tinyint] NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpleadoCapacitacion]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpleadoCapacitacion](
	[idEmpleado] [int] NOT NULL,
	[idCapacitacion] [smallint] NOT NULL,
	[fechaHoraInicio] [datetime] NOT NULL,
	[fechaHoraFin] [datetime] NOT NULL,
 CONSTRAINT [PK_EmpleadoCapacitacion] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC,
	[idCapacitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fruta]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fruta](
	[idFruta] [tinyint] NOT NULL,
	[peso] [decimal](5, 2) NOT NULL,
	[tipoEnvase] [text] NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
 CONSTRAINT [PK_Fruta] PRIMARY KEY CLUSTERED 
(
	[idFruta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gasto]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gasto](
	[idGasto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[proveedor] [varchar](80) NOT NULL,
	[tipoGasto] [tinyint] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
	[idTramite] [smallint] NOT NULL,
 CONSTRAINT [PK_Gasto] PRIMARY KEY CLUSTERED 
(
	[idGasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Limpieza]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Limpieza](
	[idLimpieza] [tinyint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
	[tipoLimpieza] [tinyint] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Limpieza] PRIMARY KEY CLUSTERED 
(
	[idLimpieza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LimpiezaPlaga]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LimpiezaPlaga](
	[idPlaguicida] [tinyint] NOT NULL,
	[idLimpieza] [tinyint] NOT NULL,
	[cantidad] [decimal](4, 2) NOT NULL,
 CONSTRAINT [PK_LimpiezaPlaga] PRIMARY KEY CLUSTERED 
(
	[idPlaguicida] ASC,
	[idLimpieza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pago]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[idAdministrador] [int] NOT NULL,
	[idGasto] [int] NOT NULL,
	[monto] [money] NOT NULL,
	[tipoPago] [tinyint] NOT NULL,
	[fechaHoraPago] [datetime] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Pago] PRIMARY KEY CLUSTERED 
(
	[idAdministrador] ASC,
	[idGasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pais]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pais](
	[idPais] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombrePais] [varchar](80) NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[idPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[idPedido] [int] IDENTITY(1,1) NOT NULL,
	[adelanto] [money] NOT NULL,
	[fechaEntrega] [date] NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[idPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persona]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[primerApellido] [varchar](60) NOT NULL,
	[segundoApellido] [varchar](60) NULL,
	[nroCelular] [varchar](15) NOT NULL,
	[cedulaIdentidad] [varchar](15) NOT NULL,
	[tipopersona] [tinyint] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
	[idProcedencia] [int] NULL,
	[idDomicilio] [int] NULL,
	[idUsuario] [int] NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Plaga]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plaga](
	[idPlaga] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombrePlaga] [varchar](100) NOT NULL,
	[tratamiento] [text] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Plaga] PRIMARY KEY CLUSTERED 
(
	[idPlaga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Plaguicida]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plaguicida](
	[idPlaguicida] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombrePlaguicida] [varchar](80) NOT NULL,
	[tipoPlaguicida] [tinyint] NOT NULL,
	[ingredienteActivo] [varchar](80) NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Plaguicida] PRIMARY KEY CLUSTERED 
(
	[idPlaguicida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Planta]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planta](
	[idPlanta] [tinyint] NOT NULL,
	[tipoBolsa] [tinyint] NOT NULL,
	[stock] [smallint] NOT NULL,
	[idVivero] [tinyint] NOT NULL,
 CONSTRAINT [PK_Planta] PRIMARY KEY CLUSTERED 
(
	[idPlanta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [tinyint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
	[precioBase] [money] NOT NULL,
	[variedad] [varchar](100) NOT NULL,
	[tipoProducto] [tinyint] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProveeFruta]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProveeFruta](
	[idAgricultor] [int] NOT NULL,
	[idFruta] [tinyint] NOT NULL,
	[cantidad] [smallint] NOT NULL,
	[precioKG] [money] NOT NULL,
	[fechaHora] [datetime] NOT NULL,
	[descripcionCalidad] [text] NOT NULL,
 CONSTRAINT [PK_ProveeFruta] PRIMARY KEY CLUSTERED 
(
	[idAgricultor] ASC,
	[idFruta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[idProvincia] [int] IDENTITY(1,1) NOT NULL,
	[nombreProvincia] [varchar](80) NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
	[idCiudad] [int] NOT NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[idProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RealizacionLimpieza]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RealizacionLimpieza](
	[idLimpieza] [tinyint] NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[fechaHoraInicio] [datetime] NOT NULL,
	[fechaHoraFin] [datetime] NOT NULL,
 CONSTRAINT [PK_RealizacionLimpieza] PRIMARY KEY CLUSTERED 
(
	[idLimpieza] ASC,
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Requerimiento]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requerimiento](
	[idTramite] [smallint] NOT NULL,
	[idDocumento] [smallint] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Seccion]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Seccion](
	[idSeccion] [tinyint] IDENTITY(1,1) NOT NULL,
	[nombreSeccion] [varchar](100) NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Seccion] PRIMARY KEY CLUSTERED 
(
	[idSeccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sueldo]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sueldo](
	[idEmpleado] [int] NOT NULL,
	[idAdministrador] [int] NOT NULL,
	[fechaHoraPago] [datetime] NOT NULL,
	[cantDiasTrabajados] [tinyint] NOT NULL,
	[montoDia] [money] NOT NULL,
 CONSTRAINT [PK_Sueldo] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC,
	[idAdministrador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Telefono]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefono](
	[idTelefono] [int] IDENTITY(1,1) NOT NULL,
	[nroTelefono] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Telefono] PRIMARY KEY CLUSTERED 
(
	[idTelefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tramite]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tramite](
	[idTramite] [smallint] NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaFin] [date] NOT NULL,
	[estadoTramite] [tinyint] NOT NULL,
	[idAdminnistrador] [int] NOT NULL,
 CONSTRAINT [PK_Tramite] PRIMARY KEY CLUSTERED 
(
	[idTramite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](15) NOT NULL,
	[password] [varchar](15) NOT NULL,
	[idPersona] [int] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[fechaHoraVenta] [datetime] NOT NULL,
	[montoTotal] [money] NOT NULL,
	[descuento] [tinyint] NOT NULL,
	[tipoVenta] [tinyint] NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
	[idCliente] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vivero]    Script Date: 04/04/2019 14:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vivero](
	[idVivero] [tinyint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[capacidad] [smallint] NOT NULL,
	[tipoVivero] [varchar](80) NOT NULL,
	[estado] [tinyint] NOT NULL,
	[fechaHoraActualizacion] [datetime] NOT NULL,
 CONSTRAINT [PK_Vivero] PRIMARY KEY CLUSTERED 
(
	[idVivero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Capacitacion] ADD  CONSTRAINT [DF_Capacitacion_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Capacitador] ADD  CONSTRAINT [DF_Capacitador_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Certificados] ADD  CONSTRAINT [DF_Certificados_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Ciudad] ADD  CONSTRAINT [DF_Ciudad_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Documento] ADD  CONSTRAINT [DF_Documento_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Domicilio] ADD  CONSTRAINT [DF_Domicilio_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Gasto] ADD  CONSTRAINT [DF_Gasto_fechaHoraModificado]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Limpieza] ADD  CONSTRAINT [DF_Limpieza_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Pago] ADD  CONSTRAINT [DF_Pago_fechaHoraPago]  DEFAULT (getdate()) FOR [fechaHoraPago]
GO
ALTER TABLE [dbo].[Pago] ADD  CONSTRAINT [DF_Pago_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Pais] ADD  CONSTRAINT [DF_Pais_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Pais] ADD  CONSTRAINT [DF_Pais_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Persona] ADD  CONSTRAINT [DF_Persona_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Persona] ADD  CONSTRAINT [DF_Persona_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Plaga] ADD  CONSTRAINT [DF_Plaga_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Producto] ADD  CONSTRAINT [DF_Producto_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Producto] ADD  CONSTRAINT [DF_Producto_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Provincia] ADD  CONSTRAINT [DF_Provincia_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Provincia] ADD  CONSTRAINT [DF_Provincia_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Seccion] ADD  CONSTRAINT [DF_Seccion_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Sueldo] ADD  CONSTRAINT [DF_Sueldo_fechaHoraPago]  DEFAULT (getdate()) FOR [fechaHoraPago]
GO
ALTER TABLE [dbo].[Telefono] ADD  CONSTRAINT [DF_Telefono_estado]  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Telefono] ADD  CONSTRAINT [DF_Telefono_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Ventas] ADD  CONSTRAINT [DF_Ventas_fechaHoraActualizacion]  DEFAULT (getdate()) FOR [fechaHoraActualizacion]
GO
ALTER TABLE [dbo].[Administrador]  WITH CHECK ADD  CONSTRAINT [FK_Administrador_Empleado] FOREIGN KEY([idAdministrador])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Administrador] CHECK CONSTRAINT [FK_Administrador_Empleado]
GO
ALTER TABLE [dbo].[AreaTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_AreaTrabajo_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[AreaTrabajo] CHECK CONSTRAINT [FK_AreaTrabajo_Empleado]
GO
ALTER TABLE [dbo].[AreaTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_AreaTrabajo_Seccion] FOREIGN KEY([idSeccion])
REFERENCES [dbo].[Seccion] ([idSeccion])
GO
ALTER TABLE [dbo].[AreaTrabajo] CHECK CONSTRAINT [FK_AreaTrabajo_Seccion]
GO
ALTER TABLE [dbo].[CapacitacionCapacitador]  WITH CHECK ADD  CONSTRAINT [FK_CapacitacionCapacitador_Capacitacion] FOREIGN KEY([idCapacitacion])
REFERENCES [dbo].[Capacitacion] ([idCapacitacion])
GO
ALTER TABLE [dbo].[CapacitacionCapacitador] CHECK CONSTRAINT [FK_CapacitacionCapacitador_Capacitacion]
GO
ALTER TABLE [dbo].[CapacitacionCapacitador]  WITH CHECK ADD  CONSTRAINT [FK_CapacitacionCapacitador_Capacitador] FOREIGN KEY([idCapacitador])
REFERENCES [dbo].[Capacitador] ([idCapacitador])
GO
ALTER TABLE [dbo].[CapacitacionCapacitador] CHECK CONSTRAINT [FK_CapacitacionCapacitador_Capacitador]
GO
ALTER TABLE [dbo].[Certificados]  WITH CHECK ADD  CONSTRAINT [FK_Certificados_Capacitador] FOREIGN KEY([idCapacitador])
REFERENCES [dbo].[Capacitador] ([idCapacitador])
GO
ALTER TABLE [dbo].[Certificados] CHECK CONSTRAINT [FK_Certificados_Capacitador]
GO
ALTER TABLE [dbo].[Ciudad]  WITH CHECK ADD  CONSTRAINT [FK_Ciudad_Pais] FOREIGN KEY([idPais])
REFERENCES [dbo].[Pais] ([idPais])
GO
ALTER TABLE [dbo].[Ciudad] CHECK CONSTRAINT [FK_Ciudad_Pais]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Persona] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Persona]
GO
ALTER TABLE [dbo].[Consulta]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Documento] FOREIGN KEY([idDocumento])
REFERENCES [dbo].[Documento] ([idDocumento])
GO
ALTER TABLE [dbo].[Consulta] CHECK CONSTRAINT [FK_Consulta_Documento]
GO
ALTER TABLE [dbo].[Consulta]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Consulta] CHECK CONSTRAINT [FK_Consulta_Empleado]
GO
ALTER TABLE [dbo].[ControlPlaga]  WITH CHECK ADD  CONSTRAINT [FK_ControlPlaga_Plaga] FOREIGN KEY([idPlaga])
REFERENCES [dbo].[Plaga] ([idPlaga])
GO
ALTER TABLE [dbo].[ControlPlaga] CHECK CONSTRAINT [FK_ControlPlaga_Plaga]
GO
ALTER TABLE [dbo].[ControlPlaga]  WITH CHECK ADD  CONSTRAINT [FK_ControlPlaga_Plaguicida] FOREIGN KEY([idPlaguicida])
REFERENCES [dbo].[Plaguicida] ([idPlaguicida])
GO
ALTER TABLE [dbo].[ControlPlaga] CHECK CONSTRAINT [FK_ControlPlaga_Plaguicida]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_ProductoVenta_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_ProductoVenta_Producto]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_ProductoVenta_Ventas] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Ventas] ([idVenta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_ProductoVenta_Ventas]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Persona] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Persona]
GO
ALTER TABLE [dbo].[EmpleadoCapacitacion]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoCapacitacion_Capacitacion] FOREIGN KEY([idCapacitacion])
REFERENCES [dbo].[Capacitacion] ([idCapacitacion])
GO
ALTER TABLE [dbo].[EmpleadoCapacitacion] CHECK CONSTRAINT [FK_EmpleadoCapacitacion_Capacitacion]
GO
ALTER TABLE [dbo].[EmpleadoCapacitacion]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoCapacitacion_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[EmpleadoCapacitacion] CHECK CONSTRAINT [FK_EmpleadoCapacitacion_Empleado]
GO
ALTER TABLE [dbo].[Fruta]  WITH CHECK ADD  CONSTRAINT [FK_Fruta_Producto] FOREIGN KEY([idFruta])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[Fruta] CHECK CONSTRAINT [FK_Fruta_Producto]
GO
ALTER TABLE [dbo].[Gasto]  WITH CHECK ADD  CONSTRAINT [FK_Gasto_Tramite] FOREIGN KEY([idTramite])
REFERENCES [dbo].[Tramite] ([idTramite])
GO
ALTER TABLE [dbo].[Gasto] CHECK CONSTRAINT [FK_Gasto_Tramite]
GO
ALTER TABLE [dbo].[LimpiezaPlaga]  WITH CHECK ADD  CONSTRAINT [FK_LimpiezaPlaga_Limpieza] FOREIGN KEY([idLimpieza])
REFERENCES [dbo].[Limpieza] ([idLimpieza])
GO
ALTER TABLE [dbo].[LimpiezaPlaga] CHECK CONSTRAINT [FK_LimpiezaPlaga_Limpieza]
GO
ALTER TABLE [dbo].[LimpiezaPlaga]  WITH CHECK ADD  CONSTRAINT [FK_LimpiezaPlaga_Plaguicida] FOREIGN KEY([idPlaguicida])
REFERENCES [dbo].[Plaguicida] ([idPlaguicida])
GO
ALTER TABLE [dbo].[LimpiezaPlaga] CHECK CONSTRAINT [FK_LimpiezaPlaga_Plaguicida]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Administrador1] FOREIGN KEY([idAdministrador])
REFERENCES [dbo].[Administrador] ([idAdministrador])
GO
ALTER TABLE [dbo].[Pago] CHECK CONSTRAINT [FK_Pago_Administrador1]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD  CONSTRAINT [FK_Pago_Gasto1] FOREIGN KEY([idGasto])
REFERENCES [dbo].[Gasto] ([idGasto])
GO
ALTER TABLE [dbo].[Pago] CHECK CONSTRAINT [FK_Pago_Gasto1]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Ventas] FOREIGN KEY([idPedido])
REFERENCES [dbo].[Ventas] ([idVenta])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Ventas]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_Domicilio] FOREIGN KEY([idDomicilio])
REFERENCES [dbo].[Domicilio] ([idDomicilio])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_Domicilio]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_Provincia] FOREIGN KEY([idProcedencia])
REFERENCES [dbo].[Provincia] ([idProvincia])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_Provincia]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_Usuario]
GO
ALTER TABLE [dbo].[Planta]  WITH CHECK ADD  CONSTRAINT [FK_Planta_Producto] FOREIGN KEY([idPlanta])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[Planta] CHECK CONSTRAINT [FK_Planta_Producto]
GO
ALTER TABLE [dbo].[Planta]  WITH CHECK ADD  CONSTRAINT [FK_Planta_Vivero] FOREIGN KEY([idVivero])
REFERENCES [dbo].[Vivero] ([idVivero])
GO
ALTER TABLE [dbo].[Planta] CHECK CONSTRAINT [FK_Planta_Vivero]
GO
ALTER TABLE [dbo].[ProveeFruta]  WITH CHECK ADD  CONSTRAINT [FK_ProveeFruta_Fruta] FOREIGN KEY([idFruta])
REFERENCES [dbo].[Fruta] ([idFruta])
GO
ALTER TABLE [dbo].[ProveeFruta] CHECK CONSTRAINT [FK_ProveeFruta_Fruta]
GO
ALTER TABLE [dbo].[ProveeFruta]  WITH CHECK ADD  CONSTRAINT [FK_ProveeFruta_Persona] FOREIGN KEY([idAgricultor])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[ProveeFruta] CHECK CONSTRAINT [FK_ProveeFruta_Persona]
GO
ALTER TABLE [dbo].[Provincia]  WITH CHECK ADD  CONSTRAINT [FK_Provincia_Ciudad] FOREIGN KEY([idCiudad])
REFERENCES [dbo].[Ciudad] ([idCiudad])
GO
ALTER TABLE [dbo].[Provincia] CHECK CONSTRAINT [FK_Provincia_Ciudad]
GO
ALTER TABLE [dbo].[RealizacionLimpieza]  WITH CHECK ADD  CONSTRAINT [FK_RealizacionLimpieza_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[RealizacionLimpieza] CHECK CONSTRAINT [FK_RealizacionLimpieza_Empleado]
GO
ALTER TABLE [dbo].[RealizacionLimpieza]  WITH CHECK ADD  CONSTRAINT [FK_RealizacionLimpieza_Limpieza] FOREIGN KEY([idLimpieza])
REFERENCES [dbo].[Limpieza] ([idLimpieza])
GO
ALTER TABLE [dbo].[RealizacionLimpieza] CHECK CONSTRAINT [FK_RealizacionLimpieza_Limpieza]
GO
ALTER TABLE [dbo].[Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_Requerimiento_Documento] FOREIGN KEY([idDocumento])
REFERENCES [dbo].[Documento] ([idDocumento])
GO
ALTER TABLE [dbo].[Requerimiento] CHECK CONSTRAINT [FK_Requerimiento_Documento]
GO
ALTER TABLE [dbo].[Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_Requerimiento_Tramite] FOREIGN KEY([idTramite])
REFERENCES [dbo].[Tramite] ([idTramite])
GO
ALTER TABLE [dbo].[Requerimiento] CHECK CONSTRAINT [FK_Requerimiento_Tramite]
GO
ALTER TABLE [dbo].[Sueldo]  WITH CHECK ADD  CONSTRAINT [FK_Sueldo_Administrador] FOREIGN KEY([idAdministrador])
REFERENCES [dbo].[Administrador] ([idAdministrador])
GO
ALTER TABLE [dbo].[Sueldo] CHECK CONSTRAINT [FK_Sueldo_Administrador]
GO
ALTER TABLE [dbo].[Sueldo]  WITH CHECK ADD  CONSTRAINT [FK_Sueldo_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Sueldo] CHECK CONSTRAINT [FK_Sueldo_Empleado]
GO
ALTER TABLE [dbo].[Telefono]  WITH CHECK ADD  CONSTRAINT [FK_Telefono_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Telefono] CHECK CONSTRAINT [FK_Telefono_Persona]
GO
ALTER TABLE [dbo].[Tramite]  WITH CHECK ADD  CONSTRAINT [FK_Tramite_Administrador] FOREIGN KEY([idAdminnistrador])
REFERENCES [dbo].[Administrador] ([idAdministrador])
GO
ALTER TABLE [dbo].[Tramite] CHECK CONSTRAINT [FK_Tramite_Administrador]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Persona]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Cliente]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Empleado]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = concluida
1 = cancelada' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Capacitacion', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Capacitador', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Certificados', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 inactivo 1 activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ciudad', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 nacional
1 internacional' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cliente', @level2type=N'COLUMN',@level2name=N'tipoCliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = protocolo
1 = manual
2 = permisos
3 = certificado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Documento', @level2type=N'COLUMN',@level2name=N'tipoDocumento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Documento', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Domicilio', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 masculino
1 femenino
2 indefinido' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Empleado', @level2type=N'COLUMN',@level2name=N'sexo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = administrador
1 = encargaado
2 = operador' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Empleado', @level2type=N'COLUMN',@level2name=N'tipoEmpleado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = servicio
1 = material 
2 = tramite' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Gasto', @level2type=N'COLUMN',@level2name=N'tipoGasto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = desembolsado
1 = pendiente
2 = cancelado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Gasto', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = rutinaria
1 = irregular' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Limpieza', @level2type=N'COLUMN',@level2name=N'tipoLimpieza'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactiva
1 = activa
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Limpieza', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = efectivo
1 = transferencia' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pago', @level2type=N'COLUMN',@level2name=N'tipoPago'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = activo
1 = inactivo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pago', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 inactivo 1 activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pais', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 cliente
1 empleado
2 agricultor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'tipopersona'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 inactivo
1 activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Persona', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Plaga', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = pesticida
1 = insecticida
2 = otro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Plaguicida', @level2type=N'COLUMN',@level2name=N'tipoPlaguicida'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Plaguicida', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = normal
1 = de jardin' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Planta', @level2type=N'COLUMN',@level2name=N'tipoBolsa'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = frutas
1 = plantas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Producto', @level2type=N'COLUMN',@level2name=N'tipoProducto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = descontinuado
1 = activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Producto', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 inactivo 1 activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Provincia', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Seccion', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N' 0 inactivo  1 activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Telefono', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = completado
1 = en preceso
2 = sin iniciar o cancelado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Tramite', @level2type=N'COLUMN',@level2name=N'estadoTramite'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuario', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'en porcentajes
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ventas', @level2type=N'COLUMN',@level2name=N'descuento'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Ventas', @level2type=N'COLUMN',@level2name=N'estado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = inactivo
1 = activo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Vivero', @level2type=N'COLUMN',@level2name=N'estado'
GO
USE [master]
GO
ALTER DATABASE [dbFerale] SET  READ_WRITE 
GO
