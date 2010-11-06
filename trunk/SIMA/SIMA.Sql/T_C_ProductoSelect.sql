if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ProductoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ProductoSelect]
GO

CREATE PROCEDURE [dbo].[T_C_ProductoSelect]
(
	@Id_Producto int
)

AS

SET NOCOUNT ON

SELECT [Id_Producto],
	[Descripción],
	[Id_Requerimiento],
	[Id_Estado]
FROM [T_C_Producto]
WHERE [Id_Producto] = @Id_Producto
GO
