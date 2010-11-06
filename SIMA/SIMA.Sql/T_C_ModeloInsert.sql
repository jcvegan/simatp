if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ModeloInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ModeloInsert]
GO

CREATE PROCEDURE [dbo].[T_C_ModeloInsert]
(
	@Id_Modelo smallint,
	@Descripcion varchar(255),
	@Año int,
	@Id_Marca int,
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Modelo]
(
	[Id_Modelo],
	[Descripcion],
	[Año],
	[Id_Marca],
	[Id_Estado]
)
VALUES
(
	@Id_Modelo,
	@Descripcion,
	@Año,
	@Id_Marca,
	@Id_Estado
)
GO
