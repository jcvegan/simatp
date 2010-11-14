using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIMA.DataAccess;
using SIMA.Entities;

namespace SIMA.Logic
{
    public class SolicitudDataLogic
    {
        private SolicitudDataAccess solicitudAccess;

        public SolicitudDataLogic()
        {
            solicitudAccess = new SolicitudDataAccess();
        }
    }
}
