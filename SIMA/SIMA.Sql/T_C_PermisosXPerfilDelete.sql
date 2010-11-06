if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PermisosXPerfilDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PermisosXPerfilDelete]
GO

CREATE PROCEDURE [dbo].[T_C_PermisosXPerfilDelete]
(
	@Id_Perfil int,
	@Id_Permiso int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_PermisosXPerfil]
WHERE [Id_Perfil] = @Id_Perfil
	AND [Id_Permiso] = @Id_Permiso
GO
