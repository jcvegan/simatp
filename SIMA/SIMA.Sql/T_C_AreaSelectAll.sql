if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AreaSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AreaSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_AreaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Area],
	[Descripcion],
	[Nombre],
	[Id_Estado]
FROM [T_C_Area]
GO
