using System;

namespace SIMA
{
	public class T_C_Marca
	{
		#region Fields

		private int id_Marca;
		private string descripcion;
		private string nombre;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Marca class.
		/// </summary>
		public T_C_Marca()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Marca class.
		/// </summary>
		public T_C_Marca(int id_Marca, string descripcion, string nombre, int id_Estado)
		{
			this.id_Marca = id_Marca;
			this.descripcion = descripcion;
			this.nombre = nombre;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Marca value.
		/// </summary>
		public virtual int Id_Marca
		{
			get { return id_Marca; }
			set { id_Marca = value; }
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
