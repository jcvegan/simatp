if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TrabajoSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TrabajoSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_TrabajoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Trabajo],
	[Id_Producto],
	[FechaTrabajo],
	[HorasTrabajo],
	[Id_Estado]
FROM [T_C_Trabajo]
GO
