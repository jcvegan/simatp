if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AreaDeleteAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AreaDeleteAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_AreaDeleteAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Area]
WHERE [Id_Estado] = @Id_Estado
GO
