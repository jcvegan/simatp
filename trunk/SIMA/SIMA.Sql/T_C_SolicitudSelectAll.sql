if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_SolicitudSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_SolicitudSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_SolicitudSelectAll]

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
GO
