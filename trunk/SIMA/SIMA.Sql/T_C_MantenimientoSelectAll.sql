if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoSelectAll]

AS

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
GO
