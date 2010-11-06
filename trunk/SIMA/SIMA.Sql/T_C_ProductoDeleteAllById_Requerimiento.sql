if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ProductoDeleteAllById_Requerimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ProductoDeleteAllById_Requerimiento]
GO

CREATE PROCEDURE [dbo].[T_C_ProductoDeleteAllById_Requerimiento]
(
	@Id_Requerimiento int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Producto]
WHERE [Id_Requerimiento] = @Id_Requerimiento
GO
