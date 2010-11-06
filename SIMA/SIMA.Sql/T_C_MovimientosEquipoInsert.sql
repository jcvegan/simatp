if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MovimientosEquipoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MovimientosEquipoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_MovimientosEquipoInsert]
(
	@Id_Movimiento int,
	@Id_Equipo char(4),
	@Id_AEquipo char(4),
	@FechaMovimiento datetime,
	@Observacion varchar(255),
	@Usuario_Registro varchar(255),
	@Fecha_Registro datetime,
	@Id_OrdenDeTrabajo int,
	@EsMantenimiento smallint,
	@EsIngreso smallint,
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_MovimientosEquipo]
(
	[Id_Movimiento],
	[Id_Equipo],
	[Id_AEquipo],
	[FechaMovimiento],
	[Observacion],
	[Usuario_Registro],
	[Fecha_Registro],
	[Id_OrdenDeTrabajo],
	[EsMantenimiento],
	[EsIngreso],
	[Id_Estado]
)
VALUES
(
	@Id_Movimiento,
	@Id_Equipo,
	@Id_AEquipo,
	@FechaMovimiento,
	@Observacion,
	@Usuario_Registro,
	@Fecha_Registro,
	@Id_OrdenDeTrabajo,
	@EsMantenimiento,
	@EsIngreso,
	@Id_Estado
)
GO
