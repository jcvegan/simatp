using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class MarcaDataLogic
    {
        private MarcaDataAccess marcaAccess;

        public MarcaDataLogic()
        {
            marcaAccess = new MarcaDataAccess();
        }

        public string AgregarMarca(T_C_Marca marca)
        {
            return marcaAccess.AgregarMarca(marca);
        }

        public string ActualizarMarca(T_C_Marca marca)
        {
            return marcaAccess.ActualizarMarca(marca);
        }

        public string EliminarMarca(T_C_Marca marca)
        {
            return marcaAccess.EliminarMarca(marca);
        }

        public List<T_C_Marca> ListarMarcas()
        {
            return marcaAccess.SeleccionarTodosMarca();
        }

        public List<T_C_Marca> ListarActivosMarcas()
        {
            return marcaAccess.SeleccionarActivosMarca();
        }
    }
}