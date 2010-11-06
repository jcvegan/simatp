if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ProductoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ProductoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_ProductoDelete]
(
	@Id_Producto int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Producto]
WHERE [Id_Producto] = @Id_Producto
GO
