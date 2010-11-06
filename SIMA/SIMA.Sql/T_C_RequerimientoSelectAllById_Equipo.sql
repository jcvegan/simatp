if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_RequerimientoSelectAllById_Equipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_RequerimientoSelectAllById_Equipo]
GO

CREATE PROCEDURE [dbo].[T_C_RequerimientoSelectAllById_Equipo]
(
	@Id_Equipo char(4)
)

AS

SET NOCOUNT ON

SELECT [Id_Requerimiento],
	[Id_Producto],
	[Id_Equipo],
	[HorasTrabajo],
	[SalidaUnidades],
	[SalidaMetricas],
	[Id_Estado]
FROM [T_C_Requerimiento]
WHERE [Id_Equipo] = @Id_Equipo
GO
