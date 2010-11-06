if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EquipoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EquipoDelete]
GO

CREATE PROCEDURE [dbo].[T_C_EquipoDelete]
(
	@Id_Equipo char(4)
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Equipo]
WHERE [Id_Equipo] = @Id_Equipo
GO
