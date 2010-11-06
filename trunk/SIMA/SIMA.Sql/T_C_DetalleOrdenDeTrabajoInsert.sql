if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleOrdenDeTrabajoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleOrdenDeTrabajoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleOrdenDeTrabajoInsert]
(
	@Id_DetalleOrdendeTrabajo int,
	@Id_OrdendeTrabajo int,
	@Costo float(53),
	@Porcentaje float(53),
	@Motivo varchar(255),
	@FechaRegistro datetime,
	@Id_Estado int,
	@Cantidad int,
	@Id_OrdenTrabajo int,
	@Id_Solicitud int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_DetalleOrdenDeTrabajo]
(
	[Id_DetalleOrdendeTrabajo],
	[Id_OrdendeTrabajo],
	[Costo],
	[Porcentaje],
	[Motivo],
	[FechaRegistro],
	[Id_Estado],
	[Cantidad],
	[Id_OrdenTrabajo],
	[Id_Solicitud]
)
VALUES
(
	@Id_DetalleOrdendeTrabajo,
	@Id_OrdendeTrabajo,
	@Costo,
	@Porcentaje,
	@Motivo,
	@FechaRegistro,
	@Id_Estado,
	@Cantidad,
	@Id_OrdenTrabajo,
	@Id_Solicitud
)
GO
