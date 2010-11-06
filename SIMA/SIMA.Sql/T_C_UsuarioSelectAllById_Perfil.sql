if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_UsuarioSelectAllById_Perfil]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_UsuarioSelectAllById_Perfil]
GO

CREATE PROCEDURE [dbo].[T_C_UsuarioSelectAllById_Perfil]
(
	@Id_Perfil int
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
WHERE [Id_Perfil] = @Id_Perfil
GO
