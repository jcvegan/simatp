if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ModeloSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ModeloSelect]
GO

CREATE PROCEDURE [dbo].[T_C_ModeloSelect]
(
	@Id_Modelo smallint
)

AS

SET NOCOUNT ON

SELECT [Id_Modelo],
	[Descripcion],
	[Año],
	[Id_Marca],
	[Id_Estado]
FROM [T_C_Modelo]
WHERE [Id_Modelo] = @Id_Modelo
GO
