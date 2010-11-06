if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EstadoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EstadoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_EstadoUpdate]
(
	@Id_Estado int,
	@Id_Tabla int,
	@Nombre_Estado varchar(255),
	@Descripcion_Estado varchar(255),
	@Por_Defecto smallint,
	@Muestra_Informacion smallint
)

AS

SET NOCOUNT ON

UPDATE [T_C_Estado]
SET [Id_Tabla] = @Id_Tabla,
	[Nombre_Estado] = @Nombre_Estado,
	[Descripcion_Estado] = @Descripcion_Estado,
	[Por_Defecto] = @Por_Defecto,
	[Muestra_Informacion] = @Muestra_Informacion
WHERE [Id_Estado] = @Id_Estado
GO
