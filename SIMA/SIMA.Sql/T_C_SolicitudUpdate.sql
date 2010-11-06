if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_SolicitudUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_SolicitudUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_SolicitudUpdate]
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

UPDATE [T_C_Solicitud]
SET [Descripcion] = @Descripcion,
	[FechaSolicitud] = @FechaSolicitud,
	[FechaRespuesta] = @FechaRespuesta,
	[UsuarioRespuesta] = @UsuarioRespuesta,
	[Id_OrdenTrabajo] = @Id_OrdenTrabajo,
	[Motivo] = @Motivo,
	[Id_Estado] = @Id_Estado
WHERE [Id_Solicitud] = @Id_Solicitud
GO
