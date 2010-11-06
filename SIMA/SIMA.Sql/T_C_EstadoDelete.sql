if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EstadoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EstadoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_EstadoDelete]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Estado]
WHERE [Id_Estado] = @Id_Estado
GO
