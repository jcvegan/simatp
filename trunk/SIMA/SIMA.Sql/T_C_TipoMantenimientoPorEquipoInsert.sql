if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoPorEquipoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoPorEquipoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoPorEquipoInsert]
(
	@Id_TipoMantenimientoEquipo int,
	@Id_Equipo char(4),
	@Id_TipoMantenimiento int,
	@Id_Tipo int,
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_TipoMantenimientoPorEquipo]
(
	[Id_TipoMantenimientoEquipo],
	[Id_Equipo],
	[Id_TipoMantenimiento],
	[Id_Tipo],
	[Id_Estado]
)
VALUES
(
	@Id_TipoMantenimientoEquipo,
	@Id_Equipo,
	@Id_TipoMantenimiento,
	@Id_Tipo,
	@Id_Estado
)
GO
