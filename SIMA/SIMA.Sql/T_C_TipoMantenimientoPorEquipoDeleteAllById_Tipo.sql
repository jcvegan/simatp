if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoPorEquipoDeleteAllById_Tipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoPorEquipoDeleteAllById_Tipo]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoPorEquipoDeleteAllById_Tipo]
(
	@Id_Tipo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_TipoMantenimientoPorEquipo]
WHERE [Id_Tipo] = @Id_Tipo
GO
