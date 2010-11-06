if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_TrabajoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_TrabajoUpdate]
GO

CREATE PROCEDURE [dbo].[T_C_TrabajoUpdate]
(
	@Id_Trabajo int,
	@Id_Producto int,
	@FechaTrabajo datetime,
	@HorasTrabajo int,
	@Id_Estado int
)

AS

SET NOCOUNT ON

UPDATE [T_C_Trabajo]
SET [Id_Producto] = @Id_Producto,
	[FechaTrabajo] = @FechaTrabajo,
	[HorasTrabajo] = @HorasTrabajo,
	[Id_Estado] = @Id_Estado
WHERE [Id_Trabajo] = @Id_Trabajo
GO
