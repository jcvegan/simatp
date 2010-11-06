if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EstadoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EstadoSelect]
GO

CREATE PROCEDURE [dbo].[T_C_EstadoSelect]
(
	@Id_Estado int
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
WHERE [Id_Estado] = @Id_Estado
GO
