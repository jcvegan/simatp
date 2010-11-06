if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_IncidenciaSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_IncidenciaSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_IncidenciaSelectAllById_Estado]
(
	@Id_Estado int
)

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
WHERE [Id_Estado] = @Id_Estado
GO
