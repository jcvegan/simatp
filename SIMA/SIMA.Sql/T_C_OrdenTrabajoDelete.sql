if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_OrdenTrabajoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_OrdenTrabajoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoDelete]
(
	@Id_OrdenTrabajo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_OrdenTrabajo]
WHERE [Id_OrdenTrabajo] = @Id_OrdenTrabajo
GO
