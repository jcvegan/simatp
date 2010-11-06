if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TablaDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TablaDelete]
GO

CREATE PROCEDURE [dbo].[T_C_TablaDelete]
(
	@Id_Tabla int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Tabla]
WHERE [Id_Tabla] = @Id_Tabla
GO
