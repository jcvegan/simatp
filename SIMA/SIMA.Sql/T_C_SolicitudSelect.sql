if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_SolicitudSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_SolicitudSelect]
GO

CREATE PROCEDURE [dbo].[T_C_SolicitudSelect]
(
	@Id_Solicitud int
)

AS

SET NOCOUNT ON

SELECT [Id_Solicitud],
	[Descripcion],
	[FechaSolicitud],
	[FechaRespuesta],
	[UsuarioRespuesta],
	[Id_OrdenTrabajo],
	[Motivo],
	[Id_Estado]
FROM [T_C_Solicitud]
WHERE [Id_Solicitud] = @Id_Solicitud
GO
