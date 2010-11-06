if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_EquipoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_EquipoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_EquipoUpdate]
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

UPDATE [T_C_Equipo]
SET [EquipoPadre] = @EquipoPadre,
	[Descripcion] = @Descripcion,
	[Id_Marca] = @Id_Marca,
	[Id_Modelo] = @Id_Modelo,
	[Serie] = @Serie,
	[Costo] = @Costo,
	[Id_Estado] = @Id_Estado,
	[Fecha_Registro] = @Fecha_Registro,
	[Fecha_Adquisicion] = @Fecha_Adquisicion,
	[Id_Area] = @Id_Area,
	[MaxHoras] = @MaxHoras,
	[UsoUnico] = @UsoUnico,
	[Nivel] = @Nivel,
	[Stock] = @Stock,
	[CapacidadOperacion] = @CapacidadOperacion,
	[DiamteroInterno] = @DiamteroInterno,
	[RevestimientoInterior] = @RevestimientoInterior
WHERE [Id_Equipo] = @Id_Equipo
GO
