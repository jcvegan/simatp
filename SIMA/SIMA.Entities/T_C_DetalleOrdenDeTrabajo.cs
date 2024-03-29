using System;

namespace SIMA.Entities
{
	public class T_C_DetalleOrdenDeTrabajo
	{
		#region Fields

		private int id_DetalleOrdendeTrabajo;
		private int id_OrdendeTrabajo;
		private double costo;
		private float porcentaje;
		private string descrippcion;
		private DateTime fechaRegistro;
		private int id_Estado;
		private int cantidad;
		private int id_Solicitud;
        private string idEquipo;
        private bool flag;

        public virtual string IdEquipo
        {
            get { return idEquipo; }
            set { idEquipo = value; }
        }
        private T_C_Estado estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_DetalleOrdenDeTrabajo class.
		/// </summary>
		public T_C_DetalleOrdenDeTrabajo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_DetalleOrdenDeTrabajo class.
		/// </summary>
		public T_C_DetalleOrdenDeTrabajo(int id_DetalleOrdendeTrabajo, int id_OrdendeTrabajo, float costo, float porcentaje, string descrippcion, DateTime fechaRegistro, int id_Estado, int cantidad, int id_Solicitud, bool flag)
		{
			this.id_DetalleOrdendeTrabajo = id_DetalleOrdendeTrabajo;
			this.id_OrdendeTrabajo = id_OrdendeTrabajo;
			this.costo = costo;
			this.porcentaje = porcentaje;
			this.descrippcion = descrippcion;
			this.fechaRegistro = fechaRegistro;
			this.id_Estado = id_Estado;
			this.cantidad = cantidad;
			this.id_Solicitud = id_Solicitud;
            this.flag = flag;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_DetalleOrdendeTrabajo value.
		/// </summary>
		public virtual int Id_DetalleOrdendeTrabajo
		{
			get { return id_DetalleOrdendeTrabajo; }
			set { id_DetalleOrdendeTrabajo = value; }
		}

		/// <summary>
		/// Gets or sets the Id_OrdendeTrabajo value.
		/// </summary>
		public virtual int Id_OrdendeTrabajo
		{
			get { return id_OrdendeTrabajo; }
			set { id_OrdendeTrabajo = value; }
		}

		/// <summary>
		/// Gets or sets the Costo value.
		/// </summary>
		public virtual double Costo
		{
			get { return costo; }
			set { costo = value; }
		}

		/// <summary>
		/// Gets or sets the Porcentaje value.
		/// </summary>
		public virtual float Porcentaje
		{
			get { return porcentaje; }
			set { porcentaje = value; }
		}

		/// <summary>
		/// Gets or sets the Motivo value.
		/// </summary>
		public virtual string Descrippcion
		{
            get { return descrippcion; }
            set { descrippcion = value; }
		}

		/// <summary>
		/// Gets or sets the FechaRegistro value.
		/// </summary>
		public virtual DateTime FechaRegistro
		{
			get { return fechaRegistro; }
			set { fechaRegistro = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Estado value.
		/// </summary>
		public virtual int Id_Estado
		{
			get { return id_Estado; }
			set { id_Estado = value; }
		}

		/// <summary>
		/// Gets or sets the Cantidad value.
		/// </summary>
		public virtual int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Solicitud value.
		/// </summary>
		public virtual int Id_Solicitud
		{
			get { return id_Solicitud; }
			set { id_Solicitud = value; }
		}

        public  bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }

		#endregion
	}
}
