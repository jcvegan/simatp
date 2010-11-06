using System;

namespace SIMA
{
	public class T_C_TipoMantenimiento
	{
		#region Fields

		private int id_Tipo;
		private string nombre;
		private string descripcion;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_TipoMantenimiento class.
		/// </summary>
		public T_C_TipoMantenimiento()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_TipoMantenimiento class.
		/// </summary>
		public T_C_TipoMantenimiento(int id_Tipo, string nombre, string descripcion, int id_Estado)
		{
			this.id_Tipo = id_Tipo;
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Tipo value.
		/// </summary>
		public virtual int Id_Tipo
		{
			get { return id_Tipo; }
			set { id_Tipo = value; }
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
		/// Gets or sets the Descripcion value.
		/// </summary>
		public virtual string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
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
