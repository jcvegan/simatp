using System;

namespace SIMA.Entities
{
	public class T_C_Requerimiento
	{
		#region Fields

		private int id_Requerimiento;
		private int id_Producto;
		private string id_Equipo;
		private int horasTrabajo;
		private float salidaUnidades;
		private string salidaMetricas;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Requerimiento class.
		/// </summary>
		public T_C_Requerimiento()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Requerimiento class.
		/// </summary>
		public T_C_Requerimiento(int id_Requerimiento, int id_Producto, string id_Equipo, int horasTrabajo, float salidaUnidades, string salidaMetricas, int id_Estado)
		{
			this.id_Requerimiento = id_Requerimiento;
			this.id_Producto = id_Producto;
			this.id_Equipo = id_Equipo;
			this.horasTrabajo = horasTrabajo;
			this.salidaUnidades = salidaUnidades;
			this.salidaMetricas = salidaMetricas;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Requerimiento value.
		/// </summary>
		public virtual int Id_Requerimiento
		{
			get { return id_Requerimiento; }
			set { id_Requerimiento = value; }
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
		/// Gets or sets the Id_Equipo value.
		/// </summary>
		public virtual string Id_Equipo
		{
			get { return id_Equipo; }
			set { id_Equipo = value; }
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
		/// Gets or sets the SalidaUnidades value.
		/// </summary>
		public virtual float SalidaUnidades
		{
			get { return salidaUnidades; }
			set { salidaUnidades = value; }
		}

		/// <summary>
		/// Gets or sets the SalidaMetricas value.
		/// </summary>
		public virtual string SalidaMetricas
		{
			get { return salidaMetricas; }
			set { salidaMetricas = value; }
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
