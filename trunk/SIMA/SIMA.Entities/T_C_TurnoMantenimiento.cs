using System;

namespace SIMA.Entities
{
	public class T_C_TurnoMantenimiento
	{
		#region Fields

		private int id_TurnoMantenimiento;
		private string descripcion;
		private float horaInicio;
		private float horaFin;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_TurnoMantenimiento class.
		/// </summary>
		public T_C_TurnoMantenimiento()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_TurnoMantenimiento class.
		/// </summary>
		public T_C_TurnoMantenimiento(int id_TurnoMantenimiento, string descripcion, float horaInicio, float horaFin, int id_Estado)
		{
			this.id_TurnoMantenimiento = id_TurnoMantenimiento;
			this.descripcion = descripcion;
			this.horaInicio = horaInicio;
			this.horaFin = horaFin;
			this.id_Estado = id_Estado;
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
		/// Gets or sets the Descripcion value.
		/// </summary>
		public virtual string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		/// <summary>
		/// Gets or sets the HoraInicio value.
		/// </summary>
		public virtual float HoraInicio
		{
			get { return horaInicio; }
			set { horaInicio = value; }
		}

		/// <summary>
		/// Gets or sets the HoraFin value.
		/// </summary>
		public virtual float HoraFin
		{
			get { return horaFin; }
			set { horaFin = value; }
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
