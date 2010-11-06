if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ModeloDeleteAllById_Marca]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ModeloDeleteAllById_Marca]
GO

CREATE PROCEDURE [dbo].[T_C_ModeloDeleteAllById_Marca]
(
	@Id_Marca int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Modelo]
WHERE [Id_Marca] = @Id_Marca
GO
