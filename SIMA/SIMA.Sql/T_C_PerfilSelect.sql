if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PerfilSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PerfilSelect]
GO

CREATE PROCEDURE [dbo].[T_C_PerfilSelect]
(
	@Id_Perfil int
)

AS

SET NOCOUNT ON

SELECT [Id_Perfil],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_Perfil]
WHERE [Id_Perfil] = @Id_Perfil
GO
