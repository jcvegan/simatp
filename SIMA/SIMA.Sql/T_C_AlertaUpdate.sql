if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AlertaUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AlertaUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_AlertaUpdate]
(
	@Id_Alerta int,
	@Id_Equipo char(4),
	@ACorreo varchar(255),
	@FechaEnvio datetime,
	@ValorDemanda float(53),
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Alerta]
SET [Id_Equipo] = @Id_Equipo,
	[ACorreo] = @ACorreo,
	[FechaEnvio] = @FechaEnvio,
	[ValorDemanda] = @ValorDemanda,
	[Id_Estado] = @Id_Estado
WHERE [Id_Alerta] = @Id_Alerta
GO
