if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EquipoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EquipoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_EquipoInsert]
(
	@Id_Equipo char(4),
	@EquipoPadre char(4),
	@Descripcion varchar(255),
	@Id_Marca int,
	@Id_Modelo smallint,
	@Serie varchar(255),
	@Costo float(53),
	@Id_Estado int,
	@Fecha_Registro datetime,
	@Fecha_Adquisicion datetime,
	@Id_Area char(2),
	@MaxHoras int,
	@UsoUnico smallint,
	@Nivel int,
	@Stock int,
	@CapacidadOperacion decimal(4, 2),
	@DiamteroInterno decimal(4, 2),
	@RevestimientoInterior varchar(50)
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Equipo]
(
	[Id_Equipo],
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
)
VALUES
(
	@Id_Equipo,
	@EquipoPadre,
	@Descripcion,
	@Id_Marca,
	@Id_Modelo,
	@Serie,
	@Costo,
	@Id_Estado,
	@Fecha_Registro,
	@Fecha_Adquisicion,
	@Id_Area,
	@MaxHoras,
	@UsoUnico,
	@Nivel,
	@Stock,
	@CapacidadOperacion,
	@DiamteroInterno,
	@RevestimientoInterior
)
GO
