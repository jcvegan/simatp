if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ModeloUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ModeloUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_ModeloUpdate]
(
	@Id_Modelo smallint,
	@Descripcion varchar(255),
	@Año int,
	@Id_Marca int,
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Modelo]
SET [Descripcion] = @Descripcion,
	[Año] = @Año,
	[Id_Marca] = @Id_Marca,
	[Id_Estado] = @Id_Estado
WHERE [Id_Modelo] = @Id_Modelo
GO
