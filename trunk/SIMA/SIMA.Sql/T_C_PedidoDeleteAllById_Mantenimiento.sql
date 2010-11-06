if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PedidoDeleteAllById_Mantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PedidoDeleteAllById_Mantenimiento]
GO

CREATE PROCEDURE [dbo].[T_C_PedidoDeleteAllById_Mantenimiento]
(
	@Id_Mantenimiento int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Pedido]
WHERE [Id_Mantenimiento] = @Id_Mantenimiento
GO
