using System;

namespace SIMA.Entities
{
	public class T_C_Equipo
	{
		#region Fields

		private string id_Equipo;
		private string equipoPadre;
		private string descripcion;
		private int id_Marca;
		private short id_Modelo;
		private string serie;
		private float costo;
		private int id_Estado;
		private DateTime fecha_Registro;
		private DateTime fecha_Adquisicion;
		private string id_Area;
		private int maxHoras;
		private short usoUnico;
		private int nivel;
		private int stock;
		private decimal capacidadOperacion;
		private decimal diamteroInterno;
		private string revestimientoInterior;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_Equipo class.
		/// </summary>
		public T_C_Equipo()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_Equipo class.
		/// </summary>
		public T_C_Equipo(string id_Equipo, string equipoPadre, string descripcion, int id_Marca, short id_Modelo, string serie, float costo, int id_Estado, DateTime fecha_Registro, DateTime fecha_Adquisicion, string id_Area, int maxHoras, short usoUnico, int nivel, int stock, decimal capacidadOperacion, decimal diamteroInterno, string revestimientoInterior)
		{
			this.id_Equipo = id_Equipo;
			this.equipoPadre = equipoPadre;
			this.descripcion = descripcion;
			this.id_Marca = id_Marca;
			this.id_Modelo = id_Modelo;
			this.serie = serie;
			this.costo = costo;
			this.id_Estado = id_Estado;
			this.fecha_Registro = fecha_Registro;
			this.fecha_Adquisicion = fecha_Adquisicion;
			this.id_Area = id_Area;
			this.maxHoras = maxHoras;
			this.usoUnico = usoUnico;
			this.nivel = nivel;
			this.stock = stock;
			this.capacidadOperacion = capacidadOperacion;
			this.diamteroInterno = diamteroInterno;
			this.revestimientoInterior = revestimientoInterior;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Equipo value.
		/// </summary>
		public virtual string Id_Equipo
		{
			get { return id_Equipo; }
			set { id_Equipo = value; }
		}

		/// <summary>
		/// Gets or sets the EquipoPadre value.
		/// </summary>
		public virtual string EquipoPadre
		{
			get { return equipoPadre; }
			set { equipoPadre = value; }
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
		/// Gets or sets the Id_Marca value.
		/// </summary>
		public virtual int Id_Marca
		{
			get { return id_Marca; }
			set { id_Marca = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Modelo value.
		/// </summary>
		public virtual short Id_Modelo
		{
			get { return id_Modelo; }
			set { id_Modelo = value; }
		}

		/// <summary>
		/// Gets or sets the Serie value.
		/// </summary>
		public virtual string Serie
		{
			get { return serie; }
			set { serie = value; }
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
		/// Gets or sets the Id_Estado value.
		/// </summary>
		public virtual int Id_Estado
		{
			get { return id_Estado; }
			set { id_Estado = value; }
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
		/// Gets or sets the Fecha_Adquisicion value.
		/// </summary>
		public virtual DateTime Fecha_Adquisicion
		{
			get { return fecha_Adquisicion; }
			set { fecha_Adquisicion = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Area value.
		/// </summary>
		public virtual string Id_Area
		{
			get { return id_Area; }
			set { id_Area = value; }
		}

		/// <summary>
		/// Gets or sets the MaxHoras value.
		/// </summary>
		public virtual int MaxHoras
		{
			get { return maxHoras; }
			set { maxHoras = value; }
		}

		/// <summary>
		/// Gets or sets the UsoUnico value.
		/// </summary>
		public virtual short UsoUnico
		{
			get { return usoUnico; }
			set { usoUnico = value; }
		}

		/// <summary>
		/// Gets or sets the Nivel value.
		/// </summary>
		public virtual int Nivel
		{
			get { return nivel; }
			set { nivel = value; }
		}

		/// <summary>
		/// Gets or sets the Stock value.
		/// </summary>
		public virtual int Stock
		{
			get { return stock; }
			set { stock = value; }
		}

		/// <summary>
		/// Gets or sets the CapacidadOperacion value.
		/// </summary>
		public virtual decimal CapacidadOperacion
		{
			get { return capacidadOperacion; }
			set { capacidadOperacion = value; }
		}

		/// <summary>
		/// Gets or sets the DiamteroInterno value.
		/// </summary>
		public virtual decimal DiamteroInterno
		{
			get { return diamteroInterno; }
			set { diamteroInterno = value; }
		}

		/// <summary>
		/// Gets or sets the RevestimientoInterior value.
		/// </summary>
		public virtual string RevestimientoInterior
		{
			get { return revestimientoInterior; }
			set { revestimientoInterior = value; }
		}

		#endregion
	}
}
