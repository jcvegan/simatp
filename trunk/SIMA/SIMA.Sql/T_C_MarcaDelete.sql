if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MarcaDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MarcaDelete]
GO

CREATE PROCEDURE [dbo].[T_C_MarcaDelete]
(
	@Id_Marca int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Marca]
WHERE [Id_Marca] = @Id_Marca
GO
