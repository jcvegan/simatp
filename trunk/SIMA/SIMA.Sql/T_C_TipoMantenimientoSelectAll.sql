if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Tipo],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_TipoMantenimiento]
GO
