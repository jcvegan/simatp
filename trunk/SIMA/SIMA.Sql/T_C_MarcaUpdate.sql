if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MarcaUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MarcaUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_MarcaUpdate]
(
	@Id_Marca int,
	@Descripcion varchar(255),
	@Nombre varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Marca]
SET [Descripcion] = @Descripcion,
	[Nombre] = @Nombre,
	[Id_Estado] = @Id_Estado
WHERE [Id_Marca] = @Id_Marca
GO
