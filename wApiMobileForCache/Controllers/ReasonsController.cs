using System;
using System.Collections.Generic;
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
    public class ReasonsController : ApiController
    {
        WebService ws = new WebService();

        public List<Motivo> Get()
        {
            string license = Helper.getValueFromQueryString("licencia");
            DataSet dsMotivos = ws.getDatosActualizadosFromTabla("MotivosNoRealizacion");
            List<Motivo> lstMotivos = ListHelper.ToList<Motivo>(dsMotivos.Tables[0]);
            return lstMotivos;

        }

    }
}
