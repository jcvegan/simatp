if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_SolicitudInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_SolicitudInsert]
GO

CREATE PROCEDURE [dbo].[T_C_SolicitudInsert]
(
	@Id_Solicitud int,
	@Descripcion varchar(255),
	@FechaSolicitud datetime,
	@FechaRespuesta datetime,
	@UsuarioRespuesta varchar(255),
	@Id_OrdenTrabajo int,
	@Motivo varchar(255),
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Solicitud]
(
	[Id_Solicitud],
	[Descripcion],
	[FechaSolicitud],
	[FechaRespuesta],
	[UsuarioRespuesta],
	[Id_OrdenTrabajo],
	[Motivo],
	[Id_Estado]
)
VALUES
(
	@Id_Solicitud,
	@Descripcion,
	@FechaSolicitud,
	@FechaRespuesta,
	@UsuarioRespuesta,
	@Id_OrdenTrabajo,
	@Motivo,
	@Id_Estado
)
GO
