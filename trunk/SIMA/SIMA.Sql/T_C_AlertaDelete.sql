if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AlertaDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AlertaDelete]
GO

CREATE PROCEDURE [dbo].[T_C_AlertaDelete]
(
	@Id_Alerta int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Alerta]
WHERE [Id_Alerta] = @Id_Alerta
GO
