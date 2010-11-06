if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleOrdenDeTrabajoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleOrdenDeTrabajoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleOrdenDeTrabajoUpdate]
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

UPDATE [T_C_DetalleOrdenDeTrabajo]
SET [Id_DetalleOrdendeTrabajo] = @Id_DetalleOrdendeTrabajo,
	[Costo] = @Costo,
	[Porcentaje] = @Porcentaje,
	[Motivo] = @Motivo,
	[FechaRegistro] = @FechaRegistro,
	[Id_Estado] = @Id_Estado,
	[Cantidad] = @Cantidad,
	[Id_OrdenTrabajo] = @Id_OrdenTrabajo,
	[Id_Solicitud] = @Id_Solicitud
WHERE [Id_OrdendeTrabajo] = @Id_OrdendeTrabajo
GO
