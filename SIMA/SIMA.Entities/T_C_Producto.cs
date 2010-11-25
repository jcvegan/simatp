using System;

namespace SIMA.Entities
{
	public class T_C_Producto
	{
		#region Fields

		private int id_Producto;
		private string descripción;
		private int id_Estado;
        private T_C_Estado estado;

        public virtual T_C_Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Producto class.
		/// </summary>
		public T_C_Producto()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Producto class.
		/// </summary>
		public T_C_Producto(int id_Producto, string descripción, int id_Requerimiento, int id_Estado)
		{
			this.id_Producto = id_Producto;
			this.descripción = descripción;
			
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Producto value.
		/// </summary>
		public virtual int Id_Producto
		{
			get { return id_Producto; }
			set { id_Producto = value; }
		}

		/// <summary>
		/// Gets or sets the Descripción value.
		/// </summary>
		public virtual string Descripción
		{
			get { return descripción; }
			set { descripción = value; }
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
