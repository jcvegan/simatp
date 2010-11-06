if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_OrdenTrabajoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_OrdenTrabajoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_OrdenTrabajoInsert]
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

INSERT INTO [T_C_OrdenTrabajo]
(
	[Id_OrdenTrabajo],
	[Descripcion],
	[CostoTotal],
	[FechaRegistro],
	[UltimaFechaModificacion],
	[Id_Estado],
	[Id_Usuario]
)
VALUES
(
	@Id_OrdenTrabajo,
	@Descripcion,
	@CostoTotal,
	@FechaRegistro,
	@UltimaFechaModificacion,
	@Id_Estado,
	@Id_Usuario
)
GO
