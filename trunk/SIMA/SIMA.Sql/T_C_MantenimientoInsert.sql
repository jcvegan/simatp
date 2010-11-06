if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoInsert]
(
	@Id_Mantenimiento int,
	@Id_Turno int,
	@Id_Equipo char(4),
	@FechaProgramacion datetime,
	@FechaTrabajoInicio datetime,
	@FechaTrabajoFin datetime,
	@UsuarioRegistro varchar(255),
	@FechaRegistro datetime,
	@Id_Estado int,
	@Id_TipoMantenimiento int,
	@Id_Incidencia int,
	@Id_Pedido int,
	@Prioridad int,
	@Id_OrdenTrabajo int,
	@Id_TipoMantenimientoEquipo int,
	@Id_TurnoMantenimiento int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Mantenimiento]
(
	[Id_Mantenimiento],
	[Id_Turno],
	[Id_Equipo],
	[FechaProgramacion],
	[FechaTrabajoInicio],
	[FechaTrabajoFin],
	[UsuarioRegistro],
	[FechaRegistro],
	[Id_Estado],
	[Id_TipoMantenimiento],
	[Id_Incidencia],
	[Id_Pedido],
	[Prioridad],
	[Id_OrdenTrabajo],
	[Id_TipoMantenimientoEquipo],
	[Id_TurnoMantenimiento]
)
VALUES
(
	@Id_Mantenimiento,
	@Id_Turno,
	@Id_Equipo,
	@FechaProgramacion,
	@FechaTrabajoInicio,
	@FechaTrabajoFin,
	@UsuarioRegistro,
	@FechaRegistro,
	@Id_Estado,
	@Id_TipoMantenimiento,
	@Id_Incidencia,
	@Id_Pedido,
	@Prioridad,
	@Id_OrdenTrabajo,
	@Id_TipoMantenimientoEquipo,
	@Id_TurnoMantenimiento
)
GO
