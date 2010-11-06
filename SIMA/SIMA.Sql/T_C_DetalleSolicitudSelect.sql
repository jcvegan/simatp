if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleSolicitudSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleSolicitudSelect]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleSolicitudSelect]
(
	@Id_Solicitud int,
	@Id_DetalleSolicitud int
)

AS

SET NOCOUNT ON

SELECT [Id_Solicitud],
	[Id_Equipo],
	[Motivo],
	[FechaRegistro],
	[Id_DetalleSolicitud]
FROM [T_C_DetalleSolicitud]
WHERE [Id_Solicitud] = @Id_Solicitud
	AND [Id_DetalleSolicitud] = @Id_DetalleSolicitud
GO
