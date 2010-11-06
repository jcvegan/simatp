if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MovimientosEquipoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MovimientosEquipoSelect]
GO

CREATE PROCEDURE [dbo].[T_C_MovimientosEquipoSelect]
(
	@Id_Movimiento int
)

AS

SET NOCOUNT ON

SELECT [Id_Movimiento],
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
FROM [T_C_MovimientosEquipo]
WHERE [Id_Movimiento] = @Id_Movimiento
GO
