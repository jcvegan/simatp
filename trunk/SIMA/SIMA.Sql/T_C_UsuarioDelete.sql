if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_C_UsuarioDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[T_C_UsuarioDelete]
GO

CREATE PROCEDURE [dbo].[T_C_UsuarioDelete]
(
	@Id_Usuario int
)

AS

SET NOCOUNT ON

DELETE FROM [T_C_Usuario]
WHERE [Id_Usuario] = @Id_Usuario
GO
