using System;

namespace SIMA.Entities
{
	public class T_C_Estado
	{
		#region Fields

		private int id_Estado;
		private int id_Tabla;
		private string nombre_Estado;
		private string descripcion_Estado;
		private bool por_Defecto;
		private bool muestra_Informacion;
        private bool noElimina;
        private T_C_Tabla tabla;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Estado class.
		/// </summary>
		public T_C_Estado()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Estado class.
		/// </summary>
		public T_C_Estado(int id_Tabla, string nombre_Estado, string descripcion_Estado, bool por_Defecto, bool muestra_Informacion)
		{
			this.id_Tabla = id_Tabla;
			this.nombre_Estado = nombre_Estado;
			this.descripcion_Estado = descripcion_Estado;
			this.por_Defecto = por_Defecto;
			this.muestra_Informacion = muestra_Informacion;
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Estado class.
		/// </summary>
		public T_C_Estado(int id_Estado, int id_Tabla, string nombre_Estado, string descripcion_Estado, bool por_Defecto, bool muestra_Informacion)
		{
			this.id_Estado = id_Estado;
			this.id_Tabla = id_Tabla;
			this.nombre_Estado = nombre_Estado;
			this.descripcion_Estado = descripcion_Estado;
			this.por_Defecto = por_Defecto;
			this.muestra_Informacion = muestra_Informacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Estado value.
		/// </summary>
		public virtual int Id_Estado
		{
			get { return id_Estado; }
			set { id_Estado = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Tabla value.
		/// </summary>
		public virtual int Id_Tabla
		{
			get { return id_Tabla; }
			set { id_Tabla = value; }
		}

		/// <summary>
		/// Gets or sets the Nombre_Estado value.
		/// </summary>
		public virtual string Nombre_Estado
		{
			get { return nombre_Estado; }
			set { nombre_Estado = value; }
		}

		/// <summary>
		/// Gets or sets the Descripcion_Estado value.
		/// </summary>
		public virtual string Descripcion_Estado
		{
			get { return descripcion_Estado; }
			set { descripcion_Estado = value; }
		}

		/// <summary>
		/// Gets or sets the Por_Defecto value.
		/// </summary>
		public virtual bool Por_Defecto
		{
			get { return por_Defecto; }
			set { por_Defecto = value; }
		}

		/// <summary>
		/// Gets or sets the Muestra_Informacion value.
		/// </summary>
		public virtual bool Muestra_Informacion
		{
			get { return muestra_Informacion; }
			set { muestra_Informacion = value; }
		}

        public virtual bool NoElimina
        {
            get { return noElimina; }
            set { noElimina = value; }
        }

        public virtual T_C_Tabla Tabla
        {
            get { return tabla; }
            set { tabla = value; }
        }

		#endregion
	}
}
