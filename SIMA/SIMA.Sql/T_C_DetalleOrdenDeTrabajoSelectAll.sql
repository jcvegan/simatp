if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleOrdenDeTrabajoSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleOrdenDeTrabajoSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleOrdenDeTrabajoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_DetalleOrdendeTrabajo],
	[Id_OrdendeTrabajo],
	[Costo],
	[Porcentaje],
	[Motivo],
	[FechaRegistro],
	[Id_Estado],
	[Cantidad],
	[Id_OrdenTrabajo],
	[Id_Solicitud]
FROM [T_C_DetalleOrdenDeTrabajo]
GO
