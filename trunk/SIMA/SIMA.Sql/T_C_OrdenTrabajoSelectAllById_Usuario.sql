if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_OrdenTrabajoSelectAllById_Usuario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_OrdenTrabajoSelectAllById_Usuario]
GO

CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoSelectAllById_Usuario]
(
	@Id_Usuario int
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
WHERE [Id_Usuario] = @Id_Usuario
GO
