CREATE PROC T_C_TipoMantenimientoPorEquipoSelectActivo(
@Id_Equipo CHAR(4)
)
as
DECLARE @Id_Estado int

exec spHelperAsignaEstado 'T_C_TipoMantenimientoPorEquipo',@Id_Estado OUT

SELECT        T_C_TipoMantenimiento.Id_Tipo, T_C_TipoMantenimiento.Nombre, T_C_TipoMantenimiento.Descripcion,
                         T_C_TipoMantenimientoPorEquipo.Id_TipoMantenimientoEquipo, T_C_TipoMantenimientoPorEquipo.Id_TipoMantenimiento, 
                         T_C_TipoMantenimientoPorEquipo.Id_Tipo AS Expr1, T_C_TipoMantenimientoPorEquipo.Id_Estado, T_C_TipoMantenimientoPorEquipo.Id_Equipo, 
                         T_C_Equipo.Id_Equipo AS Expr3
FROM            T_C_Equipo INNER JOIN
                         T_C_TipoMantenimientoPorEquipo ON T_C_Equipo.Id_Equipo = T_C_TipoMantenimientoPorEquipo.Id_Equipo INNER JOIN
                         T_C_TipoMantenimiento ON T_C_TipoMantenimientoPorEquipo.Id_Tipo = T_C_TipoMantenimiento.Id_Tipo
WHERE			T_C_TipoMantenimientoPorEquipo.Id_Estado = @Id_Estado and T_C_Equipo.Id_Equipo = @Id_Equipo
GO