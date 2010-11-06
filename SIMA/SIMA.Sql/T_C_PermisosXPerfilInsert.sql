if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PermisosXPerfilInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PermisosXPerfilInsert]
GO

CREATE PROCEDURE [dbo].[T_C_PermisosXPerfilInsert]
(
	@Id_Perfil int,
	@Id_Permiso int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_PermisosXPerfil]
(
	[Id_Perfil],
	[Id_Permiso]
)
VALUES
(
	@Id_Perfil,
	@Id_Permiso
)
GO
