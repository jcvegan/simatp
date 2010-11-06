if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoTrabajadorInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoTrabajadorInsert]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoTrabajadorInsert]
(
	@Id_TurnoMantenimiento int,
	@Id_Trabajador int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_TurnoTrabajador]
(
	[Id_TurnoMantenimiento],
	[Id_Trabajador]
)
VALUES
(
	@Id_TurnoMantenimiento,
	@Id_Trabajador
)
GO
