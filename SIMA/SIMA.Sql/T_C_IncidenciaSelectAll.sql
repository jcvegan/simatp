if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_IncidenciaSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_IncidenciaSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_IncidenciaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Incidencia],
	[Usuario_Responsable],
	[Usuario_Registro],
	[Fecha_Incidencia],
	[Fecha_Reporte],
	[Descripcion],
	[Id_Estado]
FROM [T_C_Incidencia]
GO
