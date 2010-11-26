if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_ProductoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_ProductoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_ProductoInsert]
(
	@Id_Producto int,
	@Descripción varchar(255)
)

AS
DECLARE @Id_Estado int


SET NOCOUNT ON

INSERT INTO [T_C_Producto]
(
	[Id_Producto],
	[Descripción],
	[Id_Estado]
	
)
VALUES
(
	@Id_Producto,
	@Descripción,
	@Id_Estado
)
GO
