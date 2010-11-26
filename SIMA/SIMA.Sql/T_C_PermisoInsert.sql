USE [SIMA]
GO
/****** Object:  StoredProcedure [dbo].[T_C_PermisoInsert]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[T_C_PermisoInsert]
(
	@Nombre varchar(255),
	@Descripcion varchar(255)
)

AS

SET NOCOUNT ON
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_Permiso',@Id_Estado OUT

INSERT INTO [T_C_Permiso]
(
	[Nombre],
	[Descripcion],
	[Id_Estado]
)
VALUES
(
	@Nombre,
	@Descripcion,
	@Id_Estado
)
