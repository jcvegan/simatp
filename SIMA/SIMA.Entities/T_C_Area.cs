using System;

namespace SIMA
{
	public class T_C_Area
	{
		#region Fields

		private string id_Area;
		private string descripcion;
		private string nombre;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Area class.
		/// </summary>
		public T_C_Area()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Area class.
		/// </summary>
		public T_C_Area(string id_Area, string descripcion, string nombre, int id_Estado)
		{
			this.id_Area = id_Area;
			this.descripcion = descripcion;
			this.nombre = nombre;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Area value.
		/// </summary>
		public virtual string Id_Area
		{
			get { return id_Area; }
			set { id_Area = value; }
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
		/// Gets or sets the Nombre value.
		/// </summary>
		public virtual string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
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
