if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PermisoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PermisoSelect]
GO

CREATE PROCEDURE [dbo].[T_C_PermisoSelect]
(
	@Id_Permiso int
)

AS

SET NOCOUNT ON

SELECT [Id_Permiso],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_Permiso]
WHERE [Id_Permiso] = @Id_Permiso
GO
