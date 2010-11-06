using System;

namespace SIMA
{
	public class T_C_TurnoTrabajador
	{
		#region Fields

		private int id_TurnoMantenimiento;
		private int id_Trabajador;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_TurnoTrabajador class.
		/// </summary>
		public T_C_TurnoTrabajador()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_TurnoTrabajador class.
		/// </summary>
		public T_C_TurnoTrabajador(int id_TurnoMantenimiento, int id_Trabajador)
		{
			this.id_TurnoMantenimiento = id_TurnoMantenimiento;
			this.id_Trabajador = id_Trabajador;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_TurnoMantenimiento value.
		/// </summary>
		public virtual int Id_TurnoMantenimiento
		{
			get { return id_TurnoMantenimiento; }
			set { id_TurnoMantenimiento = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Trabajador value.
		/// </summary>
		public virtual int Id_Trabajador
		{
			get { return id_Trabajador; }
			set { id_Trabajador = value; }
		}

		#endregion
	}
}
