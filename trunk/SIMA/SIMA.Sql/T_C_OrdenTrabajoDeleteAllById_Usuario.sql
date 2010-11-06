if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_OrdenTrabajoDeleteAllById_Usuario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_OrdenTrabajoDeleteAllById_Usuario]
GO

CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoDeleteAllById_Usuario]
(
	@Id_Usuario int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_OrdenTrabajo]
WHERE [Id_Usuario] = @Id_Usuario
GO
