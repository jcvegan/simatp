if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TablaSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TablaSelect]
GO

CREATE PROCEDURE [dbo].[T_C_TablaSelect]
(
	@Id_Tabla int
)

AS

SET NOCOUNT ON

SELECT [Id_Tabla],
	[Nombre_Tabla],
	[Descripcion_Tabla],
	[Id_Estado]
FROM [T_C_Tabla]
WHERE [Id_Tabla] = @Id_Tabla
GO
