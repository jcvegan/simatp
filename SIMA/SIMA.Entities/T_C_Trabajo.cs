using System;

namespace SIMA.Entities
{
	public class T_C_Trabajo
	{
		#region Fields

		private int id_Trabajo;
		private int id_Producto;
		private DateTime fechaTrabajo;
		private int horasTrabajo;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Trabajo class.
		/// </summary>
		public T_C_Trabajo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Trabajo class.
		/// </summary>
		public T_C_Trabajo(int id_Trabajo, int id_Producto, DateTime fechaTrabajo, int horasTrabajo, int id_Estado)
		{
			this.id_Trabajo = id_Trabajo;
			this.id_Producto = id_Producto;
			this.fechaTrabajo = fechaTrabajo;
			this.horasTrabajo = horasTrabajo;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Trabajo value.
		/// </summary>
		public virtual int Id_Trabajo
		{
			get { return id_Trabajo; }
			set { id_Trabajo = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Producto value.
		/// </summary>
		public virtual int Id_Producto
		{
			get { return id_Producto; }
			set { id_Producto = value; }
		}

		/// <summary>
		/// Gets or sets the FechaTrabajo value.
		/// </summary>
		public virtual DateTime FechaTrabajo
		{
			get { return fechaTrabajo; }
			set { fechaTrabajo = value; }
		}

		/// <summary>
		/// Gets or sets the HorasTrabajo value.
		/// </summary>
		public virtual int HorasTrabajo
		{
			get { return horasTrabajo; }
			set { horasTrabajo = value; }
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
