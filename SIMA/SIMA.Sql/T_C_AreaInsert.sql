if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AreaInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AreaInsert]
GO

CREATE PROCEDURE [dbo].[T_C_AreaInsert]
(
	@Id_Area char(2),
	@Descripcion varchar(255),
	@Nombre varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Area]
(
	[Id_Area],
	[Descripcion],
	[Nombre],
	[Id_Estado]
)
VALUES
(
	@Id_Area,
	@Descripcion,
	@Nombre,
	@Id_Estado
)
GO
