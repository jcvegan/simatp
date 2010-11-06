if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoMantenimientoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoMantenimientoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoUpdate]
(
	@Id_TurnoMantenimiento int,
	@Descripcion varchar(255),
	@HoraInicio float(53),
	@HoraFin float(53),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_TurnoMantenimiento]
SET [Descripcion] = @Descripcion,
	[HoraInicio] = @HoraInicio,
	[HoraFin] = @HoraFin,
	[Id_Estado] = @Id_Estado
WHERE [Id_TurnoMantenimiento] = @Id_TurnoMantenimiento
GO
