if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ProductoSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ProductoSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_ProductoSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_Producto],
	[Descripción],
	[Id_Requerimiento],
	[Id_Estado]
FROM [T_C_Producto]
WHERE [Id_Estado] = @Id_Estado
GO
