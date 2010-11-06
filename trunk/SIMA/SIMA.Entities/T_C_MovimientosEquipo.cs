using System;

namespace SIMA
{
	public class T_C_MovimientosEquipo
	{
		#region Fields

		private int id_Movimiento;
		private string id_Equipo;
		private string id_AEquipo;
		private DateTime fechaMovimiento;
		private string observacion;
		private string usuario_Registro;
		private DateTime fecha_Registro;
		private int id_OrdenDeTrabajo;
		private short esMantenimiento;
		private short esIngreso;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_MovimientosEquipo class.
		/// </summary>
		public T_C_MovimientosEquipo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_MovimientosEquipo class.
		/// </summary>
		public T_C_MovimientosEquipo(int id_Movimiento, string id_Equipo, string id_AEquipo, DateTime fechaMovimiento, string observacion, string usuario_Registro, DateTime fecha_Registro, int id_OrdenDeTrabajo, short esMantenimiento, short esIngreso, int id_Estado)
		{
			this.id_Movimiento = id_Movimiento;
			this.id_Equipo = id_Equipo;
			this.id_AEquipo = id_AEquipo;
			this.fechaMovimiento = fechaMovimiento;
			this.observacion = observacion;
			this.usuario_Registro = usuario_Registro;
			this.fecha_Registro = fecha_Registro;
			this.id_OrdenDeTrabajo = id_OrdenDeTrabajo;
			this.esMantenimiento = esMantenimiento;
			this.esIngreso = esIngreso;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Movimiento value.
		/// </summary>
		public virtual int Id_Movimiento
		{
			get { return id_Movimiento; }
			set { id_Movimiento = value; }
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
		/// Gets or sets the Id_AEquipo value.
		/// </summary>
		public virtual string Id_AEquipo
		{
			get { return id_AEquipo; }
			set { id_AEquipo = value; }
		}

		/// <summary>
		/// Gets or sets the FechaMovimiento value.
		/// </summary>
		public virtual DateTime FechaMovimiento
		{
			get { return fechaMovimiento; }
			set { fechaMovimiento = value; }
		}

		/// <summary>
		/// Gets or sets the Observacion value.
		/// </summary>
		public virtual string Observacion
		{
			get { return observacion; }
			set { observacion = value; }
		}

		/// <summary>
		/// Gets or sets the Usuario_Registro value.
		/// </summary>
		public virtual string Usuario_Registro
		{
			get { return usuario_Registro; }
			set { usuario_Registro = value; }
		}

		/// <summary>
		/// Gets or sets the Fecha_Registro value.
		/// </summary>
		public virtual DateTime Fecha_Registro
		{
			get { return fecha_Registro; }
			set { fecha_Registro = value; }
		}

		/// <summary>
		/// Gets or sets the Id_OrdenDeTrabajo value.
		/// </summary>
		public virtual int Id_OrdenDeTrabajo
		{
			get { return id_OrdenDeTrabajo; }
			set { id_OrdenDeTrabajo = value; }
		}

		/// <summary>
		/// Gets or sets the EsMantenimiento value.
		/// </summary>
		public virtual short EsMantenimiento
		{
			get { return esMantenimiento; }
			set { esMantenimiento = value; }
		}

		/// <summary>
		/// Gets or sets the EsIngreso value.
		/// </summary>
		public virtual short EsIngreso
		{
			get { return esIngreso; }
			set { esIngreso = value; }
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
