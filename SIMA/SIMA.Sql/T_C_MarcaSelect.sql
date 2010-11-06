if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MarcaSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MarcaSelect]
GO

CREATE PROCEDURE [dbo].[T_C_MarcaSelect]
(
	@Id_Marca int
)

AS

SET NOCOUNT ON

SELECT [Id_Marca],
	[Descripcion],
	[Nombre],
	[Id_Estado]
FROM [T_C_Marca]
WHERE [Id_Marca] = @Id_Marca
GO
