if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EquipoDeleteAllById_Area]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EquipoDeleteAllById_Area]
GO

CREATE PROCEDURE [dbo].[T_C_EquipoDeleteAllById_Area]
(
	@Id_Area char(2)
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Equipo]
WHERE [Id_Area] = @Id_Area
GO
