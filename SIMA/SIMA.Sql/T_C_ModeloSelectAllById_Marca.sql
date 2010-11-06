if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ModeloSelectAllById_Marca]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ModeloSelectAllById_Marca]
GO

CREATE PROCEDURE [dbo].[T_C_ModeloSelectAllById_Marca]
(
	@Id_Marca int
)

AS

SET NOCOUNT ON

SELECT [Id_Modelo],
	[Descripcion],
	[Año],
	[Id_Marca],
	[Id_Estado]
FROM [T_C_Modelo]
WHERE [Id_Marca] = @Id_Marca
GO
