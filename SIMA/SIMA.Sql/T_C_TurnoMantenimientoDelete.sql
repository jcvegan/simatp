if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoMantenimientoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoMantenimientoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoDelete]
(
	@Id_TurnoMantenimiento int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_TurnoMantenimiento]
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
GO
