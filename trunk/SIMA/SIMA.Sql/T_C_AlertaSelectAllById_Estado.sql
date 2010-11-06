if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AlertaSelectAllById_Estado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AlertaSelectAllById_Estado]
GO

CREATE PROCEDURE [dbo].[T_C_AlertaSelectAllById_Estado]
(
	@Id_Estado int
)

AS

SET NOCOUNT ON

SELECT [Id_Alerta],
	[Id_Equipo],
	[ACorreo],
	[FechaEnvio],
	[ValorDemanda],
	[Id_Estado]
FROM [T_C_Alerta]
WHERE [Id_Estado] = @Id_Estado
GO
