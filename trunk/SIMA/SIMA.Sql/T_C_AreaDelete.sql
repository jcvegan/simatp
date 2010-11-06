if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AreaDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AreaDelete]
GO

CREATE PROCEDURE [dbo].[T_C_AreaDelete]
(
	@Id_Area char(2)
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Area]
WHERE [Id_Area] = @Id_Area
GO
