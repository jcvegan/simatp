using System;

namespace SIMA
{
	public class T_C_PermisosXPerfil
	{
		#region Fields

		private int id_Perfil;
		private int id_Permiso;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the T_C_PermisosXPerfil class.
		/// </summary>
		public T_C_PermisosXPerfil()
		{
		}

		/// <summary>
		/// Initializes a new instance of the T_C_PermisosXPerfil class.
		/// </summary>
		public T_C_PermisosXPerfil(int id_Perfil, int id_Permiso)
		{
			this.id_Perfil = id_Perfil;
			this.id_Permiso = id_Permiso;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Id_Perfil value.
		/// </summary>
		public virtual int Id_Perfil
		{
			get { return id_Perfil; }
			set { id_Perfil = value; }
		}

		/// <summary>
		/// Gets or sets the Id_Permiso value.
		/// </summary>
		public virtual int Id_Permiso
		{
			get { return id_Permiso; }
			set { id_Permiso = value; }
		}

		#endregion
	}
}
