if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_IncidenciaInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_IncidenciaInsert]
GO

CREATE PROCEDURE [dbo].[T_C_IncidenciaInsert]
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

INSERT INTO [T_C_Incidencia]
(
	[Id_Incidencia],
	[Usuario_Responsable],
	[Usuario_Registro],
	[Fecha_Incidencia],
	[Fecha_Reporte],
	[Descripcion],
	[Id_Estado]
)
VALUES
(
	@Id_Incidencia,
	@Usuario_Responsable,
	@Usuario_Registro,
	@Fecha_Incidencia,
	@Fecha_Reporte,
	@Descripcion,
	@Id_Estado
)
GO
