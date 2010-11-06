if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleSolicitudUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleSolicitudUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleSolicitudUpdate]
(
	@Id_Solicitud int,
	@Id_Equipo char(4),
	@Motivo varchar(255),
	@FechaRegistro datetime,
	@Id_DetalleSolicitud int
)

AS

SET NOCOUNT ON

UPDATE [T_C_DetalleSolicitud]
SET [Id_Equipo] = @Id_Equipo,
	[Motivo] = @Motivo,
	[FechaRegistro] = @FechaRegistro,
WHERE [Id_Solicitud] = @Id_Solicitud	AND [Id_DetalleSolicitud] = @Id_DetalleSolicitud
GO
