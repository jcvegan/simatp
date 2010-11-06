if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_UsuarioInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_UsuarioInsert]
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
	@Id_Estado int,
	@Id_Perfil int,
	@Id_TurnoMantenimiento int,
	@Id_Trabajador int
)

AS

SET NOCOUNT ON

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
	[Id_Perfil],
	[Id_TurnoMantenimiento],
	[Id_Trabajador]
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
	@Id_Perfil,
	@Id_TurnoMantenimiento,
	@Id_Trabajador
)
GO
