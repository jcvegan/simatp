if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TrabajoSelectAllById_Producto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TrabajoSelectAllById_Producto]
GO

CREATE PROCEDURE [dbo].[T_C_TrabajoSelectAllById_Producto]
(
	@Id_Producto int
)

AS

SET NOCOUNT ON

SELECT [Id_Trabajo],
	[Id_Producto],
	[FechaTrabajo],
	[HorasTrabajo],
	[Id_Estado]
FROM [T_C_Trabajo]
WHERE [Id_Producto] = @Id_Producto
GO
