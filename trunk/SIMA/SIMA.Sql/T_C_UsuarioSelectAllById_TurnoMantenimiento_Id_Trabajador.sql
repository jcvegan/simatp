if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_UsuarioSelectAllById_TurnoMantenimiento_Id_Trabajador]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_UsuarioSelectAllById_TurnoMantenimiento_Id_Trabajador]
GO

CREATE PROCEDURE [dbo].[T_C_UsuarioSelectAllById_TurnoMantenimiento_Id_Trabajador]
(
	@Id_TurnoMantenimiento int,
	@Id_Trabajador int
)

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
	[Id_Perfil],
	[Id_TurnoMantenimiento],
	[Id_Trabajador]
FROM [T_C_Usuario]
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
	AND [Id_Trabajador] = @Id_Trabajador
GO
