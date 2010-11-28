if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoUpdate]
(
	@Id_Mantenimiento int,
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

UPDATE [T_C_Mantenimiento]
SET 
	[Id_Equipo] = @Id_Equipo,
	[FechaProgramacion] = @FechaProgramacion,
	[FechaTrabajoInicio] = @FechaTrabajoInicio,
	[FechaTrabajoFin] = @FechaTrabajoFin,
	[UsuarioRegistro] = @UsuarioRegistro,
	[FechaRegistro] = @FechaRegistro,
	[Id_Estado] = @Id_Estado,
	[Id_TipoMantenimiento] = @Id_TipoMantenimiento,
	[Id_Incidencia] = @Id_Incidencia,
	[Id_Pedido] = @Id_Pedido,
	[Prioridad] = @Prioridad,
	[Id_OrdenTrabajo] = @Id_OrdenTrabajo,
	[Id_TipoMantenimientoEquipo] = @Id_TipoMantenimientoEquipo,
	[Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
WHERE [Id_Mantenimiento] = @Id_Mantenimiento
GO
