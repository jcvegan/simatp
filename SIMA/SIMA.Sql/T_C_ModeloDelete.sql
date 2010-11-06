if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ModeloDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ModeloDelete]
GO

CREATE PROCEDURE [dbo].[T_C_ModeloDelete]
(
	@Id_Modelo smallint
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Modelo]
WHERE [Id_Modelo] = @Id_Modelo
GO
