if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PerfilInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PerfilInsert]
GO

CREATE PROCEDURE [dbo].[T_C_PerfilInsert]
(
	@Id_Perfil int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Perfil]
(
	[Id_Perfil],
	[Nombre],
	[Descripcion],
	[Id_Estado]
)
VALUES
(
	@Id_Perfil,
	@Nombre,
	@Descripcion,
	@Id_Estado
)
GO
