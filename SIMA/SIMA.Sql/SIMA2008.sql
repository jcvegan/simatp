USE [master]
GO
/****** Object:  Database [SIMA]    Script Date: 11/07/2010 10:40:07 ******/
CREATE DATABASE [SIMA]
GO
ALTER DATABASE [SIMA] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SIMA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SIMA] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SIMA] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SIMA] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SIMA] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SIMA] SET ARITHABORT OFF
GO
ALTER DATABASE [SIMA] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SIMA] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SIMA] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SIMA] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SIMA] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SIMA] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SIMA] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SIMA] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SIMA] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SIMA] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SIMA] SET  ENABLE_BROKER
GO
ALTER DATABASE [SIMA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SIMA] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SIMA] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SIMA] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SIMA] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SIMA] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SIMA] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SIMA] SET  READ_WRITE
GO
ALTER DATABASE [SIMA] SET RECOVERY FULL
GO
ALTER DATABASE [SIMA] SET  MULTI_USER
GO
ALTER DATABASE [SIMA] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SIMA] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'SIMA', N'ON'
GO
USE [SIMA]
GO
/****** Object:  Table [dbo].[T_C_Tabla]    Script Date: 11/07/2010 10:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Tabla](
	[Id_Tabla] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Tabla] [varchar](255) NOT NULL,
	[Descripcion_Tabla] [varchar](255) NOT NULL,
 CONSTRAINT [PK_T_C_Tabla309] PRIMARY KEY CLUSTERED 
(
	[Id_Tabla] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_C_Tabla] ON
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (1, N'T_C_Perfil', N'Tabla de perfiles.')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (2, N'T_C_Alerta', N'Tabla de Alertas del sistema')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (3, N'T_C_Area', N'Tabla de Áreas de los equipos')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (4, N'T_C_DetalleOrdenDeTrabajo', N'Tabla del Detalle de la Orden de Trabajo')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (5, N'T_C_DetalleSolicitud', N'Tabla del Detalle de la Solicitud')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (6, N'T_C_Equipo', N'Tabla de los equipos')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (7, N'T_C_Estado', N'Tabla de los estados de las tablas')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (8, N'T_C_Incidencia', N'Tabla de las incidencias ocurridas día a día')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (9, N'T_C_Mantenimiento', N'Tabla de los mantenimientos programados')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (10, N'T_C_Marca', N'Tabla de las marcas de los equipos')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (11, N'T_C_Modelo', N'Tabla de los modelos de los equipos')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (12, N'T_C_MovimientosEquipo', N'Tabla de movimientos de los equipos')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (13, N'T_C_OrdenTrabajo', N'Tabla de Ordenes de Trabajo')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (14, N'T_C_Pedido', N'Tabla de Pedidos de mantenimiento')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (15, N'T_C_Permiso', N'Tabla de Permisos del sistema')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (16, N'T_C_PermisosXPerfil', N'Tabla de Permisos del sistema según perfil asignado')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (17, N'T_C_Producto', N'Tabla de productos')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (18, N'T_C_Requerimiento', N'Tabla de requerimientos de equipo para un producto')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (19, N'T_C_Solicitud', N'Tabla de solicitud de trabajo')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (20, N'T_C_Tabla', N'Tabla de tablas del sistema')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (21, N'T_C_TipoMantenimiento', N'Tabla de tipos de mantenimientos de equipos')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (22, N'T_C_TipoMantenimientoPorEquipo', N'Tabla de tipos de mantenimientos de cada equipo')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (23, N'T_C_Trabajo', N'Tabla de trabajo de equipos')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (24, N'T_C_TurnoMantenimiento', N'Tabla de turnos de trabajo para hacer mantenimiento')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (25, N'T_C_TurnoTrabajador', N'Tabla de turnos de trabajo para hacer mantenimiento por trabajador')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (26, N'T_C_Usuario', N'Tabla de usuarios del sistema')
SET IDENTITY_INSERT [dbo].[T_C_Tabla] OFF
/****** Object:  StoredProcedure [dbo].[T_C_TablaUpdate]    Script Date: 11/07/2010 10:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TablaUpdate]
(
	@Id_Tabla int,
	@Nombre_Tabla varchar(255),
	@Descripcion_Tabla varchar(255)
)

AS

SET NOCOUNT ON

UPDATE [T_C_Tabla]
SET [Nombre_Tabla] = @Nombre_Tabla,
	[Descripcion_Tabla] = @Descripcion_Tabla
	
WHERE [Id_Tabla] = @Id_Tabla
GO
/****** Object:  StoredProcedure [dbo].[T_C_TablaSelectAll]    Script Date: 11/07/2010 10:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TablaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Tabla],
	[Nombre_Tabla],
	[Descripcion_Tabla]
FROM [T_C_Tabla]
GO
/****** Object:  StoredProcedure [dbo].[T_C_TablaSelect]    Script Date: 11/07/2010 10:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[T_C_TablaSelect]
(
	@IdTabla int
)


AS

SET NOCOUNT ON

SELECT [Id_Tabla],
	[Nombre_Tabla],
	[Descripcion_Tabla]
FROM [T_C_Tabla]
WHERE Id_Tabla = @IdTabla
GO
/****** Object:  StoredProcedure [dbo].[T_C_TablaInsert]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TablaInsert]
(
	@Nombre_Tabla varchar(255),
	@Descripcion_Tabla varchar(255)
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Tabla]
(
	[Nombre_Tabla],
	[Descripcion_Tabla]
)
VALUES
(
	@Nombre_Tabla,
	@Descripcion_Tabla
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_TablaDelete]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TablaDelete]
(
	@Id_Tabla int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Tabla]
WHERE [Id_Tabla] = @Id_Tabla
GO
/****** Object:  Table [dbo].[T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Estado](
	[Id_Estado] [int] IDENTITY(1,1) NOT NULL,
	[Id_Tabla] [int] NOT NULL,
	[Nombre_Estado] [varchar](255) NOT NULL,
	[Descripcion_Estado] [varchar](255) NOT NULL,
	[Por_Defecto] [bit] NOT NULL,
	[Muestra_Informacion] [bit] NULL,
 CONSTRAINT [PK_T_C_Estado] PRIMARY KEY CLUSTERED 
(
	[Id_Estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_C_Estado] ON
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion]) VALUES (1, 1, N'Activo', N'Perfil en uso', 1, 1)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion]) VALUES (2, 1, N'Inactivo', N'Perfil en desuso', 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion]) VALUES (3, 3, N'Activo', N'Área en uso.', 1, 1)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion]) VALUES (4, 3, N'Inactivo', N'Área en desuso.', 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion]) VALUES (5, 26, N'Activo', N'Usuario habilitado.', 1, 1)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion]) VALUES (6, 26, N'Inactivo', N'Usuario inhabilitado', 1, 1)
SET IDENTITY_INSERT [dbo].[T_C_Estado] OFF
/****** Object:  Table [dbo].[T_C_Marca]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Marca](
	[Id_Marca] [int] NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Marca293] PRIMARY KEY CLUSTERED 
(
	[Id_Marca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_Incidencia]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Incidencia](
	[Id_Incidencia] [int] NOT NULL,
	[Usuario_Responsable] [varchar](255) NOT NULL,
	[Usuario_Registro] [varchar](255) NOT NULL,
	[Fecha_Incidencia] [datetime] NOT NULL,
	[Fecha_Reporte] [datetime] NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Incidencia301] PRIMARY KEY CLUSTERED 
(
	[Id_Incidencia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[T_C_EstadoSelectAll]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EstadoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Estado],
	[Id_Tabla],
	[Nombre_Estado],
	[Descripcion_Estado],
	[Por_Defecto],
	[Muestra_Informacion]
FROM [T_C_Estado]
GO
/****** Object:  StoredProcedure [dbo].[T_C_EstadoInsert]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EstadoInsert]
(
	@Id_Tabla int,
	@Nombre_Estado varchar(255),
	@Descripcion_Estado varchar(255),
	@Por_Defecto bit,
	@Muestra_Informacion bit
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Estado]
(
	[Id_Tabla],
	[Nombre_Estado],
	[Descripcion_Estado],
	[Por_Defecto],
	[Muestra_Informacion]
)
VALUES
(
	@Id_Tabla,
	@Nombre_Estado,
	@Descripcion_Estado,
	@Por_Defecto,
	@Muestra_Informacion
)

SELECT SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[T_C_EstadoDelete]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EstadoDelete]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Estado]
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[spHelperAsignaEstado]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spHelperAsignaEstado](
 @NombreTabla varchar(255),
 @IdEstado int OUT
)
AS

SET @IdEstado =  (SELECT T_C_Estado.Id_Estado 
FROM            T_C_Estado INNER JOIN
                         T_C_Tabla ON T_C_Estado.Id_Tabla = T_C_Tabla.Id_Tabla
where T_C_Tabla.Nombre_Tabla=@NombreTabla AND T_C_Estado.Por_Defecto=1)
GO
/****** Object:  Table [dbo].[T_C_Area]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Area](
	[Id_Area] [char](2) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Area295] PRIMARY KEY CLUSTERED 
(
	[Id_Area] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_Perfil]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Perfil](
	[Id_Perfil] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Perfil291] PRIMARY KEY CLUSTERED 
(
	[Id_Perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_C_Perfil] ON
INSERT [dbo].[T_C_Perfil] ([Id_Perfil], [Nombre], [Descripcion], [Id_Estado]) VALUES (1, N'Perfil1', N'blablabla', 1)
INSERT [dbo].[T_C_Perfil] ([Id_Perfil], [Nombre], [Descripcion], [Id_Estado]) VALUES (2, N'Perfil2', N'blablabla', 1)
SET IDENTITY_INSERT [dbo].[T_C_Perfil] OFF
/****** Object:  Table [dbo].[T_C_Solicitud]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Solicitud](
	[Id_Solicitud] [int] NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[FechaSolicitud] [datetime] NOT NULL,
	[FechaRespuesta] [datetime] NOT NULL,
	[UsuarioRespuesta] [varchar](255) NOT NULL,
	[Id_OrdenTrabajo] [int] NOT NULL,
	[Motivo] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Solicitud290] PRIMARY KEY CLUSTERED 
(
	[Id_Solicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_TurnoMantenimiento]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_TurnoMantenimiento](
	[Id_TurnoMantenimiento] [int] NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[HoraInicio] [float] NOT NULL,
	[HoraFin] [float] NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_TurnoMantenimiento310] PRIMARY KEY CLUSTERED 
(
	[Id_TurnoMantenimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_TipoMantenimiento]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_TipoMantenimiento](
	[Id_Tipo] [int] NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_TipoMantenimiento288] PRIMARY KEY CLUSTERED 
(
	[Id_Tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_Permiso]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Permiso](
	[Id_Permiso] [int] NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Permiso296] PRIMARY KEY CLUSTERED 
(
	[Id_Permiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[T_C_PerfilUpdate]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_PerfilUpdate]
(
	@Id_Perfil int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Perfil]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[Id_Estado] = @Id_Estado
WHERE [Id_Perfil] = @Id_Perfil
GO
/****** Object:  StoredProcedure [dbo].[T_C_PerfilSelectAll]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_PerfilSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Perfil],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_Perfil]
GO
/****** Object:  StoredProcedure [dbo].[T_C_PerfilInsert]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_PerfilInsert]
(
	@Nombre varchar(255),
	@Descripcion varchar(255)
)

AS

SET NOCOUNT ON
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Perfil',@Id_Estado OUT

INSERT INTO [T_C_Perfil]
(
	[Nombre],
	[Descripcion],
	[Id_Estado]
)
VALUES
(
	@Nombre,
	@Descripcion,
	@Id_Estado
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_PerfilDelete]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_PerfilDelete]
(
	@Id_Perfil int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Perfil]
WHERE [Id_Perfil] = @Id_Perfil
GO
/****** Object:  Table [dbo].[T_C_Modelo]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Modelo](
	[Id_Modelo] [smallint] NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Año] [int] NOT NULL,
	[Id_Marca] [int] NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Modelo294] PRIMARY KEY CLUSTERED 
(
	[Id_Modelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_TurnoTrabajador]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_C_TurnoTrabajador](
	[Id_TurnoMantenimiento] [int] NOT NULL,
	[Id_Trabajador] [int] NOT NULL,
 CONSTRAINT [PK_T_C_TurnoTrabajador311] PRIMARY KEY CLUSTERED 
(
	[Id_TurnoMantenimiento] ASC,
	[Id_Trabajador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_C_PermisosXPerfil]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_C_PermisosXPerfil](
	[Id_Perfil] [int] NOT NULL,
	[Id_Permiso] [int] NOT NULL,
 CONSTRAINT [PK_T_C_PermisosXPerfil] PRIMARY KEY CLUSTERED 
(
	[Id_Perfil] ASC,
	[Id_Permiso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_C_Equipo]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Equipo](
	[Id_Equipo] [char](4) NOT NULL,
	[EquipoPadre] [char](4) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Id_Marca] [int] NOT NULL,
	[Id_Modelo] [smallint] NOT NULL,
	[Serie] [varchar](255) NOT NULL,
	[Costo] [float] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Fecha_Adquisicion] [datetime] NOT NULL,
	[Id_Area] [char](2) NOT NULL,
	[MaxHoras] [int] NOT NULL,
	[UsoUnico] [smallint] NOT NULL,
	[Nivel] [int] NOT NULL,
	[Stock] [int] NOT NULL,
	[CapacidadOperacion] [decimal](4, 2) NULL,
	[DiamteroInterno] [decimal](4, 2) NULL,
	[RevestimientoInterior] [varchar](50) NULL,
 CONSTRAINT [PK_T_C_Equipo287] PRIMARY KEY CLUSTERED 
(
	[Id_Equipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_Usuario]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Usuario](
	[Id_Usuario] [int] NOT NULL,
	[Nombres] [varchar](255) NOT NULL,
	[Apellidos] [varchar](255) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Direccion] [varchar](255) NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Fecha_Nacimiento] [datetime] NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Contraseña] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Id_Perfil] [int] NOT NULL,
	[Id_TurnoMantenimiento] [int] NOT NULL,
	[Id_Trabajador] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Usuario292] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [TC_T_C_Usuario936] ON [dbo].[T_C_Usuario] 
(
	[Id_TurnoMantenimiento] ASC,
	[Id_Trabajador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [TC_T_C_Usuario937] ON [dbo].[T_C_Usuario] 
(
	[Id_Perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_C_TipoMantenimientoPorEquipo]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_TipoMantenimientoPorEquipo](
	[Id_TipoMantenimientoEquipo] [int] NOT NULL,
	[Id_Equipo] [char](4) NOT NULL,
	[Id_TipoMantenimiento] [int] NOT NULL,
	[Id_Tipo] [int] NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_TipoMantenimientoPor302] PRIMARY KEY CLUSTERED 
(
	[Id_TipoMantenimientoEquipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [TC_T_C_TipoMantenimientoPor948] ON [dbo].[T_C_TipoMantenimientoPorEquipo] 
(
	[Id_Tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_C_Requerimiento]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Requerimiento](
	[Id_Requerimiento] [int] NOT NULL,
	[Id_Producto] [int] NOT NULL,
	[Id_Equipo] [char](4) NOT NULL,
	[HorasTrabajo] [int] NOT NULL,
	[SalidaUnidades] [float] NOT NULL,
	[SalidaMetricas] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Requerimiento300] PRIMARY KEY CLUSTERED 
(
	[Id_Requerimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_Alerta]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Alerta](
	[Id_Alerta] [int] NOT NULL,
	[Id_Equipo] [char](4) NOT NULL,
	[ACorreo] [varchar](255) NOT NULL,
	[FechaEnvio] [datetime] NOT NULL,
	[ValorDemanda] [float] NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Alerta307] PRIMARY KEY CLUSTERED 
(
	[Id_Alerta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_OrdenTrabajo]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_OrdenTrabajo](
	[Id_OrdenTrabajo] [int] NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[CostoTotal] [float] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[UltimaFechaModificacion] [datetime] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Id_Usuario] [int] NOT NULL,
 CONSTRAINT [PK_T_C_OrdenTrabajo289] PRIMARY KEY CLUSTERED 
(
	[Id_OrdenTrabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [TC_T_C_OrdenTrabajo935] ON [dbo].[T_C_OrdenTrabajo] 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_C_MovimientosEquipo]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_MovimientosEquipo](
	[Id_Movimiento] [int] NOT NULL,
	[Id_Equipo] [char](4) NOT NULL,
	[Id_AEquipo] [char](4) NOT NULL,
	[FechaMovimiento] [datetime] NOT NULL,
	[Observacion] [varchar](255) NOT NULL,
	[Usuario_Registro] [varchar](255) NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Id_OrdenDeTrabajo] [int] NOT NULL,
	[EsMantenimiento] [smallint] NOT NULL,
	[EsIngreso] [smallint] NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_MovimientosEquipo306] PRIMARY KEY CLUSTERED 
(
	[Id_Movimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_DetalleSolicitud]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_DetalleSolicitud](
	[Id_Solicitud] [int] NOT NULL,
	[Id_Equipo] [char](4) NOT NULL,
	[Motivo] [varchar](255) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[Id_DetalleSolicitud] [int] NOT NULL,
 CONSTRAINT [PK_T_C_DetalleSolicitud305] PRIMARY KEY CLUSTERED 
(
	[Id_Solicitud] ASC,
	[Id_DetalleSolicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_C_DetalleOrdenDeTrabajo]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_DetalleOrdenDeTrabajo](
	[Id_DetalleOrdendeTrabajo] [int] NOT NULL,
	[Id_OrdendeTrabajo] [int] NOT NULL,
	[Costo] [float] NOT NULL,
	[Porcentaje] [float] NOT NULL,
	[Motivo] [varchar](255) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Id_OrdenTrabajo] [int] NOT NULL,
	[Id_Solicitud] [int] NOT NULL,
 CONSTRAINT [PK_T_C_DetalleOrdenDeTrabaj303] PRIMARY KEY CLUSTERED 
(
	[Id_OrdendeTrabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [TC_T_C_DetalleOrdenDeTrabaj892] UNIQUE NONCLUSTERED 
(
	[Id_Solicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [TC_T_C_DetalleOrdenDeTrabaj949] ON [dbo].[T_C_DetalleOrdenDeTrabajo] 
(
	[Id_OrdenTrabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [TC_T_C_DetalleOrdenDeTrabaj950] ON [dbo].[T_C_DetalleOrdenDeTrabajo] 
(
	[Id_Solicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_C_Mantenimiento]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Mantenimiento](
	[Id_Mantenimiento] [int] NOT NULL,
	[Id_Turno] [int] NOT NULL,
	[Id_Equipo] [char](4) NOT NULL,
	[FechaProgramacion] [datetime] NOT NULL,
	[FechaTrabajoInicio] [datetime] NOT NULL,
	[FechaTrabajoFin] [datetime] NOT NULL,
	[UsuarioRegistro] [varchar](255) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Id_TipoMantenimiento] [int] NOT NULL,
	[Id_Incidencia] [int] NOT NULL,
	[Id_Pedido] [int] NOT NULL,
	[Prioridad] [int] NOT NULL,
	[Id_OrdenTrabajo] [int] NOT NULL,
	[Id_TipoMantenimientoEquipo] [int] NOT NULL,
	[Id_TurnoMantenimiento] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Mantenimiento297] PRIMARY KEY CLUSTERED 
(
	[Id_Mantenimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [TC_T_C_Mantenimiento888] UNIQUE NONCLUSTERED 
(
	[Id_OrdenTrabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [TC_T_C_Mantenimiento939] ON [dbo].[T_C_Mantenimiento] 
(
	[Id_TipoMantenimientoEquipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [TC_T_C_Mantenimiento941] ON [dbo].[T_C_Mantenimiento] 
(
	[Id_TurnoMantenimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [TC_T_C_Mantenimiento943] ON [dbo].[T_C_Mantenimiento] 
(
	[Id_OrdenTrabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_C_Producto]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Producto](
	[Id_Producto] [int] NOT NULL,
	[Descripción] [varchar](255) NOT NULL,
	[Id_Requerimiento] [int] NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Producto298] PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [TC_T_C_Producto944] ON [dbo].[T_C_Producto] 
(
	[Id_Requerimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_C_Trabajo]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_C_Trabajo](
	[Id_Trabajo] [int] NOT NULL,
	[Id_Producto] [int] NOT NULL,
	[FechaTrabajo] [datetime] NOT NULL,
	[HorasTrabajo] [int] NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Trabajo299] PRIMARY KEY CLUSTERED 
(
	[Id_Trabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_C_Pedido]    Script Date: 11/07/2010 10:40:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Pedido](
	[Id_Pedido] [int] NOT NULL,
	[Usuario_Pedido] [varchar](255) NOT NULL,
	[Fecha_Pedido] [datetime] NOT NULL,
	[UsuarioConfirma] [varchar](255) NOT NULL,
	[FechaConfirma] [datetime] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[MotivoPedido] [varchar](255) NOT NULL,
	[Id_Mantenimiento] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Pedido304] PRIMARY KEY CLUSTERED 
(
	[Id_Pedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [TC_T_C_Pedido909] UNIQUE NONCLUSTERED 
(
	[Id_Mantenimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [TC_T_C_Pedido951] ON [dbo].[T_C_Pedido] 
(
	[Id_Mantenimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_T_C_Estado_T_C_Tabla]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Estado]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Estado_T_C_Tabla] FOREIGN KEY([Id_Tabla])
REFERENCES [dbo].[T_C_Tabla] ([Id_Tabla])
GO
ALTER TABLE [dbo].[T_C_Estado] CHECK CONSTRAINT [FK_T_C_Estado_T_C_Tabla]
GO
/****** Object:  ForeignKey [FK_T_C_Marca_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Marca]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Marca_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Marca] CHECK CONSTRAINT [FK_T_C_Marca_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Incidencia_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Incidencia]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Incidencia_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Incidencia] CHECK CONSTRAINT [FK_T_C_Incidencia_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Area_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Area]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Area_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Area] CHECK CONSTRAINT [FK_T_C_Area_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Perfil_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Perfil]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Perfil_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Perfil] CHECK CONSTRAINT [FK_T_C_Perfil_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Solicitud_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Solicitud_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Solicitud] CHECK CONSTRAINT [FK_T_C_Solicitud_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_TurnoMantenimiento_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_TurnoMantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TurnoMantenimiento_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_TurnoMantenimiento] CHECK CONSTRAINT [FK_T_C_TurnoMantenimiento_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_TipoMantenimiento_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_TipoMantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TipoMantenimiento_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_TipoMantenimiento] CHECK CONSTRAINT [FK_T_C_TipoMantenimiento_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Permiso_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Permiso_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Permiso] CHECK CONSTRAINT [FK_T_C_Permiso_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Modelo_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Modelo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Modelo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Modelo] CHECK CONSTRAINT [FK_T_C_Modelo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Modelo_T_C_Marca]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Modelo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Modelo_T_C_Marca] FOREIGN KEY([Id_Marca])
REFERENCES [dbo].[T_C_Marca] ([Id_Marca])
GO
ALTER TABLE [dbo].[T_C_Modelo] CHECK CONSTRAINT [FK_T_C_Modelo_T_C_Marca]
GO
/****** Object:  ForeignKey [FK_T_C_TurnoTrabajador_T_C_TurnoMantenimiento]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_TurnoTrabajador]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TurnoTrabajador_T_C_TurnoMantenimiento] FOREIGN KEY([Id_TurnoMantenimiento])
REFERENCES [dbo].[T_C_TurnoMantenimiento] ([Id_TurnoMantenimiento])
GO
ALTER TABLE [dbo].[T_C_TurnoTrabajador] CHECK CONSTRAINT [FK_T_C_TurnoTrabajador_T_C_TurnoMantenimiento]
GO
/****** Object:  ForeignKey [FK_T_C_PermisosXPerfil_T_C_Perfil]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_PermisosXPerfil]  WITH CHECK ADD  CONSTRAINT [FK_T_C_PermisosXPerfil_T_C_Perfil] FOREIGN KEY([Id_Perfil])
REFERENCES [dbo].[T_C_Perfil] ([Id_Perfil])
GO
ALTER TABLE [dbo].[T_C_PermisosXPerfil] CHECK CONSTRAINT [FK_T_C_PermisosXPerfil_T_C_Perfil]
GO
/****** Object:  ForeignKey [FK_T_C_PermisosXPerfil_T_C_Permiso]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_PermisosXPerfil]  WITH CHECK ADD  CONSTRAINT [FK_T_C_PermisosXPerfil_T_C_Permiso] FOREIGN KEY([Id_Permiso])
REFERENCES [dbo].[T_C_Permiso] ([Id_Permiso])
GO
ALTER TABLE [dbo].[T_C_PermisosXPerfil] CHECK CONSTRAINT [FK_T_C_PermisosXPerfil_T_C_Permiso]
GO
/****** Object:  ForeignKey [FK_T_C_Equipo_T_C_Area]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Equipo_T_C_Area] FOREIGN KEY([Id_Area])
REFERENCES [dbo].[T_C_Area] ([Id_Area])
GO
ALTER TABLE [dbo].[T_C_Equipo] CHECK CONSTRAINT [FK_T_C_Equipo_T_C_Area]
GO
/****** Object:  ForeignKey [FK_T_C_Equipo_T_C_Equipo]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Equipo_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_Equipo] CHECK CONSTRAINT [FK_T_C_Equipo_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_Equipo_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Equipo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Equipo] CHECK CONSTRAINT [FK_T_C_Equipo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Equipo_T_C_Modelo]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Equipo_T_C_Modelo] FOREIGN KEY([Id_Modelo])
REFERENCES [dbo].[T_C_Modelo] ([Id_Modelo])
GO
ALTER TABLE [dbo].[T_C_Equipo] CHECK CONSTRAINT [FK_T_C_Equipo_T_C_Modelo]
GO
/****** Object:  ForeignKey [FK_T_C_Usuario_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Usuario_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Usuario] CHECK CONSTRAINT [FK_T_C_Usuario_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Usuario444]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Usuario444] FOREIGN KEY([Id_Perfil])
REFERENCES [dbo].[T_C_Perfil] ([Id_Perfil])
GO
ALTER TABLE [dbo].[T_C_Usuario] CHECK CONSTRAINT [FK_T_C_Usuario444]
GO
/****** Object:  ForeignKey [FK_T_C_Usuario478]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Usuario478] FOREIGN KEY([Id_TurnoMantenimiento], [Id_Trabajador])
REFERENCES [dbo].[T_C_TurnoTrabajador] ([Id_TurnoMantenimiento], [Id_Trabajador])
GO
ALTER TABLE [dbo].[T_C_Usuario] CHECK CONSTRAINT [FK_T_C_Usuario478]
GO
/****** Object:  ForeignKey [FK_T_C_TipoMantenimientoPor436]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TipoMantenimientoPor436] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[T_C_TipoMantenimiento] ([Id_Tipo])
GO
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo] CHECK CONSTRAINT [FK_T_C_TipoMantenimientoPor436]
GO
/****** Object:  ForeignKey [FK_T_C_TipoMantenimientoPorEquipo_T_C_Equipo]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TipoMantenimientoPorEquipo_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo] CHECK CONSTRAINT [FK_T_C_TipoMantenimientoPorEquipo_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_TipoMantenimientoPorEquipo_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TipoMantenimientoPorEquipo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo] CHECK CONSTRAINT [FK_T_C_TipoMantenimientoPorEquipo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Requerimiento_T_C_Equipo]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Requerimiento_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_Requerimiento] CHECK CONSTRAINT [FK_T_C_Requerimiento_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_Requerimiento_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Requerimiento_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Requerimiento] CHECK CONSTRAINT [FK_T_C_Requerimiento_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Alerta_T_C_Equipo]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Alerta]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Alerta_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_Alerta] CHECK CONSTRAINT [FK_T_C_Alerta_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_Alerta_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Alerta]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Alerta_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Alerta] CHECK CONSTRAINT [FK_T_C_Alerta_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_OrdenTrabajo_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_OrdenTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_OrdenTrabajo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_OrdenTrabajo] CHECK CONSTRAINT [FK_T_C_OrdenTrabajo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_OrdenTrabajo448]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_OrdenTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_OrdenTrabajo448] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[T_C_Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[T_C_OrdenTrabajo] CHECK CONSTRAINT [FK_T_C_OrdenTrabajo448]
GO
/****** Object:  ForeignKey [FK_T_C_MovimientosEquipo_T_C_Equipo]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_MovimientosEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_MovimientosEquipo_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_MovimientosEquipo] CHECK CONSTRAINT [FK_T_C_MovimientosEquipo_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_MovimientosEquipo_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_MovimientosEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_MovimientosEquipo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_MovimientosEquipo] CHECK CONSTRAINT [FK_T_C_MovimientosEquipo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleSolicitud_T_C_Equipo]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_DetalleSolicitud]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleSolicitud_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_DetalleSolicitud] CHECK CONSTRAINT [FK_T_C_DetalleSolicitud_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleSolicitud_T_C_Solicitud]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_DetalleSolicitud]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleSolicitud_T_C_Solicitud] FOREIGN KEY([Id_Solicitud])
REFERENCES [dbo].[T_C_Solicitud] ([Id_Solicitud])
GO
ALTER TABLE [dbo].[T_C_DetalleSolicitud] CHECK CONSTRAINT [FK_T_C_DetalleSolicitud_T_C_Solicitud]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleOrdenDeTrabaj439]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleOrdenDeTrabaj439] FOREIGN KEY([Id_OrdenTrabajo])
REFERENCES [dbo].[T_C_OrdenTrabajo] ([Id_OrdenTrabajo])
GO
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo] CHECK CONSTRAINT [FK_T_C_DetalleOrdenDeTrabaj439]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleOrdenDeTrabajo_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo] CHECK CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleOrdenDeTrabajo_T_C_Solicitud]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Solicitud] FOREIGN KEY([Id_Solicitud])
REFERENCES [dbo].[T_C_Solicitud] ([Id_Solicitud])
GO
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo] CHECK CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Solicitud]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento_T_C_Incidencia]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento_T_C_Incidencia] FOREIGN KEY([Id_Incidencia])
REFERENCES [dbo].[T_C_Incidencia] ([Id_Incidencia])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento_T_C_Incidencia]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento_T_C_TipoMantenimientoPorEquipo]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento_T_C_TipoMantenimientoPorEquipo] FOREIGN KEY([Id_TipoMantenimientoEquipo])
REFERENCES [dbo].[T_C_TipoMantenimientoPorEquipo] ([Id_TipoMantenimientoEquipo])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento_T_C_TipoMantenimientoPorEquipo]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento438]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento438] FOREIGN KEY([Id_OrdenTrabajo])
REFERENCES [dbo].[T_C_OrdenTrabajo] ([Id_OrdenTrabajo])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento438]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento466]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento466] FOREIGN KEY([Id_TipoMantenimientoEquipo])
REFERENCES [dbo].[T_C_TipoMantenimientoPorEquipo] ([Id_TipoMantenimientoEquipo])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento466]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento475]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento475] FOREIGN KEY([Id_TurnoMantenimiento])
REFERENCES [dbo].[T_C_TurnoMantenimiento] ([Id_TurnoMantenimiento])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento475]
GO
/****** Object:  ForeignKey [FK_T_C_Producto_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Producto]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Producto_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Producto] CHECK CONSTRAINT [FK_T_C_Producto_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Producto462]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Producto]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Producto462] FOREIGN KEY([Id_Requerimiento])
REFERENCES [dbo].[T_C_Requerimiento] ([Id_Requerimiento])
GO
ALTER TABLE [dbo].[T_C_Producto] CHECK CONSTRAINT [FK_T_C_Producto462]
GO
/****** Object:  ForeignKey [FK_T_C_Trabajo_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Trabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Trabajo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Trabajo] CHECK CONSTRAINT [FK_T_C_Trabajo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Trabajo_T_C_Producto]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Trabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Trabajo_T_C_Producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[T_C_Producto] ([Id_Producto])
GO
ALTER TABLE [dbo].[T_C_Trabajo] CHECK CONSTRAINT [FK_T_C_Trabajo_T_C_Producto]
GO
/****** Object:  ForeignKey [FK_T_C_Pedido_T_C_Estado]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Pedido]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Pedido_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Pedido] CHECK CONSTRAINT [FK_T_C_Pedido_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Pedido457]    Script Date: 11/07/2010 10:40:11 ******/
ALTER TABLE [dbo].[T_C_Pedido]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Pedido457] FOREIGN KEY([Id_Mantenimiento])
REFERENCES [dbo].[T_C_Mantenimiento] ([Id_Mantenimiento])
GO
ALTER TABLE [dbo].[T_C_Pedido] CHECK CONSTRAINT [FK_T_C_Pedido457]
GO
