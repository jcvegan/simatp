if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EstadoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EstadoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_EstadoInsert]
(
	@Id_Tabla int,
	@Nombre_Estado varchar(255),
	@Descripcion_Estado varchar(255),
	@Por_Defecto smallint,
	@Muestra_Informacion smallint
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Estado]
(
	[Id_Tabla],
	[Nombre_Estado],
	[Descripcion_Estado],
	[Por_Defecto],
	[Muestra_Informacion]
)
VALUES
(
	@Id_Tabla,
	@Nombre_Estado,
	@Descripcion_Estado,
	@Por_Defecto,
	@Muestra_Informacion
)

SELECT SCOPE_IDENTITY()
GO
