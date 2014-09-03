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

namespace wApiMobileForCache.Controllers
{
    public class HistoriaClinicaController : ApiController
    {
        WebService ws = new WebService();

        public List<HistoriaClinica> Get(int id)
        {
            DataSet dsHistoriaClinica = ws.getHistoriaClinica(id);
            List<HistoriaClinica> lstHistoriaClinica = ListHelper.ToList<HistoriaClinica>(dsHistoriaClinica.Tables[0]);
            Helper.formatColorHC(ref lstHistoriaClinica);
            Helper.formatFechaHC(ref lstHistoriaClinica);
            return lstHistoriaClinica;
        }
    }
}
