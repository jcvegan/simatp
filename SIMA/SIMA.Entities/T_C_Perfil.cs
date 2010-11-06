using System;

namespace SIMA.Entities
{
	public class T_C_Perfil
	{
		#region Fields

		private int id_Perfil;
		private string nombre;
		private string descripcion;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Perfil class.
		/// </summary>
		public T_C_Perfil()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Perfil class.
		/// </summary>
		public T_C_Perfil(int id_Perfil, string nombre, string descripcion, int id_Estado)
		{
			this.id_Perfil = id_Perfil;
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Perfil value.
		/// </summary>
		public virtual int Id_Perfil
		{
			get { return id_Perfil; }
			set { id_Perfil = value; }
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
