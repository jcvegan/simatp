if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MantenimientoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MantenimientoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_MantenimientoDelete]
(
	@Id_Mantenimiento int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Mantenimiento]
WHERE [Id_Mantenimiento] = @Id_Mantenimiento
GO
