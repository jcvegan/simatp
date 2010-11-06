if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_OrdenTrabajoSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_OrdenTrabajoSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoSelectAllById_Estado]
(
	@Id_Estado int
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
WHERE [Id_Estado] = @Id_Estado
GO
