if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleSolicitudDeleteAllById_Solicitud]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleSolicitudDeleteAllById_Solicitud]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleSolicitudDeleteAllById_Solicitud]
(
	@Id_Solicitud int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_DetalleSolicitud]
WHERE [Id_Solicitud] = @Id_Solicitud
GO
