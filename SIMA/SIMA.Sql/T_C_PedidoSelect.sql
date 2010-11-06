if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PedidoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PedidoSelect]
GO

CREATE PROCEDURE [dbo].[T_C_PedidoSelect]
(
	@Id_Pedido int
)

AS

SET NOCOUNT ON

SELECT [Id_Pedido],
	[Usuario_Pedido],
	[Fecha_Pedido],
	[UsuarioConfirma],
	[FechaConfirma],
	[Id_Estado],
	[MotivoPedido],
	[Id_Mantenimiento]
FROM [T_C_Pedido]
WHERE [Id_Pedido] = @Id_Pedido
GO
