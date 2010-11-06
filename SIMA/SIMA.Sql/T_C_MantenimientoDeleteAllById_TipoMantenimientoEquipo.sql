if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoDeleteAllById_TipoMantenimientoEquipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoDeleteAllById_TipoMantenimientoEquipo]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoDeleteAllById_TipoMantenimientoEquipo]
(
	@Id_TipoMantenimientoEquipo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Mantenimiento]
WHERE [Id_TipoMantenimientoEquipo] = @Id_TipoMantenimientoEquipo
GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoDeleteAllById_TipoMantenimientoEquipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoDeleteAllById_TipoMantenimientoEquipo]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoDeleteAllById_TipoMantenimientoEquipo]
(
	@Id_TipoMantenimientoEquipo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Mantenimiento]
WHERE [Id_TipoMantenimientoEquipo] = @Id_TipoMantenimientoEquipo
GO
