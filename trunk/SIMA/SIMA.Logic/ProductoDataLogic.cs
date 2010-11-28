using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.Entities;
using SIMA.DataAccess;

namespace SIMA.Logic
{
    public class ProductoDataLogic
    {
        public List<T_C_Producto> SeleccionarActivos()
        {
            return new ProductoDataAccess().SeleccionarActivos();
        }
    }
}
