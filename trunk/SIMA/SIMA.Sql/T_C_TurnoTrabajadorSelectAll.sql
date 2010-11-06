if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TurnoTrabajadorSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TurnoTrabajadorSelectAll]
GO

CREATE PROCEDURE [dbo].[T_C_TurnoTrabajadorSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_TurnoMantenimiento],
	[Id_Trabajador]
FROM [T_C_TurnoTrabajador]
GO
