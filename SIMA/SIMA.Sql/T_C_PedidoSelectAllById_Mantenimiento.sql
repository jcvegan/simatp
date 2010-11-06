if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PedidoSelectAllById_Mantenimiento]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PedidoSelectAllById_Mantenimiento]
GO

CREATE PROCEDURE [dbo].[T_C_PedidoSelectAllById_Mantenimiento]
(
	@Id_Mantenimiento int
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
WHERE [Id_Mantenimiento] = @Id_Mantenimiento
GO
