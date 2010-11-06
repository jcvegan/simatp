if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoDeleteAllById_Incidencia]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoDeleteAllById_Incidencia]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoDeleteAllById_Incidencia]
(
	@Id_Incidencia int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Mantenimiento]
WHERE [Id_Incidencia] = @Id_Incidencia
GO
