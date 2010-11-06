using System;

namespace SIMA
{
	public class T_C_DetalleSolicitud
	{
		#region Fields

		private int id_Solicitud;
		private string id_Equipo;
		private string motivo;
		private DateTime fechaRegistro;
		private int id_DetalleSolicitud;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_DetalleSolicitud class.
		/// </summary>
		public T_C_DetalleSolicitud()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_DetalleSolicitud class.
		/// </summary>
		public T_C_DetalleSolicitud(int id_Solicitud, string id_Equipo, string motivo, DateTime fechaRegistro, int id_DetalleSolicitud)
		{
			this.id_Solicitud = id_Solicitud;
			this.id_Equipo = id_Equipo;
			this.motivo = motivo;
			this.fechaRegistro = fechaRegistro;
			this.id_DetalleSolicitud = id_DetalleSolicitud;
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
		/// Gets or sets the Id_Equipo value.
		/// </summary>
		public virtual string Id_Equipo
		{
			get { return id_Equipo; }
			set { id_Equipo = value; }
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
		/// Gets or sets the Id_DetalleSolicitud value.
		/// </summary>
		public virtual int Id_DetalleSolicitud
		{
			get { return id_DetalleSolicitud; }
			set { id_DetalleSolicitud = value; }
		}

		#endregion
	}
}
