if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoPorEquipoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoPorEquipoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoPorEquipoDelete]
(
	@Id_TipoMantenimientoEquipo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_TipoMantenimientoPorEquipo]
WHERE [Id_TipoMantenimientoEquipo] = @Id_TipoMantenimientoEquipo
GO
