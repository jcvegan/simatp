if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EquipoSelectAllById_Equipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EquipoSelectAllById_Equipo]
GO

CREATE PROCEDURE [dbo].[T_C_EquipoSelectAllById_Equipo]
(
	@Id_Equipo char(4)
)

AS

SET NOCOUNT ON

SELECT [Id_Equipo],
	[EquipoPadre],
	[Descripcion],
	[Id_Marca],
	[Id_Modelo],
	[Serie],
	[Costo],
	[Id_Estado],
	[Fecha_Registro],
	[Fecha_Adquisicion],
	[Id_Area],
	[MaxHoras],
	[UsoUnico],
	[Nivel],
	[Stock],
	[CapacidadOperacion],
	[DiamteroInterno],
	[RevestimientoInterior]
FROM [T_C_Equipo]
WHERE [Id_Equipo] = @Id_Equipo
GO
