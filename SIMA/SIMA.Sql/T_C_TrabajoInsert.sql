if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TrabajoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TrabajoInsert]
GO

CREATE PROCEDURE [dbo].[T_C_TrabajoInsert]
(
	@Id_Trabajo int,
	@Id_Producto int,
	@FechaTrabajo datetime,
	@HorasTrabajo int,
	@Id_Estado int
)

AS

SET NOCOUNT ON

INSERT INTO [T_C_Trabajo]
(
	[Id_Trabajo],
	[Id_Producto],
	[FechaTrabajo],
	[HorasTrabajo],
	[Id_Estado]
)
VALUES
(
	@Id_Trabajo,
	@Id_Producto,
	@FechaTrabajo,
	@HorasTrabajo,
	@Id_Estado
)
GO
