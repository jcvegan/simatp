if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PermisosXPerfilDeleteAllById_Permiso]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PermisosXPerfilDeleteAllById_Permiso]
GO

CREATE PROCEDURE [dbo].[T_C_PermisosXPerfilDeleteAllById_Permiso]
(
	@Id_Permiso int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_PermisosXPerfil]
WHERE [Id_Permiso] = @Id_Permiso
GO
