if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_DetalleSolicitudDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_DetalleSolicitudDelete]
GO

CREATE PROCEDURE [dbo].[T_C_DetalleSolicitudDelete]
(
	@Id_Solicitud int,
	@Id_DetalleSolicitud int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_DetalleSolicitud]
WHERE [Id_Solicitud] = @Id_Solicitud
	AND [Id_DetalleSolicitud] = @Id_DetalleSolicitud
GO
