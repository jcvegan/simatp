using System;

namespace SIMA
{
	public class T_C_Solicitud
	{
		#region Fields

		private int id_Solicitud;
		private string descripcion;
		private DateTime fechaSolicitud;
		private DateTime fechaRespuesta;
		private string usuarioRespuesta;
		private int id_OrdenTrabajo;
		private string motivo;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Solicitud class.
		/// </summary>
		public T_C_Solicitud()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Solicitud class.
		/// </summary>
		public T_C_Solicitud(int id_Solicitud, string descripcion, DateTime fechaSolicitud, DateTime fechaRespuesta, string usuarioRespuesta, int id_OrdenTrabajo, string motivo, int id_Estado)
		{
			this.id_Solicitud = id_Solicitud;
			this.descripcion = descripcion;
			this.fechaSolicitud = fechaSolicitud;
			this.fechaRespuesta = fechaRespuesta;
			this.usuarioRespuesta = usuarioRespuesta;
			this.id_OrdenTrabajo = id_OrdenTrabajo;
			this.motivo = motivo;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Solicitud value.
		/// </summary>
		public virtual int Id_Solicitud
		{
			get { return id_Solicitud; }
			set { id_Solicitud = value; }
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
		/// Gets or sets the FechaSolicitud value.
		/// </summary>
		public virtual DateTime FechaSolicitud
		{
			get { return fechaSolicitud; }
			set { fechaSolicitud = value; }
		}

		/// <summary>
		/// Gets or sets the FechaRespuesta value.
		/// </summary>
		public virtual DateTime FechaRespuesta
		{
			get { return fechaRespuesta; }
			set { fechaRespuesta = value; }
		}

		/// <summary>
		/// Gets or sets the UsuarioRespuesta value.
		/// </summary>
		public virtual string UsuarioRespuesta
		{
			get { return usuarioRespuesta; }
			set { usuarioRespuesta = value; }
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
		/// Gets or sets the Motivo value.
		/// </summary>
		public virtual string Motivo
		{
			get { return motivo; }
			set { motivo = value; }
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
