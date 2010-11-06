if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PermisoSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PermisoSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_PermisoSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_Permiso],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_Permiso]
WHERE [Id_Estado] = @Id_Estado
GO
