using System;

namespace SIMA.Entities
{
	public class T_C_Mantenimiento
	{
		#region Fields

		private int id_Mantenimiento;
		private int id_Turno;
		private string id_Equipo;
		private DateTime fechaProgramacion;
		private DateTime fechaTrabajoInicio;
		private DateTime fechaTrabajoFin;
		private string usuarioRegistro;
		private DateTime fechaRegistro;
		private int id_Estado;
		private int id_TipoMantenimiento;
		private int id_Incidencia;
		private int id_Pedido;
		private int prioridad;
		private int id_OrdenTrabajo;
		private int id_TipoMantenimientoEquipo;
		private int id_TurnoMantenimiento;
        private T_C_Estado estado;


		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Mantenimiento class.
		/// </summary>
		public T_C_Mantenimiento()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Mantenimiento class.
		/// </summary>
		public T_C_Mantenimiento(int id_Mantenimiento, int id_Turno, string id_Equipo, DateTime fechaProgramacion, DateTime fechaTrabajoInicio, DateTime fechaTrabajoFin, string usuarioRegistro, DateTime fechaRegistro, int id_Estado, int id_TipoMantenimiento, int id_Incidencia, int id_Pedido, int prioridad, int id_OrdenTrabajo, int id_TipoMantenimientoEquipo, int id_TurnoMantenimiento)
		{
			this.id_Mantenimiento = id_Mantenimiento;
			this.id_Turno = id_Turno;
			this.id_Equipo = id_Equipo;
			this.fechaProgramacion = fechaProgramacion;
			this.fechaTrabajoInicio = fechaTrabajoInicio;
			this.fechaTrabajoFin = fechaTrabajoFin;
			this.usuarioRegistro = usuarioRegistro;
			this.fechaRegistro = fechaRegistro;
			this.id_Estado = id_Estado;
			this.id_TipoMantenimiento = id_TipoMantenimiento;
			this.id_Incidencia = id_Incidencia;
			this.id_Pedido = id_Pedido;
			this.prioridad = prioridad;
			this.id_OrdenTrabajo = id_OrdenTrabajo;
			this.id_TipoMantenimientoEquipo = id_TipoMantenimientoEquipo;
			this.id_TurnoMantenimiento = id_TurnoMantenimiento;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Mantenimiento value.
		/// </summary>
		public virtual int Id_Mantenimiento
		{
			get { return id_Mantenimiento; }
			set { id_Mantenimiento = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Turno value.
		/// </summary>
		public virtual int Id_Turno
		{
			get { return id_Turno; }
			set { id_Turno = value; }
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
		/// Gets or sets the FechaProgramacion value.
		/// </summary>
		public virtual DateTime FechaProgramacion
		{
			get { return fechaProgramacion; }
			set { fechaProgramacion = value; }
		}

		/// <summary>
		/// Gets or sets the FechaTrabajoInicio value.
		/// </summary>
		public virtual DateTime FechaTrabajoInicio
		{
			get { return fechaTrabajoInicio; }
			set { fechaTrabajoInicio = value; }
		}

		/// <summary>
		/// Gets or sets the FechaTrabajoFin value.
		/// </summary>
		public virtual DateTime FechaTrabajoFin
		{
			get { return fechaTrabajoFin; }
			set { fechaTrabajoFin = value; }
		}

		/// <summary>
		/// Gets or sets the UsuarioRegistro value.
		/// </summary>
		public virtual string UsuarioRegistro
		{
			get { return usuarioRegistro; }
			set { usuarioRegistro = value; }
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
		/// Gets or sets the Id_TipoMantenimiento value.
		/// </summary>
		public virtual int Id_TipoMantenimiento
		{
			get { return id_TipoMantenimiento; }
			set { id_TipoMantenimiento = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Incidencia value.
		/// </summary>
		public virtual int Id_Incidencia
		{
			get { return id_Incidencia; }
			set { id_Incidencia = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Pedido value.
		/// </summary>
		public virtual int Id_Pedido
		{
			get { return id_Pedido; }
			set { id_Pedido = value; }
		}

		/// <summary>
		/// Gets or sets the Prioridad value.
		/// </summary>
		public virtual int Prioridad
		{
			get { return prioridad; }
			set { prioridad = value; }
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
		/// Gets or sets the Id_TipoMantenimientoEquipo value.
		/// </summary>
		public virtual int Id_TipoMantenimientoEquipo
		{
			get { return id_TipoMantenimientoEquipo; }
			set { id_TipoMantenimientoEquipo = value; }
		}

		/// <summary>
		/// Gets or sets the Id_TurnoMantenimiento value.
		/// </summary>
		public virtual int Id_TurnoMantenimiento
		{
			get { return id_TurnoMantenimiento; }
			set { id_TurnoMantenimiento = value; }
		}


        public virtual T_C_Estado Estado
        {
            get { return Estado; }
            set { Estado = value; }
        }   

		#endregion
	}
}
