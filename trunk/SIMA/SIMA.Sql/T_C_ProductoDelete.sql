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

CREATE PROCEDURE [dbo].[T_C_ProductoSelectActivo]

AS
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Producto', @Id_Estado OUT
SET NOCOUNT ON

SELECT [Id_Producto],
	[Descripción],
	[Id_Estado]
FROM [T_C_Producto]
WHERE Id_Estado = @Id_Estado
GO