if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_RequerimientoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_RequerimientoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_RequerimientoDelete]
(
	@Id_Requerimiento int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Requerimiento]
WHERE [Id_Requerimiento] = @Id_Requerimiento
GO
