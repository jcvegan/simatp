if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoPorEquipoSelectAllById_Tipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoPorEquipoSelectAllById_Tipo]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoPorEquipoSelectAllById_Tipo]
(
	@Id_Tipo int
)

AS

SET NOCOUNT ON

SELECT [Id_TipoMantenimientoEquipo],
	[Id_Equipo],
	[Id_TipoMantenimiento],
	[Id_Tipo],
	[Id_Estado]
FROM [T_C_TipoMantenimientoPorEquipo]
WHERE [Id_Tipo] = @Id_Tipo
GO
