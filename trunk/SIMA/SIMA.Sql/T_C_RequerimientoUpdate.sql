if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_RequerimientoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_RequerimientoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_RequerimientoUpdate]
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

UPDATE [T_C_Requerimiento]
SET [Id_Producto] = @Id_Producto,
	[Id_Equipo] = @Id_Equipo,
	[HorasTrabajo] = @HorasTrabajo,
	[SalidaUnidades] = @SalidaUnidades,
	[SalidaMetricas] = @SalidaMetricas,
	[Id_Estado] = @Id_Estado
WHERE [Id_Requerimiento] = @Id_Requerimiento
GO
