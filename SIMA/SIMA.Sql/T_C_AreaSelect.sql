if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AreaSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AreaSelect]
GO

CREATE PROCEDURE [dbo].[T_C_AreaSelect]
(
	@Id_Area char(2)
)

AS

SET NOCOUNT ON

SELECT [Id_Area],
	[Descripcion],
	[Nombre],
	[Id_Estado]
FROM [T_C_Area]
WHERE [Id_Area] = @Id_Area
GO
