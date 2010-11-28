CREATE PROCEDURE [dbo].[T_C_MantenimientoSelectPorEquipoEnMantenimiento]
(
	@Id_Equipo char(4)
)

AS
DECLARE @Id_Estado int  
EXEC spHelperAsignaEstado 'T_C_Mantenimiento',@Id_Estado OUT  
SET NOCOUNT ON

SELECT [Id_Mantenimiento],
	[Id_Equipo],
	[FechaProgramacion],
	isnull([FechaTrabajoInicio],'') as FechaTrabajoInicio,
	isnull([FechaTrabajoFin],'') as FechaTrabajoFin,  
	[UsuarioRegistro],
	[FechaRegistro],
	[Id_Estado],
	[Id_TipoMantenimiento],
	[Id_Incidencia],
	[Id_Pedido],
	[Prioridad],
	isnull([Id_OrdenTrabajo],'') as Id_OrdenTrabajo,
	[Id_TipoMantenimientoEquipo],
	[Id_TurnoMantenimiento]
FROM [T_C_Mantenimiento]
WHERE [Id_Equipo] = @Id_Equipo and [Id_Estado] = @Id_Estado
GO
