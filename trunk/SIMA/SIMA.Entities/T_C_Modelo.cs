using System;

namespace SIMA.Entities
{
	public class T_C_Modelo
	{
		#region Fields

		private int id_Modelo;
		private string descripcion;
		private int año;
		private int id_Marca;
		private int id_Estado;
        private T_C_Estado estado;
        private T_C_Marca marca;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Modelo class.
		/// </summary>
		public T_C_Modelo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Modelo class.
		/// </summary>
		public T_C_Modelo(short id_Modelo, string descripcion, int año, int id_Marca, int id_Estado)
		{
			this.id_Modelo = id_Modelo;
			this.descripcion = descripcion;
			this.año = año;
			this.id_Marca = id_Marca;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Modelo value.
		/// </summary>
		public virtual int Id_Modelo
		{
			get { return id_Modelo; }
			set { id_Modelo = value; }
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
		/// Gets or sets the Año value.
		/// </summary>
		public virtual int Año
		{
			get { return año; }
			set { año = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Marca value.
		/// </summary>
		public virtual int Id_Marca
		{
			get { return id_Marca; }
			set { id_Marca = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Estado value.
		/// </summary>
		public virtual int Id_Estado
		{
			get { return id_Estado; }
			set { id_Estado = value; }
		}

        public virtual T_C_Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public virtual T_C_Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

		#endregion
	}
}
