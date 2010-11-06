using System;

namespace SIMA
{
	public class T_C_OrdenTrabajo
	{
		#region Fields

		private int id_OrdenTrabajo;
		private string descripcion;
		private float costoTotal;
		private DateTime fechaRegistro;
		private DateTime ultimaFechaModificacion;
		private int id_Estado;
		private int id_Usuario;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_OrdenTrabajo class.
		/// </summary>
		public T_C_OrdenTrabajo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_OrdenTrabajo class.
		/// </summary>
		public T_C_OrdenTrabajo(int id_OrdenTrabajo, string descripcion, float costoTotal, DateTime fechaRegistro, DateTime ultimaFechaModificacion, int id_Estado, int id_Usuario)
		{
			this.id_OrdenTrabajo = id_OrdenTrabajo;
			this.descripcion = descripcion;
			this.costoTotal = costoTotal;
			this.fechaRegistro = fechaRegistro;
			this.ultimaFechaModificacion = ultimaFechaModificacion;
			this.id_Estado = id_Estado;
			this.id_Usuario = id_Usuario;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_OrdenTrabajo value.
		/// </summary>
		public virtual int Id_OrdenTrabajo
		{
			get { return id_OrdenTrabajo; }
			set { id_OrdenTrabajo = value; }
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
		/// Gets or sets the CostoTotal value.
		/// </summary>
		public virtual float CostoTotal
		{
			get { return costoTotal; }
			set { costoTotal = value; }
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
		/// Gets or sets the UltimaFechaModificacion value.
		/// </summary>
		public virtual DateTime UltimaFechaModificacion
		{
			get { return ultimaFechaModificacion; }
			set { ultimaFechaModificacion = value; }
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
		/// Gets or sets the Id_Usuario value.
		/// </summary>
		public virtual int Id_Usuario
		{
			get { return id_Usuario; }
			set { id_Usuario = value; }
		}

		#endregion
	}
}
