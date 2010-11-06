if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EstadoSelectAllById_Tabla]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EstadoSelectAllById_Tabla]
GO

CREATE PROCEDURE [dbo].[T_C_EstadoSelectAllById_Tabla]
(
	@Id_Tabla int
)

AS

SET NOCOUNT ON

SELECT [Id_Estado],
	[Id_Tabla],
	[Nombre_Estado],
	[Descripcion_Estado],
	[Por_Defecto],
	[Muestra_Informacion]
FROM [T_C_Estado]
WHERE [Id_Tabla] = @Id_Tabla
GO
