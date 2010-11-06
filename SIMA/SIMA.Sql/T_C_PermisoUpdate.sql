if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PermisoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PermisoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_PermisoUpdate]
(
	@Id_Permiso int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Permiso]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[Id_Estado] = @Id_Estado
WHERE [Id_Permiso] = @Id_Permiso
GO
