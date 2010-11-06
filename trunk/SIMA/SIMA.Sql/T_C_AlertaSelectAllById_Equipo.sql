if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AlertaSelectAllById_Equipo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AlertaSelectAllById_Equipo]
GO

CREATE PROCEDURE [dbo].[T_C_AlertaSelectAllById_Equipo]
(
	@Id_Equipo char(4)
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
WHERE [Id_Equipo] = @Id_Equipo
GO
