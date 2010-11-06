if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AreaUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AreaUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_AreaUpdate]
(
	@Id_Area char(2),
	@Descripcion varchar(255),
	@Nombre varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Area]
SET [Descripcion] = @Descripcion,
	[Nombre] = @Nombre,
	[Id_Estado] = @Id_Estado
WHERE [Id_Area] = @Id_Area
GO
