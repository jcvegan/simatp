if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_SolicitudDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_SolicitudDelete]
GO

CREATE PROCEDURE [dbo].[T_C_SolicitudDelete]
(
	@Id_Solicitud int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Solicitud]
WHERE [Id_Solicitud] = @Id_Solicitud
GO
