USE [SIMA]
GO
/****** Object:  StoredProcedure [dbo].[T_C_PermisoUpdate]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[T_C_PermisoUpdate]
(
	@Id_Permiso int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Permiso]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[Id_Estado] = @Id_Estado
WHERE [Id_Permiso] = @Id_Permiso
