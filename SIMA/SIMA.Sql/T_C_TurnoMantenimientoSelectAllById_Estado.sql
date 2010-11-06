if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoMantenimientoSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoMantenimientoSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_TurnoMantenimiento],
	[Descripcion],
	[HoraInicio],
	[HoraFin],
	[Id_Estado]
FROM [T_C_TurnoMantenimiento]
WHERE [Id_Estado] = @Id_Estado
GO
