USE [SIMA]
GO
/****** Object:  Table [dbo].[T_C_Tabla]    Script Date: 11/28/2010 01:09:37 ******/
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
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (23, N'T_C_Trabajo', N'Tabla de trabajos de equipos')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (24, N'T_C_TurnoMantenimiento', N'Tabla de turnos de trabajo para hacer mantenimiento')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (25, N'T_C_TurnoTrabajador', N'Tabla de turnos de trabajo para hacer mantenimiento por trabajador')
INSERT [dbo].[T_C_Tabla] ([Id_Tabla], [Nombre_Tabla], [Descripcion_Tabla]) VALUES (26, N'T_C_Usuario', N'Tabla de usuarios del sistema')
SET IDENTITY_INSERT [dbo].[T_C_Tabla] OFF
/****** Object:  Table [dbo].[T_C_Estado]    Script Date: 11/28/2010 01:09:37 ******/
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
	[Muestra_Informacion] [bit] NOT NULL,
	[NoElimina] [bit] NULL,
 CONSTRAINT [PK_T_C_Estado] PRIMARY KEY CLUSTERED 
(
	[Id_Estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_C_Estado] ON
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (1, 1, N'Activo', N'Perfil en uso.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (2, 1, N'Inactivo', N'Perfil en desuso.', 0, 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (3, 3, N'Activo', N'Área en uso.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (4, 3, N'Inactivo', N'Área en desuso.', 0, 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (5, 26, N'Activo', N'Usuario habilitado.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (6, 26, N'Inactivo', N'Usuario inhabilitado.', 0, 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (7, 15, N'Activo', N'Permiso en uso.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (8, 15, N'Inactivo', N'Permiso en desuso.', 0, 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (9, 10, N'Activo', N'Marca de equipo en uso.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (10, 10, N'Inactivo', N'Marca de equipo en desuso.', 0, 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (11, 11, N'Activo', N'Modelo en uso.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (12, 11, N'Inactivo', N'Modelo en desuso.', 0, 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (13, 21, N'Activo', N'Tipo de mantenimiento en uso.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (14, 21, N'Inactivo', N'Tipo de mantenimiento en desuso.', 0, 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (15, 6, N'Activo', N'Equipo en uso.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (16, 6, N'Inactivo', N'Equipo en desuso.', 0, 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (17, 6, N'En mantenimiento', N'Equipo en mantenimiento.', 0, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (18, 22, N'Activo', N'Equipo habilitado para determinado trabajo de mantenimiento.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (19, 19, N'Pendiente de respuesta', N'Solicitud recien creada, en espera de respuesta.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (20, 19, N'Aprobada', N'Solicitud aprobada, pasa a orden de mantenimiento.', 0, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (21, 19, N'Rechazada', N'Solicitud rechazada.', 0, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (22, 17, N'Activo', N'Producto existente. Se sigue produciendo.', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (23, 17, N'Inactivo', N'Producto inexistente. No se sigue produciendo.', 0, 0, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (24, 9, N'Pendiente', N'Pendiente de detalle', 1, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (27, 9, N'Terminado', N'Trabajo terminado.', 0, 1, 0)
INSERT [dbo].[T_C_Estado] ([Id_Estado], [Id_Tabla], [Nombre_Estado], [Descripcion_Estado], [Por_Defecto], [Muestra_Informacion], [NoElimina]) VALUES (28, 9, N'Archivado', N'Trabajo archivado.', 0, 1, 1)
SET IDENTITY_INSERT [dbo].[T_C_Estado] OFF
/****** Object:  StoredProcedure [dbo].[T_C_TablaUpdate]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_TablaSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_TablaSelect]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_TablaInsert]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_TablaDelete]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  Table [dbo].[T_C_TurnoMantenimiento]    Script Date: 11/28/2010 01:09:38 ******/
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
INSERT [dbo].[T_C_TurnoMantenimiento] ([Id_TurnoMantenimiento], [Descripcion], [HoraInicio], [HoraFin], [Id_Estado]) VALUES (1, N'turno 1', 1000, 1200, 1)
INSERT [dbo].[T_C_TurnoMantenimiento] ([Id_TurnoMantenimiento], [Descripcion], [HoraInicio], [HoraFin], [Id_Estado]) VALUES (2, N'turno 2', 1100, 1300, 1)
/****** Object:  Table [dbo].[T_C_Solicitud]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  Table [dbo].[T_C_Producto]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Producto](
	[Id_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Descripción] [varchar](255) NOT NULL,
	[Id_Estado] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Producto298] PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_C_Producto] ON
INSERT [dbo].[T_C_Producto] ([Id_Producto], [Descripción], [Id_Estado]) VALUES (1, N'Tonsil SPA 2001', 22)
INSERT [dbo].[T_C_Producto] ([Id_Producto], [Descripción], [Id_Estado]) VALUES (2, N'KLINKAT', 22)
INSERT [dbo].[T_C_Producto] ([Id_Producto], [Descripción], [Id_Estado]) VALUES (3, N'FULLASOFT', 22)
INSERT [dbo].[T_C_Producto] ([Id_Producto], [Descripción], [Id_Estado]) VALUES (4, N'TONSIL 960', 22)
INSERT [dbo].[T_C_Producto] ([Id_Producto], [Descripción], [Id_Estado]) VALUES (5, N'TONSIL SGP', 22)
INSERT [dbo].[T_C_Producto] ([Id_Producto], [Descripción], [Id_Estado]) VALUES (6, N'TONSIL 100', 22)
INSERT [dbo].[T_C_Producto] ([Id_Producto], [Descripción], [Id_Estado]) VALUES (7, N'TONSIL 200', 22)
SET IDENTITY_INSERT [dbo].[T_C_Producto] OFF
/****** Object:  Table [dbo].[T_C_Permiso]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Permiso](
	[Id_Permiso] [int] IDENTITY(1,1) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[T_C_Permiso] ON
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (1, N'Gestionar Perfiles', N'Administracion de perfiles del sistema', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (2, N'Gestionar Permisos', N'Administración de permisos del sistema', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (3, N'Asignar Permisos', N'Asignación de permisos a determinado perfil', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (4, N'Gestionar Áreas', N'Administración de las áreas correspondientes a los equipos', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (5, N'Gestionar Estados', N'Administración de los estados del sistema', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (6, N'Gestionar Marcas', N'Administración de las marcas inventariadas en planta.', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (8, N'Gestionar Modelos', N'Administración de los modelos correspondientes a las marcas inventariadas en planta.', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (9, N'Gestionar Equipos', N'Administración de los equipos inventariados en planta', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (10, N'Gestionar Tipos de Mantenimiento', N'Administración de los tipos de mantenimiento que se dan', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (11, N'Gestionar Usuarios', N'Adminsitración de los usuarios del sistema', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (12, N'Gestiomar Orden de Trabajo', N'Administración de las Ordenes de trabajo', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (13, N'Gestionar Tablas', N'Administración de las tablas del sistema', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (14, N'Cambiar Contraseña', N'Cambiar Contraseña', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (15, N'Registrar Orden de Trabajo', N'Registrar una Orden de Trabajo', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (17, N'Registrar Informe de Orden de Trabajo', N'Registrar informe de orden de trabajo.', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (18, N'Gestionar Productos', N'Administración de productos', 7)
INSERT [dbo].[T_C_Permiso] ([Id_Permiso], [Nombre], [Descripcion], [Id_Estado]) VALUES (19, N'Aperturar Mantenimiento', N'Apertura de mantenimiento de equipo', 7)
SET IDENTITY_INSERT [dbo].[T_C_Permiso] OFF
/****** Object:  Table [dbo].[T_C_TipoMantenimiento]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_TipoMantenimiento](
	[Id_Tipo] [int] IDENTITY(1,1) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[T_C_TipoMantenimiento] ON
INSERT [dbo].[T_C_TipoMantenimiento] ([Id_Tipo], [Nombre], [Descripcion], [Id_Estado]) VALUES (0, N'Mantenimiento Preventivo', N'Mantenimiento corriente para evitar daños en equipos.', 13)
INSERT [dbo].[T_C_TipoMantenimiento] ([Id_Tipo], [Nombre], [Descripcion], [Id_Estado]) VALUES (4, N'Mantenimiento correctivo', N'Mantenimiento a realizarse en caso falla de un equipo.', 13)
INSERT [dbo].[T_C_TipoMantenimiento] ([Id_Tipo], [Nombre], [Descripcion], [Id_Estado]) VALUES (5, N'Mantenimineto por Incidencia', N'Mantenimiento por falla debido a un error ocasionado.', 13)
SET IDENTITY_INSERT [dbo].[T_C_TipoMantenimiento] OFF
/****** Object:  Table [dbo].[T_C_Incidencia]    Script Date: 11/28/2010 01:09:38 ******/
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
INSERT [dbo].[T_C_Incidencia] ([Id_Incidencia], [Usuario_Responsable], [Usuario_Registro], [Fecha_Incidencia], [Fecha_Reporte], [Descripcion], [Id_Estado]) VALUES (1, N'1', N'1', CAST(0x00009E0B00000000 AS DateTime), CAST(0x00009E0B00000000 AS DateTime), N'qawea', 1)
/****** Object:  StoredProcedure [dbo].[T_C_EstadoUpdate]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EstadoUpdate]
(
	@Id_Estado int,
	@Id_Tabla int,
	@Nombre_Estado varchar(255),
	@Descripcion_Estado varchar(255),
	@Por_Defecto bit,
	@Muestra_Informacion bit,
	@NoElimina bit
)

AS

SET NOCOUNT ON

UPDATE [T_C_Estado]
SET [Id_Tabla] = @Id_Tabla,
	[Nombre_Estado] = @Nombre_Estado,
	[Descripcion_Estado] = @Descripcion_Estado,
	[Por_Defecto] = @Por_Defecto,
	[Muestra_Informacion] = @Muestra_Informacion,
	[NoElimina] = @NoElimina
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_EstadoSelectByNombre_Tabla]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[T_C_EstadoSelectByNombre_Tabla]
(
	@NombreTabla varchar(255)
)
AS
SELECT        T_C_Estado.Id_Estado, T_C_Estado.Id_Tabla, T_C_Estado.Nombre_Estado, T_C_Estado.Descripcion_Estado, T_C_Estado.Por_Defecto, 
                         T_C_Estado.Muestra_Informacion, T_C_Estado.NoElimina
FROM            T_C_Estado INNER JOIN
                         T_C_Tabla ON T_C_Estado.Id_Tabla = T_C_Tabla.Id_Tabla
WHERE        (T_C_Tabla.Nombre_Tabla = @NombreTabla)
GO
/****** Object:  StoredProcedure [dbo].[T_C_EstadoSelectAllById_Tabla]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EstadoSelectAllById_Tabla]
(
	@Id_Tabla int
)

AS

SET NOCOUNT ON

SELECT [Id_Estado],
	[Id_Tabla],
	[Nombre_Estado],
	[Descripcion_Estado],
	[Por_Defecto],
	[Muestra_Informacion],
	[NoElimina]
FROM [T_C_Estado]
WHERE [Id_Tabla] = @Id_Tabla
GO
/****** Object:  StoredProcedure [dbo].[T_C_EstadoSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
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
	[Muestra_Informacion],
	[NoElimina]
FROM [T_C_Estado]
GO
/****** Object:  StoredProcedure [dbo].[T_C_EstadoSelect]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EstadoSelect]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_Estado],
	[Id_Tabla],
	[Nombre_Estado],
	[Descripcion_Estado],
	[Por_Defecto],
	[Muestra_Informacion]
FROM [T_C_Estado]
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_EstadoInsert]    Script Date: 11/28/2010 01:09:38 ******/
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
	@Muestra_Informacion bit,
	@NoElimina bit
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Estado]
(
	[Id_Tabla],
	[Nombre_Estado],
	[Descripcion_Estado],
	[Por_Defecto],
	[Muestra_Informacion],
	[NoElimina]
)
VALUES
(
	@Id_Tabla,
	@Nombre_Estado,
	@Descripcion_Estado,
	@Por_Defecto,
	@Muestra_Informacion,
	@NoElimina
)

SELECT SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[T_C_EstadoDelete]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  Table [dbo].[T_C_Marca]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Marca](
	[Id_Marca] [int] IDENTITY(1,1) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[T_C_Marca] ON
INSERT [dbo].[T_C_Marca] ([Id_Marca], [Descripcion], [Nombre], [Id_Estado]) VALUES (3, N'Marca de maquinarias pesadas.', N'Caterpillar', 9)
INSERT [dbo].[T_C_Marca] ([Id_Marca], [Descripcion], [Nombre], [Id_Estado]) VALUES (4, N'Marca japonesa', N'Honda', 9)
INSERT [dbo].[T_C_Marca] ([Id_Marca], [Descripcion], [Nombre], [Id_Estado]) VALUES (5, N'111111', N'Marca 1', 10)
INSERT [dbo].[T_C_Marca] ([Id_Marca], [Descripcion], [Nombre], [Id_Estado]) VALUES (6, N'222222', N'Marca 2', 10)
INSERT [dbo].[T_C_Marca] ([Id_Marca], [Descripcion], [Nombre], [Id_Estado]) VALUES (7, N'333333', N'Marca 3', 10)
INSERT [dbo].[T_C_Marca] ([Id_Marca], [Descripcion], [Nombre], [Id_Estado]) VALUES (8, N'Marca Delcrosa', N'Delcrosa', 9)
SET IDENTITY_INSERT [dbo].[T_C_Marca] OFF
/****** Object:  Table [dbo].[T_C_Perfil]    Script Date: 11/28/2010 01:09:38 ******/
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
INSERT [dbo].[T_C_Perfil] ([Id_Perfil], [Nombre], [Descripcion], [Id_Estado]) VALUES (3, N'Administrador del Sistema', N'Administrador con todos los privilegios del sistema.', 1)
INSERT [dbo].[T_C_Perfil] ([Id_Perfil], [Nombre], [Descripcion], [Id_Estado]) VALUES (4, N'Jefe de Planta', N'Responsable del área de producción.', 1)
INSERT [dbo].[T_C_Perfil] ([Id_Perfil], [Nombre], [Descripcion], [Id_Estado]) VALUES (5, N'Supervisor de Mantenimiento', N'Jefe de área de Mantenimiento', 1)
SET IDENTITY_INSERT [dbo].[T_C_Perfil] OFF
/****** Object:  StoredProcedure [dbo].[spHelperAsignaEstado]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  Table [dbo].[T_C_Area]    Script Date: 11/28/2010 01:09:38 ******/
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
	[Correlativo] [int] NOT NULL,
 CONSTRAINT [PK_T_C_Area295] PRIMARY KEY CLUSTERED 
(
	[Id_Area] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[T_C_Area] ([Id_Area], [Descripcion], [Nombre], [Id_Estado], [Correlativo]) VALUES (N'FI', N'Operación de Filtrado.', N'Filtrado', 3, 36)
INSERT [dbo].[T_C_Area] ([Id_Area], [Descripcion], [Nombre], [Id_Estado], [Correlativo]) VALUES (N'LA', N'Operación de Lavado.', N'Lavado', 3, 4)
INSERT [dbo].[T_C_Area] ([Id_Area], [Descripcion], [Nombre], [Id_Estado], [Correlativo]) VALUES (N'MO', N'Operación de Molienda.', N'Molienda', 3, 2)
INSERT [dbo].[T_C_Area] ([Id_Area], [Descripcion], [Nombre], [Id_Estado], [Correlativo]) VALUES (N'RE', N'Proceso de Activación.', N'Activación', 3, 2)
INSERT [dbo].[T_C_Area] ([Id_Area], [Descripcion], [Nombre], [Id_Estado], [Correlativo]) VALUES (N'SE', N'Operación de Secado.', N'Secado', 3, 0)
INSERT [dbo].[T_C_Area] ([Id_Area], [Descripcion], [Nombre], [Id_Estado], [Correlativo]) VALUES (N'TA', N'Operación de Tamizado.', N'Tamizado', 3, 0)
/****** Object:  StoredProcedure [dbo].[T_C_AreaUpdate]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_AreaUpdate]
(
	@Id_Area char(2),
	@Descripcion varchar(255),
	@Nombre varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Area]
SET [Descripcion] = @Descripcion,
	[Nombre] = @Nombre,
	[Id_Estado] = @Id_Estado
WHERE [Id_Area] = @Id_Area
GO
/****** Object:  StoredProcedure [dbo].[T_C_AreaSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_AreaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Area],
	[Descripcion],
	[Nombre],
	[Id_Estado]
FROM [T_C_Area]
GO
/****** Object:  StoredProcedure [dbo].[T_C_AreaSelectActivo]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[T_C_AreaSelectActivo]
AS
	DECLARE @Id_Estado int
	exec spHelperAsignaEstado 'T_C_Area',@Id_Estado OUT
	Select Id_Area,Nombre,Descripcion,Id_Estado FROM T_C_Area WHERE Id_Estado = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_AreaSelect]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_AreaSelect]
(
	@Id_Area char(2)
)

AS

SET NOCOUNT ON

SELECT [Id_Area],
	[Descripcion],
	[Nombre],
	[Id_Estado]
FROM [T_C_Area]
WHERE [Id_Area] = @Id_Area
GO
/****** Object:  StoredProcedure [dbo].[T_C_AreaInsert]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_AreaInsert]
(
	@Id_Area char(2),
	@Descripcion varchar(255),
	@Nombre varchar(255)
)

AS

DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Area',@Id_Estado OUT
SET NOCOUNT ON


INSERT INTO [T_C_Area]
(
	[Id_Area],
	[Descripcion],
	[Nombre],
	[Id_Estado]
)
VALUES
(
	@Id_Area,
	@Descripcion,
	@Nombre,
	@Id_Estado
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_AreaDelete]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_AreaDelete]
(
	@Id_Area char(2)
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Area]
WHERE [Id_Area] = @Id_Area
GO
/****** Object:  Table [dbo].[T_C_Modelo]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Modelo](
	[Id_Modelo] [int] IDENTITY(1,1) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[T_C_Modelo] ON
INSERT [dbo].[T_C_Modelo] ([Id_Modelo], [Descripcion], [Año], [Id_Marca], [Id_Estado]) VALUES (3, N'Caterpillar Modelo 1', 2000, 3, 11)
INSERT [dbo].[T_C_Modelo] ([Id_Modelo], [Descripcion], [Año], [Id_Marca], [Id_Estado]) VALUES (4, N'11111 1111', 1999, 4, 11)
INSERT [dbo].[T_C_Modelo] ([Id_Modelo], [Descripcion], [Año], [Id_Marca], [Id_Estado]) VALUES (5, N'Caterpillar Modelo 2', 1980, 3, 11)
INSERT [dbo].[T_C_Modelo] ([Id_Modelo], [Descripcion], [Año], [Id_Marca], [Id_Estado]) VALUES (6, N'NV100L4', 1985, 8, 11)
SET IDENTITY_INSERT [dbo].[T_C_Modelo] OFF
/****** Object:  StoredProcedure [dbo].[T_C_MarcaUpdate]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_MarcaUpdate]
(
	@Id_Marca int,
	@Descripcion varchar(255),
	@Nombre varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Marca]
SET [Descripcion] = @Descripcion,
	[Nombre] = @Nombre,
	[Id_Estado] = @Id_Estado
WHERE [Id_Marca] = @Id_Marca
GO
/****** Object:  StoredProcedure [dbo].[T_C_MarcaSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_MarcaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Marca],
	[Descripcion],
	[Nombre],
	[Id_Estado]
FROM [T_C_Marca]
GO
/****** Object:  StoredProcedure [dbo].[T_C_MarcaSelectActivo]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[T_C_MarcaSelectActivo]
AS
	DECLARE @Id_Estado int
	exec spHelperAsignaEstado 'T_C_Marca',@Id_Estado OUT
	Select Id_Marca,Nombre,Descripcion,Id_Estado FROM T_C_Marca WHERE Id_Estado = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_MarcaSelect]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_MarcaSelect]
(
	@Id_Marca int
)

AS

SET NOCOUNT ON

SELECT [Id_Marca],
	[Descripcion],
	[Nombre],
	[Id_Estado]
FROM [T_C_Marca]
WHERE [Id_Marca] = @Id_Marca
GO
/****** Object:  StoredProcedure [dbo].[T_C_MarcaInsert]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_MarcaInsert]
(
	@Descripcion varchar(255),
	@Nombre varchar(255)
)

AS
DECLARE @Id_Estado int 

exec spHelperAsignaEstado 'T_C_Marca',@Id_Estado OUT

SET NOCOUNT ON

INSERT INTO [T_C_Marca]
(
	[Descripcion],
	[Nombre],
	[Id_Estado]
)
VALUES
(
	@Descripcion,
	@Nombre,
	@Id_Estado
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_MarcaDelete]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_MarcaDelete]
(
	@Id_Marca int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Marca]
WHERE [Id_Marca] = @Id_Marca
GO
/****** Object:  StoredProcedure [dbo].[T_C_ProductoUpdate]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ProductoUpdate]
(
	@Id_Producto int,
	@Descripción varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Producto]
SET [Descripción] = @Descripción,
	[Id_Estado] = @Id_Estado
WHERE [Id_Producto] = @Id_Producto
GO
/****** Object:  StoredProcedure [dbo].[T_C_ProductoSelectActivo]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ProductoSelectActivo]

AS
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Producto', @Id_Estado OUT
SET NOCOUNT ON

SELECT [Id_Producto],
	[Descripción],
	[Id_Estado]
FROM [T_C_Producto]
WHERE Id_Estado = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_ProductoInsert]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ProductoInsert]
(
	@Descripción varchar(255)
)

AS
DECLARE @Id_Estado int
exec spHelperAsignaEstado 'T_C_Producto', @Id_Estado OUT

SET NOCOUNT ON

INSERT INTO [T_C_Producto]
(
	[Descripción],
	[Id_Estado]
	
)
VALUES
(
	@Descripción,
	@Id_Estado
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_ProductoDelete]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ProductoDelete]
(
	@Id_Producto int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Producto]
WHERE [Id_Producto] = @Id_Producto
GO
/****** Object:  StoredProcedure [dbo].[T_C_SolicitudUpdate]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_SolicitudUpdate]
(
	@Id_Solicitud int,
	@Descripcion varchar(255),
	@FechaSolicitud datetime,
	@FechaRespuesta datetime,
	@UsuarioRespuesta varchar(255),
	@Id_OrdenTrabajo int,
	@Motivo varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Solicitud]
SET [Descripcion] = @Descripcion,
	[FechaSolicitud] = @FechaSolicitud,
	[FechaRespuesta] = @FechaRespuesta,
	[UsuarioRespuesta] = @UsuarioRespuesta,
	[Id_OrdenTrabajo] = @Id_OrdenTrabajo,
	[Motivo] = @Motivo,
	[Id_Estado] = @Id_Estado
WHERE [Id_Solicitud] = @Id_Solicitud
GO
/****** Object:  StoredProcedure [dbo].[T_C_SolicitudSelectAllById_Estado]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_SolicitudSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_Solicitud],
	[Descripcion],
	[FechaSolicitud],
	[FechaRespuesta],
	[UsuarioRespuesta],
	[Id_OrdenTrabajo],
	[Motivo],
	[Id_Estado]
FROM [T_C_Solicitud]
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_SolicitudSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_SolicitudSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Solicitud],
	[Descripcion],
	[FechaSolicitud],
	[FechaRespuesta],
	[UsuarioRespuesta],
	[Id_OrdenTrabajo],
	[Motivo],
	[Id_Estado]
FROM [T_C_Solicitud]
GO
/****** Object:  StoredProcedure [dbo].[T_C_SolicitudSelect]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_SolicitudSelect]
(
	@Id_Solicitud int
)

AS

SET NOCOUNT ON

SELECT [Id_Solicitud],
	[Descripcion],
	[FechaSolicitud],
	[FechaRespuesta],
	[UsuarioRespuesta],
	[Id_OrdenTrabajo],
	[Motivo],
	[Id_Estado]
FROM [T_C_Solicitud]
WHERE [Id_Solicitud] = @Id_Solicitud
GO
/****** Object:  StoredProcedure [dbo].[T_C_SolicitudInsert]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_SolicitudInsert]
(
	@Id_Solicitud int,
	@Descripcion varchar(255),
	@FechaSolicitud datetime,
	@FechaRespuesta datetime,
	@UsuarioRespuesta varchar(255),
	@Id_OrdenTrabajo int,
	@Motivo varchar(255)
)

AS

SET NOCOUNT ON
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Solicitud', @Id_Estado OUT

INSERT INTO [T_C_Solicitud]
(
	[Id_Solicitud],
	[Descripcion],
	[FechaSolicitud],
	[FechaRespuesta],
	[UsuarioRespuesta],
	[Id_OrdenTrabajo],
	[Motivo],
	[Id_Estado]
)
VALUES
(
	@Id_Solicitud,
	@Descripcion,
	@FechaSolicitud,
	@FechaRespuesta,
	@UsuarioRespuesta,
	@Id_OrdenTrabajo,
	@Motivo,
	@Id_Estado
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_SolicitudDeleteAllById_Estado]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_SolicitudDeleteAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Solicitud]
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_SolicitudDelete]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_SolicitudDelete]
(
	@Id_Solicitud int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Solicitud]
WHERE [Id_Solicitud] = @Id_Solicitud
GO
/****** Object:  StoredProcedure [dbo].[T_C_PerfilUpdate]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_PerfilSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_PerfilSelect]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_PerfilSelect]
(
	@Id_Perfil int
)

AS

SET NOCOUNT ON

SELECT [Id_Perfil],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_Perfil]
WHERE [Id_Perfil] = @Id_Perfil
GO
/****** Object:  StoredProcedure [dbo].[T_C_PerfilInsert]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_PerfilDelete]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  Table [dbo].[T_C_PermisosXPerfil]    Script Date: 11/28/2010 01:09:38 ******/
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
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 1)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 2)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 3)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 4)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 5)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 6)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 8)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 9)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 10)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 11)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 12)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 13)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 14)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 15)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 17)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 18)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (3, 19)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (5, 14)
INSERT [dbo].[T_C_PermisosXPerfil] ([Id_Perfil], [Id_Permiso]) VALUES (5, 19)
/****** Object:  StoredProcedure [dbo].[T_C_PermisoSelect]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_PermisoSelect]
(
	@Id_Permiso int
)

AS

SET NOCOUNT ON

SELECT [Id_Permiso],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_Permiso]
WHERE [Id_Permiso] = @Id_Permiso
GO
/****** Object:  StoredProcedure [dbo].[spHelperAsignarCorrelativo]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spHelperAsignarCorrelativo]
(
@Id_Area char(2),
@Id_Equipo char(4) OUT
)
AS

DECLARE @Ultimo int
SET @Ultimo = (SELECT Correlativo FROM T_C_Area WHERE Id_Area = @Id_Area)
UPDATE T_C_Area
SET
Correlativo = @Ultimo + 1,
@Ultimo = @Ultimo + 1
WHERE
	Id_Area = @Id_Area
	
SET @Id_Equipo = @Id_Area +'' + CONVERT(varchar(2),@Ultimo)
GO
/****** Object:  Table [dbo].[T_C_Trabajo]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_TipoMantenimientoUpdate]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoUpdate]
(
	@Id_Tipo int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_TipoMantenimiento]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[Id_Estado] = @Id_Estado
WHERE [Id_Tipo] = @Id_Tipo
GO
/****** Object:  StoredProcedure [dbo].[T_C_TipoMantenimientoSelectAllById_Estado]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_Tipo],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_TipoMantenimiento]
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_TipoMantenimientoSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoSelectAll]

AS

SET NOCOUNT ON

DECLARE @Id_Estado int
EXEC spHelperAsignaEstado 'T_C_TipoMantenimiento',@Id_Estado OUT
SELECT [Id_Tipo],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_TipoMantenimiento]
GO
/****** Object:  StoredProcedure [dbo].[T_C_TipoMantenimientoSelectActivo]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoSelectActivo]

AS

SET NOCOUNT ON

DECLARE @Id_Estado int
EXEC spHelperAsignaEstado 'T_C_TipoMantenimiento',@Id_Estado OUT
SELECT [Id_Tipo],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_TipoMantenimiento]
WHERE Id_Estado=@Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_TipoMantenimientoSelect]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoSelect]
(
	@Id_Tipo int
)

AS

SET NOCOUNT ON

SELECT [Id_Tipo],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_TipoMantenimiento]
WHERE [Id_Tipo] = @Id_Tipo
GO
/****** Object:  Table [dbo].[T_C_Usuario]    Script Date: 11/28/2010 01:09:38 ******/
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
 CONSTRAINT [PK_T_C_Usuario292] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[T_C_Usuario] ([Id_Usuario], [Nombres], [Apellidos], [Telefono], [Direccion], [Fecha_Registro], [Fecha_Nacimiento], [Email], [Contraseña], [Id_Estado], [Id_Perfil]) VALUES (1, N'sergio', N'ramire<', 1234567, N'qwer', CAST(0x00009E0B00000000 AS DateTime), CAST(0x00009E0B00000000 AS DateTime), N'asdasda@asdasd.asds', N'123456', 1, 4)
INSERT [dbo].[T_C_Usuario] ([Id_Usuario], [Nombres], [Apellidos], [Telefono], [Direccion], [Fecha_Registro], [Fecha_Nacimiento], [Email], [Contraseña], [Id_Estado], [Id_Perfil]) VALUES (100, N'Juan', N'Vega', 0, N'Av alegre 3333', CAST(0x00009E3800725395 AS DateTime), CAST(0x00007ED000000000 AS DateTime), N'juan.vega@sdp.pe', N'ok6nXeq/9IJ9vg+CcuUqbg==', 5, 3)
INSERT [dbo].[T_C_Usuario] ([Id_Usuario], [Nombres], [Apellidos], [Telefono], [Direccion], [Fecha_Registro], [Fecha_Nacimiento], [Email], [Contraseña], [Id_Estado], [Id_Perfil]) VALUES (300, N'Juan', N'Leon', 1234015, N'Calle sin nombre 555', CAST(0x00009E390152F0BB AS DateTime), CAST(0x0000730D00000000 AS DateTime), N'jdleon@sdp.pe', N'ok6nXeq/9IJ9vg+CcuUqbg==', 5, 5)
/****** Object:  Table [dbo].[T_C_TurnoTrabajador]    Script Date: 11/28/2010 01:09:38 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_TurnoMantenimientoUpdate]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoUpdate]
(
	@Id_TurnoMantenimiento int,
	@Descripcion varchar(255),
	@HoraInicio float(53),
	@HoraFin float(53),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_TurnoMantenimiento]
SET [Descripcion] = @Descripcion,
	[HoraInicio] = @HoraInicio,
	[HoraFin] = @HoraFin,
	[Id_Estado] = @Id_Estado
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
GO
/****** Object:  StoredProcedure [dbo].[T_C_TurnoMantenimientoSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_TurnoMantenimiento],
	[Descripcion],
	[HoraInicio],
	[HoraFin],
	[Id_Estado]
FROM [T_C_TurnoMantenimiento]
GO
/****** Object:  StoredProcedure [dbo].[T_C_TurnoMantenimientoSelectActivos]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoSelectActivos]
(
	@Id_TurnoMantenimiento int
)

AS
DECLARE @Id_Estado int

EXEC spHelperAsignaEstado 'T_C_TurnoMantenimiento',@Id_Estado OUT

SET NOCOUNT ON

SELECT [Id_TurnoMantenimiento],
	[Descripcion],
	[HoraInicio],
	[HoraFin],
	[Id_Estado]
FROM [T_C_TurnoMantenimiento]
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_TurnoMantenimientoSelect]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoSelect]
(
	@Id_TurnoMantenimiento int
)

AS

SET NOCOUNT ON


SELECT [Id_TurnoMantenimiento],
	[Descripcion],
	[HoraInicio],
	[HoraFin],
	[Id_Estado]
FROM [T_C_TurnoMantenimiento]
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
GO
/****** Object:  StoredProcedure [dbo].[T_C_TurnoMantenimientoInsert]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoInsert]
(
	@Id_TurnoMantenimiento int,
	@Descripcion varchar(255),
	@HoraInicio float(53),
	@HoraFin float(53)
)

AS
DECLARE @Id_Estado int

EXEC spHelperAsignaEstado 'T_C_TurnoMantenimiento',@Id_Estado OUT
SET NOCOUNT ON

INSERT INTO [T_C_TurnoMantenimiento]
(
	[Id_TurnoMantenimiento],
	[Descripcion],
	[HoraInicio],
	[HoraFin],
	[Id_Estado]
)
VALUES
(
	@Id_TurnoMantenimiento,
	@Descripcion,
	@HoraInicio,
	@HoraFin,
	@Id_Estado
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_TurnoMantenimientoDelete]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[T_C_TurnoMantenimientoDelete]
(
	@Id_TurnoMantenimiento int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_TurnoMantenimiento]
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
GO
/****** Object:  StoredProcedure [dbo].[T_C_TipoMantenimientoInsert]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoInsert]
(
	@Nombre varchar(255),
	@Descripcion varchar(255)
)

AS

DECLARE @Id_Estado int
exec spHelperAsignaEstado 'T_C_TipoMantenimiento',@Id_Estado OUT

SET NOCOUNT ON

INSERT INTO [T_C_TipoMantenimiento]
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
/****** Object:  StoredProcedure [dbo].[T_C_TipoMantenimientoDeleteAllById_Estado]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoDeleteAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_TipoMantenimiento]
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_TipoMantenimientoDelete]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoDelete]
(
	@Id_Tipo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_TipoMantenimiento]
WHERE [Id_Tipo] = @Id_Tipo
GO
/****** Object:  StoredProcedure [dbo].[T_C_UsuarioUpdate]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_UsuarioUpdate]
(
	@Id_Usuario int,
	@Nombres varchar(255),
	@Apellidos varchar(255),
	@Telefono int,
	@Direccion varchar(255),
	@Fecha_Registro datetime,
	@Fecha_Nacimiento datetime,
	@Email varchar(255),
	@Contraseña varchar(255),
	@Id_Estado int,
	@Id_Perfil int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Usuario]
SET [Nombres] = @Nombres,
	[Apellidos] = @Apellidos,
	[Telefono] = @Telefono,
	[Direccion] = @Direccion,
	[Fecha_Registro] = @Fecha_Registro,
	[Fecha_Nacimiento] = @Fecha_Nacimiento,
	[Email] = @Email,
	[Contraseña] = @Contraseña,
	[Id_Estado] = @Id_Estado,
	[Id_Perfil] = @Id_Perfil
WHERE [Id_Usuario] = @Id_Usuario
GO
/****** Object:  StoredProcedure [dbo].[T_C_UsuarioSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_UsuarioSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Usuario],
	[Nombres],
	[Apellidos],
	[Telefono],
	[Direccion],
	[Fecha_Registro],
	[Fecha_Nacimiento],
	[Email],
	[Contraseña],
	[Id_Estado],
	[Id_Perfil]
FROM [T_C_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[T_C_UsuarioInsert]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_UsuarioInsert]
(
	@Id_Usuario int,
	@Nombres varchar(255),
	@Apellidos varchar(255),
	@Telefono int,
	@Direccion varchar(255),
	@Fecha_Registro datetime,
	@Fecha_Nacimiento datetime,
	@Email varchar(255),
	@Contraseña varchar(255),
	@Id_Perfil int
)

AS

SET NOCOUNT ON
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Usuario',@Id_Estado OUT

INSERT INTO [T_C_Usuario]
(
	[Id_Usuario],
	[Nombres],
	[Apellidos],
	[Telefono],
	[Direccion],
	[Fecha_Registro],
	[Fecha_Nacimiento],
	[Email],
	[Contraseña],
	[Id_Estado],
	[Id_Perfil]
)
VALUES
(
	@Id_Usuario,
	@Nombres,
	@Apellidos,
	@Telefono,
	@Direccion,
	@Fecha_Registro,
	@Fecha_Nacimiento,
	@Email,
	@Contraseña,
	@Id_Estado,
	@Id_Perfil
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_UsuarioIniciarSesion]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[T_C_UsuarioIniciarSesion]
@Id_Usuario int
as
DECLARE @Id_Estado int
exec spHelperAsignaEstado 'T_C_Usuario',@Id_Estado OUT

SELECT    Id_Usuario,Nombres,Apellidos,Telefono,Direccion,Fecha_Nacimiento,Email,Contraseña,Id_Perfil
FROM         T_C_Usuario
where     Id_Usuario=@Id_Usuario and Id_Estado = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_ModeloUpdate]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ModeloUpdate]
(
	@Id_Modelo smallint,
	@Descripcion varchar(255),
	@Año int,
	@Id_Marca int,
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Modelo]
SET [Descripcion] = @Descripcion,
	[Año] = @Año,
	[Id_Marca] = @Id_Marca,
	[Id_Estado] = @Id_Estado
WHERE [Id_Modelo] = @Id_Modelo
GO
/****** Object:  StoredProcedure [dbo].[T_C_ModeloSelectById_Marca]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ModeloSelectById_Marca](
@Id_Marca int
)

AS

DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Modelo',@Id_Estado OUT

SET NOCOUNT ON

SELECT [Id_Modelo],
	[Descripcion],
	[Año],
	[Id_Marca],
	[Id_Estado]
FROM [T_C_Modelo]
WHERE Id_Estado=@Id_Estado
	and Id_Marca = @Id_Marca
GO
/****** Object:  StoredProcedure [dbo].[T_C_ModeloSelectAll]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ModeloSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Modelo],
	[Descripcion],
	[Año],
	[Id_Marca],
	[Id_Estado]
FROM [T_C_Modelo]
GO
/****** Object:  StoredProcedure [dbo].[T_C_ModeloSelectActivo]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ModeloSelectActivo]

AS

DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Modelo',@Id_Estado OUT

SET NOCOUNT ON

SELECT [Id_Modelo],
	[Descripcion],
	[Año],
	[Id_Marca],
	[Id_Estado]
FROM [T_C_Modelo]
WHERE Id_Estado=@Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_ModeloSelect]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ModeloSelect]
(
	@Id_Modelo smallint
)

AS

SET NOCOUNT ON

SELECT [Id_Modelo],
	[Descripcion],
	[Año],
	[Id_Marca],
	[Id_Estado]
FROM [T_C_Modelo]
WHERE [Id_Modelo] = @Id_Modelo
GO
/****** Object:  StoredProcedure [dbo].[T_C_ModeloInsert]    Script Date: 11/28/2010 01:09:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ModeloInsert]
(
	@Descripcion varchar(255),
	@Año int,
	@Id_Marca int
)

AS

DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Modelo',@Id_Estado OUT

SET NOCOUNT ON

INSERT INTO [T_C_Modelo]
(
	[Descripcion],
	[Año],
	[Id_Marca],
	[Id_Estado]
)
VALUES
(
	@Descripcion,
	@Año,
	@Id_Marca,
	@Id_Estado
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_ModeloDelete]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_ModeloDelete]
(
	@Id_Modelo smallint
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Modelo]
WHERE [Id_Modelo] = @Id_Modelo
GO
/****** Object:  StoredProcedure [dbo].[T_C_PermisoXPerfilSelectById_Perfil]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_PermisoXPerfilSelectById_Perfil](
@Id_Perfil int
)
AS
DECLARE @Id_Estado int
exec spHelperAsignaEstado 'T_C_Permiso', @Id_Estado OUT
SELECT        T_C_PermisosXPerfil.Id_Perfil, T_C_PermisosXPerfil.Id_Permiso, T_C_Permiso.Id_Estado
FROM            T_C_Perfil INNER JOIN
                         T_C_PermisosXPerfil ON T_C_Perfil.Id_Perfil = T_C_PermisosXPerfil.Id_Perfil INNER JOIN
                         T_C_Permiso ON T_C_PermisosXPerfil.Id_Permiso = T_C_Permiso.Id_Permiso
WHERE			T_C_Perfil.Id_Perfil = @Id_Perfil and T_C_Permiso.Id_Estado=@Id_Estado
GO
/****** Object:  Table [dbo].[T_C_Equipo]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Equipo](
	[Id_Equipo] [char](4) NOT NULL,
	[EquipoPadre] [char](4) NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Id_Marca] [int] NOT NULL,
	[Id_Modelo] [int] NOT NULL,
	[Serie] [varchar](255) NOT NULL,
	[Costo] [float] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Fecha_Registro] [datetime] NOT NULL,
	[Fecha_Adquisicion] [datetime] NOT NULL,
	[Id_Area] [char](2) NOT NULL,
	[MaxHoras] [int] NOT NULL,
	[UsoUnico] [bit] NOT NULL,
	[Nivel] [int] NOT NULL,
	[Stock] [int] NOT NULL,
	[CapacidadOperacion] [decimal](5, 2) NULL,
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
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'FI17', NULL, N'Equipo 1', 3, 3, N'12234477', 1245, 15, CAST(0x00009E2C00000000 AS DateTime), CAST(0x00008FE800000000 AS DateTime), N'FI', 40, 0, 1, 2, CAST(2.90 AS Decimal(5, 2)), CAST(18.00 AS Decimal(4, 2)), N'Ladrillo antiacido')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'FI19', N'    ', N'dsfsd', 3, 3, N'1231243', 2151, 15, CAST(0x00009E3500198686 AS DateTime), CAST(0x00009BA500000000 AS DateTime), N'FI', 9, 0, 0, 21, CAST(12.00 AS Decimal(5, 2)), CAST(23.00 AS Decimal(4, 2)), N'hgghjfg')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'FI21', NULL, N'sds', 3, 3, N'21232', 51512, 15, CAST(0x00009E3500C36002 AS DateTime), CAST(0x00009E2200000000 AS DateTime), N'FI', 23, 0, 0, 12, CAST(12.00 AS Decimal(5, 2)), CAST(21.00 AS Decimal(4, 2)), N'fdggf')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'FI23', N'    ', N'fdgfg', 3, 3, N'23423', 12558, 15, CAST(0x00009E3500C3E8DA AS DateTime), CAST(0x00003F8F00000000 AS DateTime), N'FI', 15, 0, 0, 12, CAST(32.00 AS Decimal(5, 2)), CAST(12.00 AS Decimal(4, 2)), N'dfg')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'FI25', NULL, N'hgh', 3, 3, N'1245676', 1522, 15, CAST(0x00009E3500C49782 AS DateTime), CAST(0x000086E400000000 AS DateTime), N'FI', 23, 0, 0, 2, CAST(31.00 AS Decimal(5, 2)), CAST(21.00 AS Decimal(4, 2)), N'gfdgfdgfd')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'FI27', N'    ', N'hhhggg', 3, 3, N'12344554', 1254, 15, CAST(0x00009E3500C5391D AS DateTime), CAST(0x000080A900000000 AS DateTime), N'FI', 23, 0, 0, 12, CAST(12.00 AS Decimal(5, 2)), CAST(12.00 AS Decimal(4, 2)), N'fdgdf')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'FI31', NULL, N'gfdg', 3, 3, N'2134324ds', 12, 15, CAST(0x0000127800000000 AS DateTime), CAST(0x0000127800000000 AS DateTime), N'FI', 12, 0, 1, 222, CAST(12.00 AS Decimal(5, 2)), CAST(21.00 AS Decimal(4, 2)), N'213123')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'FI33', NULL, N'gfdg', 3, 3, N'2134324ds', 12, 15, CAST(0x0000127800000000 AS DateTime), CAST(0x0000127800000000 AS DateTime), N'FI', 12, 0, 1, 222, CAST(12.00 AS Decimal(5, 2)), CAST(21.00 AS Decimal(4, 2)), N'213123')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'FI35', N'SinP', N'DSGFD', 3, 5, N'44R25435', 144, 15, CAST(0x00009E3500CDE6AF AS DateTime), CAST(0x00009E2000000000 AS DateTime), N'FI', 14, 0, 0, 23, CAST(3.00 AS Decimal(5, 2)), CAST(32.00 AS Decimal(4, 2)), N'DGFDFGFD')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'LA1 ', NULL, N'Equipo #2', 3, 3, N'214rew3243', 2561, 15, CAST(0x00009E2C00000000 AS DateTime), CAST(0x00008FE800000000 AS DateTime), N'LA', 40, 0, 1, 2, CAST(2.90 AS Decimal(5, 2)), CAST(18.00 AS Decimal(4, 2)), N'Ladrillo antiacido')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'LA3 ', N'    ', N'sdfs', 3, 3, N'143543', 1250, 15, CAST(0x00009E3500C6775D AS DateTime), CAST(0x00008ED100000000 AS DateTime), N'LA', 23, 0, 0, 12, CAST(32.00 AS Decimal(5, 2)), CAST(22.00 AS Decimal(4, 2)), N'gfghfhgf')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'MO1 ', NULL, N'Equipo #3', 3, 3, N'4365fw32143', 6695, 15, CAST(0x00009E2C00000000 AS DateTime), CAST(0x00008FE800000000 AS DateTime), N'MO', 40, 0, 1, 2, CAST(2.90 AS Decimal(5, 2)), CAST(18.00 AS Decimal(4, 2)), N'Ladrillo antiacido')
INSERT [dbo].[T_C_Equipo] ([Id_Equipo], [EquipoPadre], [Descripcion], [Id_Marca], [Id_Modelo], [Serie], [Costo], [Id_Estado], [Fecha_Registro], [Fecha_Adquisicion], [Id_Area], [MaxHoras], [UsoUnico], [Nivel], [Stock], [CapacidadOperacion], [DiamteroInterno], [RevestimientoInterior]) VALUES (N'RE1 ', NULL, N'Equioi #4', 3, 3, N'545ygfg8876', 1145, 15, CAST(0x00009E2C00000000 AS DateTime), CAST(0x00008FE800000000 AS DateTime), N'RE', 40, 0, 1, 2, CAST(2.90 AS Decimal(5, 2)), CAST(18.00 AS Decimal(4, 2)), N'Ladrillo antiacido')
/****** Object:  Table [dbo].[T_C_OrdenTrabajo]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_OrdenTrabajo](
	[Id_OrdenTrabajo] [int] IDENTITY(1,1) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[T_C_OrdenTrabajo] ON
INSERT [dbo].[T_C_OrdenTrabajo] ([Id_OrdenTrabajo], [Descripcion], [CostoTotal], [FechaRegistro], [UltimaFechaModificacion], [Id_Estado], [Id_Usuario]) VALUES (1, N'odern 1', 30, CAST(0x00009E0B00000000 AS DateTime), CAST(0x00009E0B00000000 AS DateTime), 1, 1)
INSERT [dbo].[T_C_OrdenTrabajo] ([Id_OrdenTrabajo], [Descripcion], [CostoTotal], [FechaRegistro], [UltimaFechaModificacion], [Id_Estado], [Id_Usuario]) VALUES (2, N'odern 1', 30, CAST(0x00009E0B00000000 AS DateTime), CAST(0x00009E0B00000000 AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[T_C_OrdenTrabajo] OFF
/****** Object:  StoredProcedure [dbo].[T_C_EquipoUpdate]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EquipoUpdate]
(
	@Id_Equipo char(4),
	@EquipoPadre char(4),
	@Descripcion varchar(255),
	@Id_Marca int,
	@Id_Modelo smallint,
	@Serie varchar(255),
	@Costo float(53),
	@Id_Estado int,
	@Fecha_Registro datetime,
	@Fecha_Adquisicion datetime,
	@Id_Area char(2),
	@MaxHoras int,
	@UsoUnico smallint,
	@Nivel int,
	@Stock int,
	@CapacidadOperacion decimal(4, 2),
	@DiamteroInterno decimal(4, 2),
	@RevestimientoInterior varchar(50)
)

AS

SET NOCOUNT ON

UPDATE [T_C_Equipo]
SET [EquipoPadre] = @EquipoPadre,
	[Descripcion] = @Descripcion,
	[Id_Marca] = @Id_Marca,
	[Id_Modelo] = @Id_Modelo,
	[Serie] = @Serie,
	[Costo] = @Costo,
	[Id_Estado] = @Id_Estado,
	[Fecha_Registro] = @Fecha_Registro,
	[Fecha_Adquisicion] = @Fecha_Adquisicion,
	[Id_Area] = @Id_Area,
	[MaxHoras] = @MaxHoras,
	[UsoUnico] = @UsoUnico,
	[Nivel] = @Nivel,
	[Stock] = @Stock,
	[CapacidadOperacion] = @CapacidadOperacion,
	[DiamteroInterno] = @DiamteroInterno,
	[RevestimientoInterior] = @RevestimientoInterior
WHERE [Id_Equipo] = @Id_Equipo
GO
/****** Object:  StoredProcedure [dbo].[T_C_EquipoSelectAllById_Equipo]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EquipoSelectAllById_Equipo]
(
	@Id_Equipo char(4)
)

AS

SET NOCOUNT ON

SELECT [Id_Equipo],
	[EquipoPadre],
	[Descripcion],
	[Id_Marca],
	[Id_Modelo],
	[Serie],
	[Costo],
	[Id_Estado],
	[Fecha_Registro],
	[Fecha_Adquisicion],
	[Id_Area],
	[MaxHoras],
	[UsoUnico],
	[Nivel],
	[Stock],
	[CapacidadOperacion],
	[DiamteroInterno],
	[RevestimientoInterior]
FROM [T_C_Equipo]
WHERE [Id_Equipo] = @Id_Equipo
GO
/****** Object:  StoredProcedure [dbo].[T_C_EquipoSelectAll]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EquipoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Equipo],
	[EquipoPadre],
	[Descripcion],
	[Id_Marca],
	[Id_Modelo],
	[Serie],
	[Costo],
	[Id_Estado],
	[Fecha_Registro],
	[Fecha_Adquisicion],
	[Id_Area],
	[MaxHoras],
	[UsoUnico],
	[Nivel],
	[Stock],
	[CapacidadOperacion],
	[DiamteroInterno],
	[RevestimientoInterior]
FROM [T_C_Equipo]
GO
/****** Object:  StoredProcedure [dbo].[T_C_EquipoSelectActivo]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EquipoSelectActivo]

AS

DECLARE @Id_Estado int

EXEC spHelperAsignaEstado 'T_C_Equipo',@Id_Estado OUT

SET NOCOUNT ON

SELECT [Id_Equipo],
	[EquipoPadre],
	[Descripcion],
	[Id_Marca],
	[Id_Modelo],
	[Serie],
	[Costo],
	[Id_Estado],
	[Fecha_Registro],
	[Fecha_Adquisicion],
	[Id_Area],
	[MaxHoras],
	[UsoUnico],
	[Nivel],
	[Stock],
	[CapacidadOperacion],
	[DiamteroInterno],
	[RevestimientoInterior]
FROM [T_C_Equipo]
GO
/****** Object:  StoredProcedure [dbo].[T_C_EquipoInsert]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EquipoInsert]
(
	@EquipoPadre char(4),
	@Descripcion varchar(255),
	@Id_Marca int,
	@Id_Modelo int,
	@Serie varchar(255),
	@Costo float(53),
	@Fecha_Registro datetime,
	@Fecha_Adquisicion datetime,
	@Id_Area char(2),
	@MaxHoras int,
	@UsoUnico bit,
	@Nivel int,
	@Stock int,
	@CapacidadOperacion decimal(4, 2),
	@DiamteroInterno decimal(4, 2),
	@RevestimientoInterior varchar(50)
)

AS

declare @Id_Estado int
declare @Id_Equipo char(4)

exec spHelperAsignaEstado 'T_C_Equipo',@Id_Estado OUT
exec spHelperAsignarCorrelativo @Id_Area,@Id_Equipo OUT

SET NOCOUNT ON

IF(@EquipoPadre = 'SinPadre')
BEGIN
INSERT INTO [T_C_Equipo]
(
	[Id_Equipo],
	[EquipoPadre],
	[Descripcion],
	[Id_Marca],
	[Id_Modelo],
	[Serie],
	[Costo],
	[Id_Estado],
	[Fecha_Registro],
	[Fecha_Adquisicion],
	[Id_Area],
	[MaxHoras],
	[UsoUnico],
	[Nivel],
	[Stock],
	[CapacidadOperacion],
	[DiamteroInterno],
	[RevestimientoInterior]
)
VALUES
(
	@Id_Equipo,
	NULL,
	@Descripcion,
	@Id_Marca,
	@Id_Modelo,
	@Serie,
	@Costo,
	@Id_Estado,
	@Fecha_Registro,
	@Fecha_Adquisicion,
	@Id_Area,
	@MaxHoras,
	@UsoUnico,
	@Nivel,
	@Stock,
	@CapacidadOperacion,
	@DiamteroInterno,
	@RevestimientoInterior
)
END
ELSE
BEGIN
INSERT INTO [T_C_Equipo]
(
	[Id_Equipo],
	[EquipoPadre],
	[Descripcion],
	[Id_Marca],
	[Id_Modelo],
	[Serie],
	[Costo],
	[Id_Estado],
	[Fecha_Registro],
	[Fecha_Adquisicion],
	[Id_Area],
	[MaxHoras],
	[UsoUnico],
	[Nivel],
	[Stock],
	[CapacidadOperacion],
	[DiamteroInterno],
	[RevestimientoInterior]
)
VALUES
(
	@Id_Equipo,
	@EquipoPadre,
	@Descripcion,
	@Id_Marca,
	@Id_Modelo,
	@Serie,
	@Costo,
	@Id_Estado,
	@Fecha_Registro,
	@Fecha_Adquisicion,
	@Id_Area,
	@MaxHoras,
	@UsoUnico,
	@Nivel,
	@Stock,
	@CapacidadOperacion,
	@DiamteroInterno,
	@RevestimientoInterior
)
END
GO
/****** Object:  StoredProcedure [dbo].[T_C_EquipoDelete]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_EquipoDelete]
(
	@Id_Equipo char(4)
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Equipo]
WHERE [Id_Equipo] = @Id_Equipo
GO
/****** Object:  Table [dbo].[T_C_DetalleOrdenDeTrabajo]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_DetalleOrdenDeTrabajo](
	[Id_DetalleOrdendeTrabajo] [int] IDENTITY(1,1) NOT NULL,
	[Id_OrdendeTrabajo] [int] NOT NULL,
	[Costo] [float] NOT NULL,
	[Porcentaje] [float] NOT NULL,
	[Descrippcion] [varchar](255) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Id_Solicitud] [int] NULL,
	[Id_Equipo] [char](4) NULL,
	[FlagEquipo] [bit] NOT NULL,
 CONSTRAINT [PK_T_C_DetalleOrdenDeTrabajo] PRIMARY KEY CLUSTERED 
(
	[Id_DetalleOrdendeTrabajo] ASC,
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
/****** Object:  Table [dbo].[T_C_Alerta]    Script Date: 11/28/2010 01:09:39 ******/
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
/****** Object:  Table [dbo].[T_C_MovimientosEquipo]    Script Date: 11/28/2010 01:09:39 ******/
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
/****** Object:  StoredProcedure [dbo].[T_C_OrdenTrabajoUpdate]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoUpdate]
(
	@Id_OrdenTrabajo int,
	@Descripcion varchar(255),
	@CostoTotal float(53),
	@FechaRegistro datetime,
	@UltimaFechaModificacion datetime,
	@Id_Estado int,
	@Id_Usuario int
)

AS

SET NOCOUNT ON

UPDATE [T_C_OrdenTrabajo]
SET [Descripcion] = @Descripcion,
	[CostoTotal] = @CostoTotal,
	[FechaRegistro] = @FechaRegistro,
	[UltimaFechaModificacion] = @UltimaFechaModificacion,
	[Id_Estado] = @Id_Estado,
	[Id_Usuario] = @Id_Usuario
WHERE [Id_OrdenTrabajo] = @Id_OrdenTrabajo
GO
/****** Object:  StoredProcedure [dbo].[T_C_OrdenTrabajoSelectAllById_Usuario]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoSelectAllById_Usuario]
(
	@Id_Usuario int
)

AS

SET NOCOUNT ON

SELECT [Id_OrdenTrabajo],
	[Descripcion],
	[CostoTotal],
	[FechaRegistro],
	[UltimaFechaModificacion],
	[Id_Estado],
	[Id_Usuario]
FROM [T_C_OrdenTrabajo]
WHERE [Id_Usuario] = @Id_Usuario
GO
/****** Object:  StoredProcedure [dbo].[T_C_OrdenTrabajoSelectAllById_Estado]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_OrdenTrabajo],
	[Descripcion],
	[CostoTotal],
	[FechaRegistro],
	[UltimaFechaModificacion],
	[Id_Estado],
	[Id_Usuario]
FROM [T_C_OrdenTrabajo]
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  StoredProcedure [dbo].[T_C_OrdenTrabajoSelectAll]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_OrdenTrabajo],
	[Descripcion],
	[CostoTotal],
	[FechaRegistro],
	[UltimaFechaModificacion],
	[Id_Estado],
	[Id_Usuario]
FROM [T_C_OrdenTrabajo]
GO
/****** Object:  StoredProcedure [dbo].[T_C_OrdenTrabajoSelect]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoSelect]
(
	@Id_OrdenTrabajo int
)

AS

SET NOCOUNT ON

SELECT [Id_OrdenTrabajo],
	[Descripcion],
	[CostoTotal],
	[FechaRegistro],
	[UltimaFechaModificacion],
	[Id_Estado],
	[Id_Usuario]
FROM [T_C_OrdenTrabajo]
WHERE [Id_OrdenTrabajo] = @Id_OrdenTrabajo
GO
/****** Object:  StoredProcedure [dbo].[T_C_OrdenTrabajoInsert]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoInsert]
(
    @Descripcion varchar(255),
	@CostoTotal float(53),
	@FechaRegistro datetime,
	@UltimaFechaModificacion datetime,
	@Id_Usuario int
)

AS

SET NOCOUNT ON
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_OrdenTrabajo',@Id_Estado OUT

INSERT INTO [T_C_OrdenTrabajo]
(
	[Descripcion],
	[CostoTotal],
	[FechaRegistro],
	[UltimaFechaModificacion],
	[Id_Estado],
	[Id_Usuario]
)
VALUES
(
	@Descripcion,
	@CostoTotal,
	@FechaRegistro,
	@UltimaFechaModificacion,
	@Id_Estado,
	@Id_Usuario
)
SELECT CAST(SCOPE_IDENTITY() as int)
GO
/****** Object:  StoredProcedure [dbo].[T_C_OrdenTrabajoDeleteAllById_Usuario]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoDeleteAllById_Usuario]
(
	@Id_Usuario int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_OrdenTrabajo]
WHERE [Id_Usuario] = @Id_Usuario
GO
/****** Object:  StoredProcedure [dbo].[T_C_OrdenTrabajoDeleteAllById_Estado]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoDeleteAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_OrdenTrabajo]
WHERE [Id_Estado] = @Id_Estado
GO
/****** Object:  Table [dbo].[T_C_DetalleSolicitud]    Script Date: 11/28/2010 01:09:39 ******/
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
/****** Object:  Table [dbo].[T_C_Requerimiento]    Script Date: 11/28/2010 01:09:39 ******/
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
/****** Object:  Table [dbo].[T_C_TipoMantenimientoPorEquipo]    Script Date: 11/28/2010 01:09:39 ******/
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
INSERT [dbo].[T_C_TipoMantenimientoPorEquipo] ([Id_TipoMantenimientoEquipo], [Id_Equipo], [Id_TipoMantenimiento], [Id_Tipo], [Id_Estado]) VALUES (1, N'FI17', 4, 4, 18)
INSERT [dbo].[T_C_TipoMantenimientoPorEquipo] ([Id_TipoMantenimientoEquipo], [Id_Equipo], [Id_TipoMantenimiento], [Id_Tipo], [Id_Estado]) VALUES (2, N'LA1 ', 4, 4, 18)
INSERT [dbo].[T_C_TipoMantenimientoPorEquipo] ([Id_TipoMantenimientoEquipo], [Id_Equipo], [Id_TipoMantenimiento], [Id_Tipo], [Id_Estado]) VALUES (3, N'LA1 ', 5, 4, 18)
/****** Object:  StoredProcedure [dbo].[T_C_TipoMantenimientoPorEquipoSelectActivo]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[T_C_TipoMantenimientoPorEquipoSelectActivo](
@Id_Equipo CHAR(4)
)
as
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_TipoMantenimientoPorEquipo',@Id_Estado OUT

SELECT        T_C_TipoMantenimiento.Id_Tipo, T_C_TipoMantenimiento.Nombre, T_C_TipoMantenimiento.Descripcion,
                         T_C_TipoMantenimientoPorEquipo.Id_TipoMantenimientoEquipo, T_C_TipoMantenimientoPorEquipo.Id_TipoMantenimiento, 
                         T_C_TipoMantenimientoPorEquipo.Id_Tipo AS Expr1, T_C_TipoMantenimientoPorEquipo.Id_Estado, T_C_TipoMantenimientoPorEquipo.Id_Equipo, 
                         T_C_Equipo.Id_Equipo AS Expr3
FROM            T_C_Equipo INNER JOIN
                         T_C_TipoMantenimientoPorEquipo ON T_C_Equipo.Id_Equipo = T_C_TipoMantenimientoPorEquipo.Id_Equipo INNER JOIN
                         T_C_TipoMantenimiento ON T_C_TipoMantenimientoPorEquipo.Id_Tipo = T_C_TipoMantenimiento.Id_Tipo
WHERE			T_C_TipoMantenimientoPorEquipo.Id_Estado = @Id_Estado and T_C_Equipo.Id_Equipo = @Id_Equipo
GO
/****** Object:  Table [dbo].[T_C_Mantenimiento]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_C_Mantenimiento](
	[Id_Mantenimiento] [int] NOT NULL,
	[Id_Equipo] [char](4) NOT NULL,
	[FechaProgramacion] [datetime] NOT NULL,
	[FechaTrabajoInicio] [datetime] NULL,
	[FechaTrabajoFin] [datetime] NULL,
	[UsuarioRegistro] [varchar](255) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[Id_Estado] [int] NOT NULL,
	[Id_TipoMantenimiento] [int] NOT NULL,
	[Id_Incidencia] [int] NULL,
	[Id_Pedido] [int] NOT NULL,
	[Prioridad] [int] NOT NULL,
	[Id_OrdenTrabajo] [int] NULL,
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
INSERT [dbo].[T_C_Mantenimiento] ([Id_Mantenimiento], [Id_Equipo], [FechaProgramacion], [FechaTrabajoInicio], [FechaTrabajoFin], [UsuarioRegistro], [FechaRegistro], [Id_Estado], [Id_TipoMantenimiento], [Id_Incidencia], [Id_Pedido], [Prioridad], [Id_OrdenTrabajo], [Id_TipoMantenimientoEquipo], [Id_TurnoMantenimiento]) VALUES (1, N'1   ', CAST(0x00009E0B00000000 AS DateTime), NULL, NULL, N'1', CAST(0x00009E0B00000000 AS DateTime), 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[T_C_Mantenimiento] ([Id_Mantenimiento], [Id_Equipo], [FechaProgramacion], [FechaTrabajoInicio], [FechaTrabajoFin], [UsuarioRegistro], [FechaRegistro], [Id_Estado], [Id_TipoMantenimiento], [Id_Incidencia], [Id_Pedido], [Prioridad], [Id_OrdenTrabajo], [Id_TipoMantenimientoEquipo], [Id_TurnoMantenimiento]) VALUES (2, N'1   ', CAST(0x00009E0B00000000 AS DateTime), NULL, NULL, N'1', CAST(0x00009E0B00000000 AS DateTime), 1, 1, 1, 1, 1, 2, 1, 2)
/****** Object:  StoredProcedure [dbo].[T_C_DetalleOrdenDeTrabajoSelectAllById_OrdenTrabajo]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_DetalleOrdenDeTrabajoSelectAllById_OrdenTrabajo]
(
	@Id_OrdenTrabajo int
)

AS

SET NOCOUNT ON

SELECT [Id_DetalleOrdendeTrabajo],
	[Id_OrdendeTrabajo],
	[Costo],
	[Porcentaje],
	[Motivo],
	[FechaRegistro],
	[Id_Estado],
	[Cantidad],
	[Id_Solicitud],
	[Id_Equipo]
FROM [T_C_DetalleOrdenDeTrabajo]
WHERE [Id_OrdendeTrabajo] = @Id_OrdenTrabajo
GO
/****** Object:  StoredProcedure [dbo].[T_C_DetalleOrdenDeTrabajoInsert]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_DetalleOrdenDeTrabajoInsert]
(
	@Id_DetalleOrdendeTrabajo int,
	@Id_OrdendeTrabajo int,
	@Costo float(53),
	@Porcentaje float(53),
	@Motivo varchar(255),
	@FechaRegistro datetime,
	@Cantidad int,
	@Id_OrdenTrabajo int,
	@Id_Solicitud int
)

AS

SET NOCOUNT ON
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_DetalleOrdenDeTrabajo',@Id_Estado OUT

INSERT INTO [T_C_DetalleOrdenDeTrabajo]
(
	[Id_DetalleOrdendeTrabajo],
	[Id_OrdendeTrabajo],
	[Costo],
	[Porcentaje],
	[Motivo],
	[FechaRegistro],
	[Id_Estado],
	[Cantidad],
	[Id_Solicitud]
)
VALUES
(
	@Id_DetalleOrdendeTrabajo,
	@Id_OrdendeTrabajo,
	@Costo,
	@Porcentaje,
	@Motivo,
	@FechaRegistro,
	@Id_Estado,
	@Cantidad,
	@Id_Solicitud
)
GO
/****** Object:  StoredProcedure [dbo].[T_C_OrdenTrabajoDelete]    Script Date: 11/28/2010 01:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoDelete]
(
	@Id_OrdenTrabajo int
)

AS

SET NOCOUNT ON
DELETE FROM T_C_DetalleOrdenDeTrabajo 
WHERE Id_OrdendeTrabajo = @Id_OrdenTrabajo

DELETE FROM [T_C_OrdenTrabajo]
WHERE [Id_OrdenTrabajo] = @Id_OrdenTrabajo
GO
/****** Object:  Table [dbo].[T_C_Pedido]    Script Date: 11/28/2010 01:09:39 ******/
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
/****** Object:  ForeignKey [FK_T_C_Estado_T_C_Tabla]    Script Date: 11/28/2010 01:09:37 ******/
ALTER TABLE [dbo].[T_C_Estado]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Estado_T_C_Tabla] FOREIGN KEY([Id_Tabla])
REFERENCES [dbo].[T_C_Tabla] ([Id_Tabla])
GO
ALTER TABLE [dbo].[T_C_Estado] CHECK CONSTRAINT [FK_T_C_Estado_T_C_Tabla]
GO
/****** Object:  ForeignKey [FK_T_C_TurnoMantenimiento_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_TurnoMantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TurnoMantenimiento_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_TurnoMantenimiento] CHECK CONSTRAINT [FK_T_C_TurnoMantenimiento_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Solicitud_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Solicitud_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Solicitud] CHECK CONSTRAINT [FK_T_C_Solicitud_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Producto_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Producto]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Producto_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Producto] CHECK CONSTRAINT [FK_T_C_Producto_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Permiso_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Permiso_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Permiso] CHECK CONSTRAINT [FK_T_C_Permiso_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_TipoMantenimiento_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_TipoMantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TipoMantenimiento_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_TipoMantenimiento] CHECK CONSTRAINT [FK_T_C_TipoMantenimiento_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Incidencia_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Incidencia]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Incidencia_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Incidencia] CHECK CONSTRAINT [FK_T_C_Incidencia_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Marca_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Marca]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Marca_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Marca] CHECK CONSTRAINT [FK_T_C_Marca_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Perfil_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Perfil]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Perfil_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Perfil] CHECK CONSTRAINT [FK_T_C_Perfil_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Area_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Area]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Area_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Area] CHECK CONSTRAINT [FK_T_C_Area_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Modelo_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Modelo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Modelo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Modelo] CHECK CONSTRAINT [FK_T_C_Modelo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Modelo_T_C_Marca]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Modelo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Modelo_T_C_Marca] FOREIGN KEY([Id_Marca])
REFERENCES [dbo].[T_C_Marca] ([Id_Marca])
GO
ALTER TABLE [dbo].[T_C_Modelo] CHECK CONSTRAINT [FK_T_C_Modelo_T_C_Marca]
GO
/****** Object:  ForeignKey [FK_T_C_PermisosXPerfil_T_C_Perfil]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_PermisosXPerfil]  WITH CHECK ADD  CONSTRAINT [FK_T_C_PermisosXPerfil_T_C_Perfil] FOREIGN KEY([Id_Perfil])
REFERENCES [dbo].[T_C_Perfil] ([Id_Perfil])
GO
ALTER TABLE [dbo].[T_C_PermisosXPerfil] CHECK CONSTRAINT [FK_T_C_PermisosXPerfil_T_C_Perfil]
GO
/****** Object:  ForeignKey [FK_T_C_PermisosXPerfil_T_C_Permiso]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_PermisosXPerfil]  WITH CHECK ADD  CONSTRAINT [FK_T_C_PermisosXPerfil_T_C_Permiso] FOREIGN KEY([Id_Permiso])
REFERENCES [dbo].[T_C_Permiso] ([Id_Permiso])
GO
ALTER TABLE [dbo].[T_C_PermisosXPerfil] CHECK CONSTRAINT [FK_T_C_PermisosXPerfil_T_C_Permiso]
GO
/****** Object:  ForeignKey [FK_T_C_Trabajo_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Trabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Trabajo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Trabajo] CHECK CONSTRAINT [FK_T_C_Trabajo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Trabajo_T_C_Producto]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Trabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Trabajo_T_C_Producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[T_C_Producto] ([Id_Producto])
GO
ALTER TABLE [dbo].[T_C_Trabajo] CHECK CONSTRAINT [FK_T_C_Trabajo_T_C_Producto]
GO
/****** Object:  ForeignKey [FK_T_C_Usuario_T_C_Estado]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Usuario_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Usuario] CHECK CONSTRAINT [FK_T_C_Usuario_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Usuario444]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Usuario444] FOREIGN KEY([Id_Perfil])
REFERENCES [dbo].[T_C_Perfil] ([Id_Perfil])
GO
ALTER TABLE [dbo].[T_C_Usuario] CHECK CONSTRAINT [FK_T_C_Usuario444]
GO
/****** Object:  ForeignKey [FK_T_C_TurnoTrabajador_T_C_TurnoMantenimiento]    Script Date: 11/28/2010 01:09:38 ******/
ALTER TABLE [dbo].[T_C_TurnoTrabajador]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TurnoTrabajador_T_C_TurnoMantenimiento] FOREIGN KEY([Id_TurnoMantenimiento])
REFERENCES [dbo].[T_C_TurnoMantenimiento] ([Id_TurnoMantenimiento])
GO
ALTER TABLE [dbo].[T_C_TurnoTrabajador] CHECK CONSTRAINT [FK_T_C_TurnoTrabajador_T_C_TurnoMantenimiento]
GO
/****** Object:  ForeignKey [FK_T_C_Equipo_T_C_Area]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Equipo_T_C_Area] FOREIGN KEY([Id_Area])
REFERENCES [dbo].[T_C_Area] ([Id_Area])
GO
ALTER TABLE [dbo].[T_C_Equipo] CHECK CONSTRAINT [FK_T_C_Equipo_T_C_Area]
GO
/****** Object:  ForeignKey [FK_T_C_Equipo_T_C_Equipo]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Equipo_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_Equipo] CHECK CONSTRAINT [FK_T_C_Equipo_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_Equipo_T_C_Estado]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Equipo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Equipo] CHECK CONSTRAINT [FK_T_C_Equipo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Equipo_T_C_Modelo]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Equipo_T_C_Modelo] FOREIGN KEY([Id_Modelo])
REFERENCES [dbo].[T_C_Modelo] ([Id_Modelo])
GO
ALTER TABLE [dbo].[T_C_Equipo] CHECK CONSTRAINT [FK_T_C_Equipo_T_C_Modelo]
GO
/****** Object:  ForeignKey [FK_T_C_OrdenTrabajo_T_C_Estado]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_OrdenTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_OrdenTrabajo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_OrdenTrabajo] CHECK CONSTRAINT [FK_T_C_OrdenTrabajo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_OrdenTrabajo448]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_OrdenTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_OrdenTrabajo448] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[T_C_Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[T_C_OrdenTrabajo] CHECK CONSTRAINT [FK_T_C_OrdenTrabajo448]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleOrdenDeTrabajo_T_C_Equipo]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo] CHECK CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleOrdenDeTrabajo_T_C_Estado]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo] CHECK CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleOrdenDeTrabajo_T_C_OrdenTrabajo]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_OrdenTrabajo] FOREIGN KEY([Id_OrdendeTrabajo])
REFERENCES [dbo].[T_C_OrdenTrabajo] ([Id_OrdenTrabajo])
GO
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo] CHECK CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_OrdenTrabajo]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleOrdenDeTrabajo_T_C_Solicitud]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Solicitud] FOREIGN KEY([Id_Solicitud])
REFERENCES [dbo].[T_C_Solicitud] ([Id_Solicitud])
GO
ALTER TABLE [dbo].[T_C_DetalleOrdenDeTrabajo] CHECK CONSTRAINT [FK_T_C_DetalleOrdenDeTrabajo_T_C_Solicitud]
GO
/****** Object:  ForeignKey [FK_T_C_Alerta_T_C_Equipo]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Alerta]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Alerta_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_Alerta] CHECK CONSTRAINT [FK_T_C_Alerta_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_Alerta_T_C_Estado]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Alerta]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Alerta_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Alerta] CHECK CONSTRAINT [FK_T_C_Alerta_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_MovimientosEquipo_T_C_Equipo]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_MovimientosEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_MovimientosEquipo_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_MovimientosEquipo] CHECK CONSTRAINT [FK_T_C_MovimientosEquipo_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_MovimientosEquipo_T_C_Estado]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_MovimientosEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_MovimientosEquipo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_MovimientosEquipo] CHECK CONSTRAINT [FK_T_C_MovimientosEquipo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleSolicitud_T_C_Equipo]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_DetalleSolicitud]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleSolicitud_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_DetalleSolicitud] CHECK CONSTRAINT [FK_T_C_DetalleSolicitud_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_DetalleSolicitud_T_C_Solicitud]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_DetalleSolicitud]  WITH CHECK ADD  CONSTRAINT [FK_T_C_DetalleSolicitud_T_C_Solicitud] FOREIGN KEY([Id_Solicitud])
REFERENCES [dbo].[T_C_Solicitud] ([Id_Solicitud])
GO
ALTER TABLE [dbo].[T_C_DetalleSolicitud] CHECK CONSTRAINT [FK_T_C_DetalleSolicitud_T_C_Solicitud]
GO
/****** Object:  ForeignKey [FK_T_C_Requerimiento_T_C_Equipo]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Requerimiento_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_Requerimiento] CHECK CONSTRAINT [FK_T_C_Requerimiento_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_Requerimiento_T_C_Estado]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Requerimiento_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Requerimiento] CHECK CONSTRAINT [FK_T_C_Requerimiento_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Requerimiento_T_C_Producto]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Requerimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Requerimiento_T_C_Producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[T_C_Producto] ([Id_Producto])
GO
ALTER TABLE [dbo].[T_C_Requerimiento] CHECK CONSTRAINT [FK_T_C_Requerimiento_T_C_Producto]
GO
/****** Object:  ForeignKey [FK_T_C_TipoMantenimientoPor436]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TipoMantenimientoPor436] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[T_C_TipoMantenimiento] ([Id_Tipo])
GO
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo] CHECK CONSTRAINT [FK_T_C_TipoMantenimientoPor436]
GO
/****** Object:  ForeignKey [FK_T_C_TipoMantenimientoPorEquipo_T_C_Equipo]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TipoMantenimientoPorEquipo_T_C_Equipo] FOREIGN KEY([Id_Equipo])
REFERENCES [dbo].[T_C_Equipo] ([Id_Equipo])
GO
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo] CHECK CONSTRAINT [FK_T_C_TipoMantenimientoPorEquipo_T_C_Equipo]
GO
/****** Object:  ForeignKey [FK_T_C_TipoMantenimientoPorEquipo_T_C_Estado]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo]  WITH CHECK ADD  CONSTRAINT [FK_T_C_TipoMantenimientoPorEquipo_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_TipoMantenimientoPorEquipo] CHECK CONSTRAINT [FK_T_C_TipoMantenimientoPorEquipo_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento_T_C_Estado]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento_T_C_Incidencia]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento_T_C_Incidencia] FOREIGN KEY([Id_Incidencia])
REFERENCES [dbo].[T_C_Incidencia] ([Id_Incidencia])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento_T_C_Incidencia]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento438]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento438] FOREIGN KEY([Id_OrdenTrabajo])
REFERENCES [dbo].[T_C_OrdenTrabajo] ([Id_OrdenTrabajo])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento438]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento466]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento466] FOREIGN KEY([Id_TipoMantenimientoEquipo])
REFERENCES [dbo].[T_C_TipoMantenimientoPorEquipo] ([Id_TipoMantenimientoEquipo])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento466]
GO
/****** Object:  ForeignKey [FK_T_C_Mantenimiento475]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Mantenimiento475] FOREIGN KEY([Id_TurnoMantenimiento])
REFERENCES [dbo].[T_C_TurnoMantenimiento] ([Id_TurnoMantenimiento])
GO
ALTER TABLE [dbo].[T_C_Mantenimiento] CHECK CONSTRAINT [FK_T_C_Mantenimiento475]
GO
/****** Object:  ForeignKey [FK_T_C_Pedido_T_C_Estado]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Pedido]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Pedido_T_C_Estado] FOREIGN KEY([Id_Estado])
REFERENCES [dbo].[T_C_Estado] ([Id_Estado])
GO
ALTER TABLE [dbo].[T_C_Pedido] CHECK CONSTRAINT [FK_T_C_Pedido_T_C_Estado]
GO
/****** Object:  ForeignKey [FK_T_C_Pedido457]    Script Date: 11/28/2010 01:09:39 ******/
ALTER TABLE [dbo].[T_C_Pedido]  WITH CHECK ADD  CONSTRAINT [FK_T_C_Pedido457] FOREIGN KEY([Id_Mantenimiento])
REFERENCES [dbo].[T_C_Mantenimiento] ([Id_Mantenimiento])
GO
ALTER TABLE [dbo].[T_C_Pedido] CHECK CONSTRAINT [FK_T_C_Pedido457]
GO
