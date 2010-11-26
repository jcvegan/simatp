if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ProductoSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ProductoSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_ProductoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Producto],
	[Descripción],
	[Id_Estado]
FROM [T_C_Producto]
GO
