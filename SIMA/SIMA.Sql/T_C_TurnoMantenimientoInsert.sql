if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoMantenimientoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoMantenimientoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoMantenimientoInsert]
(
	@Id_TurnoMantenimiento int,
	@Descripcion varchar(255),
	@HoraInicio float(53),
	@HoraFin float(53),
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_TurnoMantenimiento]
(
	[Id_TurnoMantenimiento],
	[Descripcion],
	[HoraInicio],
	[HoraFin],
	[Id_Estado]
)
VALUES
(
	@Id_TurnoMantenimiento,
	@Descripcion,
	@HoraInicio,
	@HoraFin,
	@Id_Estado
)
GO
