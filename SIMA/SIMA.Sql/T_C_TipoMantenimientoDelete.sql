if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoDelete]
(
	@Id_Tipo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_TipoMantenimiento]
WHERE [Id_Tipo] = @Id_Tipo
GO
