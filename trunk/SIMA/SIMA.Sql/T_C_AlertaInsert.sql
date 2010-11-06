if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_AlertaInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_AlertaInsert]
GO

CREATE PROCEDURE [dbo].[T_C_AlertaInsert]
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

INSERT INTO [T_C_Alerta]
(
	[Id_Alerta],
	[Id_Equipo],
	[ACorreo],
	[FechaEnvio],
	[ValorDemanda],
	[Id_Estado]
)
VALUES
(
	@Id_Alerta,
	@Id_Equipo,
	@ACorreo,
	@FechaEnvio,
	@ValorDemanda,
	@Id_Estado
)
GO
