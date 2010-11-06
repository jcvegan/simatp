if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleOrdenDeTrabajoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleOrdenDeTrabajoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleOrdenDeTrabajoDelete]
(
	@Id_OrdendeTrabajo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_DetalleOrdenDeTrabajo]
WHERE [Id_OrdendeTrabajo] = @Id_OrdendeTrabajo
GO
