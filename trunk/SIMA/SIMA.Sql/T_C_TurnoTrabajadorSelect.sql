if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoTrabajadorSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoTrabajadorSelect]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoTrabajadorSelect]
(
	@Id_TurnoMantenimiento int,
	@Id_Trabajador int
)

AS

SET NOCOUNT ON

SELECT [Id_TurnoMantenimiento],
	[Id_Trabajador]
FROM [T_C_TurnoTrabajador]
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
	AND [Id_Trabajador] = @Id_Trabajador
GO
