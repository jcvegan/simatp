if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoInsert]
(
	@Id_Tipo int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_TipoMantenimiento]
(
	[Id_Tipo],
	[Nombre],
	[Descripcion],
	[Id_Estado]
)
VALUES
(
	@Id_Tipo,
	@Nombre,
	@Descripcion,
	@Id_Estado
)
GO
