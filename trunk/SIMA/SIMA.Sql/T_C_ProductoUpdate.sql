if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ProductoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ProductoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_ProductoUpdate]
(
	@Id_Producto int,
	@Descripción varchar(255),
	@Id_Requerimiento int,
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Producto]
SET [Descripción] = @Descripción,
	[Id_Requerimiento] = @Id_Requerimiento,
	[Id_Estado] = @Id_Estado
WHERE [Id_Producto] = @Id_Producto
GO
