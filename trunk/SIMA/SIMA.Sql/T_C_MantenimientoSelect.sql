if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoSelect]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoSelect]
(
	@Id_Mantenimiento int
)

AS

SET NOCOUNT ON

SELECT [Id_Mantenimiento],
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
FROM [T_C_Mantenimiento]
WHERE [Id_Mantenimiento] = @Id_Mantenimiento
GO
