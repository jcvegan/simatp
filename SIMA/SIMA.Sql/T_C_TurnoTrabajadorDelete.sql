if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoTrabajadorDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoTrabajadorDelete]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoTrabajadorDelete]
(
	@Id_TurnoMantenimiento int,
	@Id_Trabajador int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_TurnoTrabajador]
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
	AND [Id_Trabajador] = @Id_Trabajador
GO
