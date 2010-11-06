if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PermisoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PermisoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_PermisoInsert]
(
	@Id_Permiso int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Permiso]
(
	[Id_Permiso],
	[Nombre],
	[Descripcion],
	[Id_Estado]
)
VALUES
(
	@Id_Permiso,
	@Nombre,
	@Descripcion,
	@Id_Estado
)
GO
