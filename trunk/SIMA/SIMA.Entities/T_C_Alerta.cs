using System;

namespace SIMA.Entities
{
	public class T_C_Alerta
	{
		#region Fields

		private int id_Alerta;
		private string id_Equipo;
		private string aCorreo;
		private DateTime fechaEnvio;
		private float valorDemanda;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Alerta class.
		/// </summary>
		public T_C_Alerta()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Alerta class.
		/// </summary>
		public T_C_Alerta(int id_Alerta, string id_Equipo, string aCorreo, DateTime fechaEnvio, float valorDemanda, int id_Estado)
		{
			this.id_Alerta = id_Alerta;
			this.id_Equipo = id_Equipo;
			this.aCorreo = aCorreo;
			this.fechaEnvio = fechaEnvio;
			this.valorDemanda = valorDemanda;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Alerta value.
		/// </summary>
		public virtual int Id_Alerta
		{
			get { return id_Alerta; }
			set { id_Alerta = value; }
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
		/// Gets or sets the ACorreo value.
		/// </summary>
		public virtual string ACorreo
		{
			get { return aCorreo; }
			set { aCorreo = value; }
		}

		/// <summary>
		/// Gets or sets the FechaEnvio value.
		/// </summary>
		public virtual DateTime FechaEnvio
		{
			get { return fechaEnvio; }
			set { fechaEnvio = value; }
		}

		/// <summary>
		/// Gets or sets the ValorDemanda value.
		/// </summary>
		public virtual float ValorDemanda
		{
			get { return valorDemanda; }
			set { valorDemanda = value; }
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
