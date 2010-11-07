using System;

namespace SIMA.Entities
{
	public class T_C_Usuario
	{
		#region Fields

		private int id_Usuario;
		private string nombres;
		private string apellidos;
		private int telefono;
		private string direccion;
		private DateTime fecha_Registro;
		private DateTime fecha_Nacimiento;
		private string email;
		private string contraseña;
		private int id_Estado;
		private int id_Perfil;
		private int id_TurnoMantenimiento;
		private int id_Trabajador;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Usuario class.
		/// </summary>
		public T_C_Usuario()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Usuario class.
		/// </summary>
		public T_C_Usuario(int id_Usuario, string nombres, string apellidos, int telefono, string direccion, DateTime fecha_Registro, DateTime fecha_Nacimiento, string email, string contraseña, int id_Estado, int id_Perfil, int id_TurnoMantenimiento, int id_Trabajador)
		{
			this.id_Usuario = id_Usuario;
			this.nombres = nombres;
			this.apellidos = apellidos;
			this.telefono = telefono;
			this.direccion = direccion;
			this.fecha_Registro = fecha_Registro;
			this.fecha_Nacimiento = fecha_Nacimiento;
			this.email = email;
			this.contraseña = contraseña;
			this.id_Estado = id_Estado;
			this.id_Perfil = id_Perfil;
			this.id_TurnoMantenimiento = id_TurnoMantenimiento;
			this.id_Trabajador = id_Trabajador;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Usuario value.
		/// </summary>
		public virtual int Id_Usuario
		{
			get { return id_Usuario; }
			set { id_Usuario = value; }
		}

		/// <summary>
		/// Gets or sets the Nombres value.
		/// </summary>
		public virtual string Nombres
		{
			get { return nombres; }
			set { nombres = value; }
		}

		/// <summary>
		/// Gets or sets the Apellidos value.
		/// </summary>
		public virtual string Apellidos
		{
			get { return apellidos; }
			set { apellidos = value; }
		}

		/// <summary>
		/// Gets or sets the Telefono value.
		/// </summary>
		public virtual int Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		/// <summary>
		/// Gets or sets the Direccion value.
		/// </summary>
		public virtual string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
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
		/// Gets or sets the Fecha_Nacimiento value.
		/// </summary>
		public virtual DateTime Fecha_Nacimiento
		{
			get { return fecha_Nacimiento; }
			set { fecha_Nacimiento = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public virtual string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the Contraseña value.
		/// </summary>
		public virtual string Contraseña
		{
			get { return contraseña; }
			set { contraseña = value; }
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
		/// Gets or sets the Id_Perfil value.
		/// </summary>
		public virtual int Id_Perfil
		{
			get { return id_Perfil; }
			set { id_Perfil = value; }
		}

		#endregion
	}
}
