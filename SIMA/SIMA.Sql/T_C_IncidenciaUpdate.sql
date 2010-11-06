if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_IncidenciaUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_IncidenciaUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_IncidenciaUpdate]
(
	@Id_Incidencia int,
	@Usuario_Responsable varchar(255),
	@Usuario_Registro varchar(255),
	@Fecha_Incidencia datetime,
	@Fecha_Reporte datetime,
	@Descripcion varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Incidencia]
SET [Usuario_Responsable] = @Usuario_Responsable,
	[Usuario_Registro] = @Usuario_Registro,
	[Fecha_Incidencia] = @Fecha_Incidencia,
	[Fecha_Reporte] = @Fecha_Reporte,
	[Descripcion] = @Descripcion,
	[Id_Estado] = @Id_Estado
WHERE [Id_Incidencia] = @Id_Incidencia
GO
