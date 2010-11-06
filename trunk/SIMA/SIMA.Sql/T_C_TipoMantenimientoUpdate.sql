if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TipoMantenimientoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TipoMantenimientoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_TipoMantenimientoUpdate]
(
	@Id_Tipo int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_TipoMantenimiento]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[Id_Estado] = @Id_Estado
WHERE [Id_Tipo] = @Id_Tipo
GO
