if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_PedidoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_PedidoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_PedidoUpdate]
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

UPDATE [T_C_Pedido]
SET [Usuario_Pedido] = @Usuario_Pedido,
	[Fecha_Pedido] = @Fecha_Pedido,
	[UsuarioConfirma] = @UsuarioConfirma,
	[FechaConfirma] = @FechaConfirma,
	[Id_Estado] = @Id_Estado,
	[MotivoPedido] = @MotivoPedido,
	[Id_Mantenimiento] = @Id_Mantenimiento
WHERE [Id_Pedido] = @Id_Pedido
GO
