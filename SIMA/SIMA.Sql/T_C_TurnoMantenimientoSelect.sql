if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoMantenimientoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoMantenimientoSelect]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoSelect]
(
	@Id_TurnoMantenimiento int
)

AS

SET NOCOUNT ON

SELECT [Id_TurnoMantenimiento],
	[Descripcion],
	[HoraInicio],
	[HoraFin],
	[Id_Estado]
FROM [T_C_TurnoMantenimiento]
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
GO
