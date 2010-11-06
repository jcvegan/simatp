if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_OrdenTrabajoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_OrdenTrabajoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoUpdate]
(
	@Id_OrdenTrabajo int,
	@Descripcion varchar(255),
	@CostoTotal float(53),
	@FechaRegistro datetime,
	@UltimaFechaModificacion datetime,
	@Id_Estado int,
	@Id_Usuario int
)

AS

SET NOCOUNT ON

UPDATE [T_C_OrdenTrabajo]
SET [Descripcion] = @Descripcion,
	[CostoTotal] = @CostoTotal,
	[FechaRegistro] = @FechaRegistro,
	[UltimaFechaModificacion] = @UltimaFechaModificacion,
	[Id_Estado] = @Id_Estado,
	[Id_Usuario] = @Id_Usuario
WHERE [Id_OrdenTrabajo] = @Id_OrdenTrabajo
GO
