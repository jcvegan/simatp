if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoPorEquipoSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoPorEquipoSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoPorEquipoSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_TipoMantenimientoEquipo],
	[Id_Equipo],
	[Id_TipoMantenimiento],
	[Id_Tipo],
	[Id_Estado]
FROM [T_C_TipoMantenimientoPorEquipo]
WHERE [Id_Estado] = @Id_Estado
GO
