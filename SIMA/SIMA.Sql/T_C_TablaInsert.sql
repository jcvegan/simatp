if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TablaInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TablaInsert]
GO

CREATE PROCEDURE [dbo].[T_C_TablaInsert]
(
	@Id_Tabla int,
	@Nombre_Tabla varchar(255),
	@Descripcion_Tabla varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Tabla]
(
	[Id_Tabla],
	[Nombre_Tabla],
	[Descripcion_Tabla],
	[Id_Estado]
)
VALUES
(
	@Id_Tabla,
	@Nombre_Tabla,
	@Descripcion_Tabla,
	@Id_Estado
)
GO
