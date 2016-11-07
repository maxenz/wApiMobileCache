using System.Collections.Generic;
using System.Data;
using wApiMobileForCache.Context;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;

namespace wApiMobileForCache.Controllers
{
    public class DiagnosisController : BaseController
    {
        public List<Diagnostico> Get()
        {
            DataSet dsDiagnostico = WebService.getDatosActualizadosFromTabla("Diagnosticos");
            List<Diagnostico> lstDiagnosticos = ListHelper.ToList<Diagnostico>(dsDiagnostico.Tables[0]);
            return lstDiagnosticos;
        }
    }
}
