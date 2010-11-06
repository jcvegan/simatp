using System;

namespace SIMA.Entities
{
	public class T_C_Incidencia
	{
		#region Fields

		private int id_Incidencia;
		private string usuario_Responsable;
		private string usuario_Registro;
		private DateTime fecha_Incidencia;
		private DateTime fecha_Reporte;
		private string descripcion;
		private int id_Estado;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Incidencia class.
		/// </summary>
		public T_C_Incidencia()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Incidencia class.
		/// </summary>
		public T_C_Incidencia(int id_Incidencia, string usuario_Responsable, string usuario_Registro, DateTime fecha_Incidencia, DateTime fecha_Reporte, string descripcion, int id_Estado)
		{
			this.id_Incidencia = id_Incidencia;
			this.usuario_Responsable = usuario_Responsable;
			this.usuario_Registro = usuario_Registro;
			this.fecha_Incidencia = fecha_Incidencia;
			this.fecha_Reporte = fecha_Reporte;
			this.descripcion = descripcion;
			this.id_Estado = id_Estado;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Incidencia value.
		/// </summary>
		public virtual int Id_Incidencia
		{
			get { return id_Incidencia; }
			set { id_Incidencia = value; }
		}

		/// <summary>
		/// Gets or sets the Usuario_Responsable value.
		/// </summary>
		public virtual string Usuario_Responsable
		{
			get { return usuario_Responsable; }
			set { usuario_Responsable = value; }
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
		/// Gets or sets the Fecha_Incidencia value.
		/// </summary>
		public virtual DateTime Fecha_Incidencia
		{
			get { return fecha_Incidencia; }
			set { fecha_Incidencia = value; }
		}

		/// <summary>
		/// Gets or sets the Fecha_Reporte value.
		/// </summary>
		public virtual DateTime Fecha_Reporte
		{
			get { return fecha_Reporte; }
			set { fecha_Reporte = value; }
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
