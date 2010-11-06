if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TrabajoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TrabajoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_TrabajoDelete]
(
	@Id_Trabajo int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Trabajo]
WHERE [Id_Trabajo] = @Id_Trabajo
GO
