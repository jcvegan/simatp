if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoSelect]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoSelect]
(
	@Id_Tipo int
)

AS

SET NOCOUNT ON

SELECT [Id_Tipo],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_TipoMantenimiento]
WHERE [Id_Tipo] = @Id_Tipo
GO
