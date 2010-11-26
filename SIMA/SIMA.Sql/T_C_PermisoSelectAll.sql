USE [SIMA]
GO
/****** Object:  StoredProcedure [dbo].[T_C_PermisoSelectAll]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
cReate PROCEDURE [dbo].[T_C_PermisoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Permiso],
	[Nombre],
	[Descripcion],
	[Id_Estado]
FROM [T_C_Permiso]
