if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MarcaInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MarcaInsert]
GO

CREATE PROCEDURE [dbo].[T_C_MarcaInsert]
(
	@Id_Marca int,
	@Descripcion varchar(255),
	@Nombre varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Marca]
(
	[Id_Marca],
	[Descripcion],
	[Nombre],
	[Id_Estado]
)
VALUES
(
	@Id_Marca,
	@Descripcion,
	@Nombre,
	@Id_Estado
)
GO
