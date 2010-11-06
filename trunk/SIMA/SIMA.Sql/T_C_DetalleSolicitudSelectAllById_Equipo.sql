if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleSolicitudSelectAllById_Equipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleSolicitudSelectAllById_Equipo]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleSolicitudSelectAllById_Equipo]
(
	@Id_Equipo char(4)
)

AS

SET NOCOUNT ON

SELECT [Id_Solicitud],
	[Id_Equipo],
	[Motivo],
	[FechaRegistro],
	[Id_DetalleSolicitud]
FROM [T_C_DetalleSolicitud]
WHERE [Id_Equipo] = @Id_Equipo
GO
