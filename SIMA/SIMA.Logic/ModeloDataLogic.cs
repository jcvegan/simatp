using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess;

namespace SIMA.Logic
{
    public class ModeloDataLogic
    {
        private ModeloDataAccess modeloAccess;

        public ModeloDataLogic()
        {
            modeloAccess = new ModeloDataAccess();
        }

        public string AgregarModelo(T_C_Modelo modelo)
        {
            return modeloAccess.AgregarModelo(modelo);
        }

        public string ActualizarModelo(T_C_Modelo modelo)
        {
            return modeloAccess.ActualizarModelo(modelo);
        }

        public string EliminarModelo(T_C_Modelo modelo)
        {
            return modeloAccess.EliminarModelo(modelo);
        }

        public List<T_C_Modelo> ListarTodos()
        {
            return modeloAccess.SeleccionarTodosModelo();
        }

        public List<T_C_Modelo> ListarActivos()
        {
            return modeloAccess.SeleccionarModeloActivo();
        }

        public List<T_C_Modelo> ListarPorMarca(int idMarca)
        {
            return modeloAccess.SeleccionarModeloPorMarca(idMarca);
        }

    }
}
