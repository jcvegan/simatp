if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MovimientosEquipoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MovimientosEquipoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_MovimientosEquipoDelete]
(
	@Id_Movimiento int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_MovimientosEquipo]
WHERE [Id_Movimiento] = @Id_Movimiento
GO
