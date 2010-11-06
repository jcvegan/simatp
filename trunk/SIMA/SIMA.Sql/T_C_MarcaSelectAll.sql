if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MarcaSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MarcaSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_MarcaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Marca],
	[Descripcion],
	[Nombre],
	[Id_Estado]
FROM [T_C_Marca]
GO
