using System;

namespace SIMA.Entities
{
	public class T_C_Pedido
	{
		#region Fields

		private int id_Pedido;
		private string usuario_Pedido;
		private DateTime fecha_Pedido;
		private string usuarioConfirma;
		private DateTime fechaConfirma;
		private int id_Estado;
		private string motivoPedido;
		private int id_Mantenimiento;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Pedido class.
		/// </summary>
		public T_C_Pedido()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Pedido class.
		/// </summary>
		public T_C_Pedido(int id_Pedido, string usuario_Pedido, DateTime fecha_Pedido, string usuarioConfirma, DateTime fechaConfirma, int id_Estado, string motivoPedido, int id_Mantenimiento)
		{
			this.id_Pedido = id_Pedido;
			this.usuario_Pedido = usuario_Pedido;
			this.fecha_Pedido = fecha_Pedido;
			this.usuarioConfirma = usuarioConfirma;
			this.fechaConfirma = fechaConfirma;
			this.id_Estado = id_Estado;
			this.motivoPedido = motivoPedido;
			this.id_Mantenimiento = id_Mantenimiento;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Pedido value.
		/// </summary>
		public virtual int Id_Pedido
		{
			get { return id_Pedido; }
			set { id_Pedido = value; }
		}

		/// <summary>
		/// Gets or sets the Usuario_Pedido value.
		/// </summary>
		public virtual string Usuario_Pedido
		{
			get { return usuario_Pedido; }
			set { usuario_Pedido = value; }
		}

		/// <summary>
		/// Gets or sets the Fecha_Pedido value.
		/// </summary>
		public virtual DateTime Fecha_Pedido
		{
			get { return fecha_Pedido; }
			set { fecha_Pedido = value; }
		}

		/// <summary>
		/// Gets or sets the UsuarioConfirma value.
		/// </summary>
		public virtual string UsuarioConfirma
		{
			get { return usuarioConfirma; }
			set { usuarioConfirma = value; }
		}

		/// <summary>
		/// Gets or sets the FechaConfirma value.
		/// </summary>
		public virtual DateTime FechaConfirma
		{
			get { return fechaConfirma; }
			set { fechaConfirma = value; }
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
		/// Gets or sets the MotivoPedido value.
		/// </summary>
		public virtual string MotivoPedido
		{
			get { return motivoPedido; }
			set { motivoPedido = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Mantenimiento value.
		/// </summary>
		public virtual int Id_Mantenimiento
		{
			get { return id_Mantenimiento; }
			set { id_Mantenimiento = value; }
		}

		#endregion
	}
}
