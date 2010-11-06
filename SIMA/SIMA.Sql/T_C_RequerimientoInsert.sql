if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_RequerimientoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_RequerimientoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_RequerimientoInsert]
(
	@Id_Requerimiento int,
	@Id_Producto int,
	@Id_Equipo char(4),
	@HorasTrabajo int,
	@SalidaUnidades float(53),
	@SalidaMetricas varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Requerimiento]
(
	[Id_Requerimiento],
	[Id_Producto],
	[Id_Equipo],
	[HorasTrabajo],
	[SalidaUnidades],
	[SalidaMetricas],
	[Id_Estado]
)
VALUES
(
	@Id_Requerimiento,
	@Id_Producto,
	@Id_Equipo,
	@HorasTrabajo,
	@SalidaUnidades,
	@SalidaMetricas,
	@Id_Estado
)
GO
