if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_UsuarioUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_UsuarioUpdate]
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
