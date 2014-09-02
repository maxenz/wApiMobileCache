﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wApiMobileForCache.Context;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;

namespace wApiMobileForCache.Controllers
{
    public class DiagnosticoController : ApiController
    {
        WebService ws = new WebService();

        public List<Diagnostico> Get(int id)
        {
            DataSet dsDiagnostico = ws.getDatosActualizadosFromTabla("Diagnosticos");
            List<Diagnostico> lstDiagnosticos = ListHelper.ToList<Diagnostico>(dsDiagnostico.Tables[0]);
            return lstDiagnosticos;
        }
    }
}
