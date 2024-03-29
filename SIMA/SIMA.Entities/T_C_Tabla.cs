using System;

namespace SIMA.Entities
{
	public class T_C_Tabla
	{
		#region Fields

		private int id_Tabla;
		private string nombre_Tabla;
        private string descripcion_Tabla;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Tabla class.
		/// </summary>
		public T_C_Tabla()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Tabla class.
		/// </summary>
		public T_C_Tabla(int id_Tabla, string nombre_Tabla, string descripcion_Tabla)
		{
			this.id_Tabla = id_Tabla;
			this.nombre_Tabla = nombre_Tabla;
			this.descripcion_Tabla = descripcion_Tabla;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Tabla value.
		/// </summary>
		public virtual int Id_Tabla
		{
			get { return id_Tabla; }
			set { id_Tabla = value; }
		}

		/// <summary>
		/// Gets or sets the Nombre_Tabla value.
		/// </summary>
		public virtual string Nombre_Tabla
		{
			get { return nombre_Tabla; }
			set { nombre_Tabla = value; }
		}

		/// <summary>
		/// Gets or sets the Descripcion_Tabla value.
		/// </summary>
		public virtual string Descripcion_Tabla
		{
			get { return descripcion_Tabla; }
			set { descripcion_Tabla = value; }
		}

		#endregion
	}
}
