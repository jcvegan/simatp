if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleSolicitudInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleSolicitudInsert]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleSolicitudInsert]
(
	@Id_Solicitud int,
	@Id_Equipo char(4),
	@Motivo varchar(255),
	@FechaRegistro datetime,
	@Id_DetalleSolicitud int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_DetalleSolicitud]
(
	[Id_Solicitud],
	[Id_Equipo],
	[Motivo],
	[FechaRegistro],
	[Id_DetalleSolicitud]
)
VALUES
(
	@Id_Solicitud,
	@Id_Equipo,
	@Motivo,
	@FechaRegistro,
	@Id_DetalleSolicitud
)
GO
