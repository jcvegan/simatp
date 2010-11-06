if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PedidoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PedidoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_PedidoInsert]
(
	@Id_Pedido int,
	@Usuario_Pedido varchar(255),
	@Fecha_Pedido datetime,
	@UsuarioConfirma varchar(255),
	@FechaConfirma datetime,
	@Id_Estado int,
	@MotivoPedido varchar(255),
	@Id_Mantenimiento int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Pedido]
(
	[Id_Pedido],
	[Usuario_Pedido],
	[Fecha_Pedido],
	[UsuarioConfirma],
	[FechaConfirma],
	[Id_Estado],
	[MotivoPedido],
	[Id_Mantenimiento]
)
VALUES
(
	@Id_Pedido,
	@Usuario_Pedido,
	@Fecha_Pedido,
	@UsuarioConfirma,
	@FechaConfirma,
	@Id_Estado,
	@MotivoPedido,
	@Id_Mantenimiento
)
GO
