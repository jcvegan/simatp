if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_MovimientosEquipoDeleteAllById_Equipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_MovimientosEquipoDeleteAllById_Equipo]
GO

CREATE PROCEDURE [dbo].[T_C_MovimientosEquipoDeleteAllById_Equipo]
(
	@Id_Equipo char(4)
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_MovimientosEquipo]
WHERE [Id_Equipo] = @Id_Equipo
GO
