using System;
using System.Collections.Generic;
using System.Data;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;


namespace wApiMobileForCache.Controllers
{
    public class ClinicalHistoryController : BaseController
    {

        public ClinicalHistoryController() : base() {  }

        public List<HistoriaClinica> Get(int id)
        {
            DataSet dsHistoriaClinica = WebService.getHistoriaClinica(id);
            List<HistoriaClinica> lstHistoriaClinica = ListHelper.ToList<HistoriaClinica>(dsHistoriaClinica.Tables[0]);
            Helper.formatColorHC(ref lstHistoriaClinica);
            Helper.formatFechaHC(ref lstHistoriaClinica);
            return lstHistoriaClinica;
        }
     
    }
}
