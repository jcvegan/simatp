if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ModeloSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ModeloSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_ModeloSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_Modelo],
	[Descripcion],
	[Año],
	[Id_Marca],
	[Id_Estado]
FROM [T_C_Modelo]
WHERE [Id_Estado] = @Id_Estado
GO
