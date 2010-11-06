if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoPorEquipoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoPorEquipoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoPorEquipoUpdate]
(
	@Id_TipoMantenimientoEquipo int,
	@Id_Equipo char(4),
	@Id_TipoMantenimiento int,
	@Id_Tipo int,
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_TipoMantenimientoPorEquipo]
SET [Id_Equipo] = @Id_Equipo,
	[Id_TipoMantenimiento] = @Id_TipoMantenimiento,
	[Id_Tipo] = @Id_Tipo,
	[Id_Estado] = @Id_Estado
WHERE [Id_TipoMantenimientoEquipo] = @Id_TipoMantenimientoEquipo
GO
