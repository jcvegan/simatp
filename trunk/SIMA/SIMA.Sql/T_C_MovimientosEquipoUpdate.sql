if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MovimientosEquipoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MovimientosEquipoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_MovimientosEquipoUpdate]
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

UPDATE [T_C_MovimientosEquipo]
SET [Id_Equipo] = @Id_Equipo,
	[Id_AEquipo] = @Id_AEquipo,
	[FechaMovimiento] = @FechaMovimiento,
	[Observacion] = @Observacion,
	[Usuario_Registro] = @Usuario_Registro,
	[Fecha_Registro] = @Fecha_Registro,
	[Id_OrdenDeTrabajo] = @Id_OrdenDeTrabajo,
	[EsMantenimiento] = @EsMantenimiento,
	[EsIngreso] = @EsIngreso,
	[Id_Estado] = @Id_Estado
WHERE [Id_Movimiento] = @Id_Movimiento
GO
