if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoTrabajadorSelectAllById_TurnoMantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoTrabajadorSelectAllById_TurnoMantenimiento]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoTrabajadorSelectAllById_TurnoMantenimiento]
(
	@Id_TurnoMantenimiento int
)

AS

SET NOCOUNT ON

SELECT [Id_TurnoMantenimiento],
	[Id_Trabajador]
FROM [T_C_TurnoTrabajador]
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
GO
