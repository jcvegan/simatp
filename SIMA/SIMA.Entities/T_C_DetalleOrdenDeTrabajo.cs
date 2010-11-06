using System;

namespace SIMA
{
	public class T_C_DetalleOrdenDeTrabajo
	{
		#region Fields

		private int id_DetalleOrdendeTrabajo;
		private int id_OrdendeTrabajo;
		private float costo;
		private float porcentaje;
		private string motivo;
		private DateTime fechaRegistro;
		private int id_Estado;
		private int cantidad;
		private int id_OrdenTrabajo;
		private int id_Solicitud;

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
		public T_C_DetalleOrdenDeTrabajo(int id_DetalleOrdendeTrabajo, int id_OrdendeTrabajo, float costo, float porcentaje, string motivo, DateTime fechaRegistro, int id_Estado, int cantidad, int id_OrdenTrabajo, int id_Solicitud)
		{
			this.id_DetalleOrdendeTrabajo = id_DetalleOrdendeTrabajo;
			this.id_OrdendeTrabajo = id_OrdendeTrabajo;
			this.costo = costo;
			this.porcentaje = porcentaje;
			this.motivo = motivo;
			this.fechaRegistro = fechaRegistro;
			this.id_Estado = id_Estado;
			this.cantidad = cantidad;
			this.id_OrdenTrabajo = id_OrdenTrabajo;
			this.id_Solicitud = id_Solicitud;
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
		public virtual float Costo
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
		public virtual string Motivo
		{
			get { return motivo; }
			set { motivo = value; }
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
		/// Gets or sets the Id_OrdenTrabajo value.
		/// </summary>
		public virtual int Id_OrdenTrabajo
		{
			get { return id_OrdenTrabajo; }
			set { id_OrdenTrabajo = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Solicitud value.
		/// </summary>
		public virtual int Id_Solicitud
		{
			get { return id_Solicitud; }
			set { id_Solicitud = value; }
		}

		#endregion
	}
}
