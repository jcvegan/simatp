if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PermisosXPerfilSelectAllById_Perfil]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PermisosXPerfilSelectAllById_Perfil]
GO

CREATE PROCEDURE [dbo].[T_C_PermisosXPerfilSelectAllById_Perfil]
(
	@Id_Perfil int
)

AS

SET NOCOUNT ON

SELECT [Id_Perfil],
	[Id_Permiso]
FROM [T_C_PermisosXPerfil]
WHERE [Id_Perfil] = @Id_Perfil
GO