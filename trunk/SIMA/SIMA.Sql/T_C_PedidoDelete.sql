if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PedidoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PedidoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_PedidoDelete]
(
	@Id_Pedido int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Pedido]
WHERE [Id_Pedido] = @Id_Pedido
GO
