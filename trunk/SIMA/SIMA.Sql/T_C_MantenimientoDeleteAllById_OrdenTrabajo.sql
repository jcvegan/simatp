if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoDeleteAllById_OrdenTrabajo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoDeleteAllById_OrdenTrabajo]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoDeleteAllById_OrdenTrabajo]
(
	@Id_OrdenTrabajo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Mantenimiento]
WHERE [Id_OrdenTrabajo] = @Id_OrdenTrabajo
GO
