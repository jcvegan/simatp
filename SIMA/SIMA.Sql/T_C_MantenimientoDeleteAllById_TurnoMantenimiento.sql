if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoDeleteAllById_TurnoMantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoDeleteAllById_TurnoMantenimiento]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoDeleteAllById_TurnoMantenimiento]
(
	@Id_TurnoMantenimiento int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Mantenimiento]
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
GO
