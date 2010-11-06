using System;

namespace SIMA
{
	public class T_C_TipoMantenimientoPorEquipo
	{
		#region Fields

		private int id_TipoMantenimientoEquipo;
		private string id_Equipo;
		private int id_TipoMantenimiento;
		private int id_Tipo;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_TipoMantenimientoPorEquipo class.
		/// </summary>
		public T_C_TipoMantenimientoPorEquipo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_TipoMantenimientoPorEquipo class.
		/// </summary>
		public T_C_TipoMantenimientoPorEquipo(int id_TipoMantenimientoEquipo, string id_Equipo, int id_TipoMantenimiento, int id_Tipo, int id_Estado)
		{
			this.id_TipoMantenimientoEquipo = id_TipoMantenimientoEquipo;
			this.id_Equipo = id_Equipo;
			this.id_TipoMantenimiento = id_TipoMantenimiento;
			this.id_Tipo = id_Tipo;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_TipoMantenimientoEquipo value.
		/// </summary>
		public virtual int Id_TipoMantenimientoEquipo
		{
			get { return id_TipoMantenimientoEquipo; }
			set { id_TipoMantenimientoEquipo = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Equipo value.
		/// </summary>
		public virtual string Id_Equipo
		{
			get { return id_Equipo; }
			set { id_Equipo = value; }
		}

		/// <summary>
		/// Gets or sets the Id_TipoMantenimiento value.
		/// </summary>
		public virtual int Id_TipoMantenimiento
		{
			get { return id_TipoMantenimiento; }
			set { id_TipoMantenimiento = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Tipo value.
		/// </summary>
		public virtual int Id_Tipo
		{
			get { return id_Tipo; }
			set { id_Tipo = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Estado value.
		/// </summary>
		public virtual int Id_Estado
		{
			get { return id_Estado; }
			set { id_Estado = value; }
		}

		#endregion
	}
}
