if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_OrdenTrabajoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_OrdenTrabajoSelect]
GO

CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoSelect]
(
	@Id_OrdenTrabajo int
)

AS

SET NOCOUNT ON

SELECT [Id_OrdenTrabajo],
	[Descripcion],
	[CostoTotal],
	[FechaRegistro],
	[UltimaFechaModificacion],
	[Id_Estado],
	[Id_Usuario]
FROM [T_C_OrdenTrabajo]
WHERE [Id_OrdenTrabajo] = @Id_OrdenTrabajo
GO
