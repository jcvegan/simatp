if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TablaUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TablaUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_TablaUpdate]
(
	@Id_Tabla int,
	@Nombre_Tabla varchar(255),
	@Descripcion_Tabla varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Tabla]
SET [Nombre_Tabla] = @Nombre_Tabla,
	[Descripcion_Tabla] = @Descripcion_Tabla,
	[Id_Estado] = @Id_Estado
WHERE [Id_Tabla] = @Id_Tabla
GO
