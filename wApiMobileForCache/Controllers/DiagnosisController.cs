using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wApiMobileForCache.Context;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;

namespace wApiMobile.Controllers
{
    public class DiagnosisController : ApiController
    {
        WebService ws = new WebService();

        public List<Diagnostico> Get()
        {
            string license = Helper.getValueFromQueryString("licencia");
            DataSet dsDiagnostico = ws.getDatosActualizadosFromTabla("Diagnosticos");
            List<Diagnostico> lstDiagnosticos = ListHelper.ToList<Diagnostico>(dsDiagnostico.Tables[0]);
            return lstDiagnosticos;
        }

    }
}
