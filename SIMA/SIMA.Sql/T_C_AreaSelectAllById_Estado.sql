if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AreaSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AreaSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_AreaSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_Area],
	[Descripcion],
	[Nombre],
	[Id_Estado]
FROM [T_C_Area]
WHERE [Id_Estado] = @Id_Estado
GO
