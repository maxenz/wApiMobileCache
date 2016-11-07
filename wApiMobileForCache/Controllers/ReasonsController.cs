using NLog;
using System.Collections.Generic;
using System.Data;
using wApiMobileForCache.Context;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;

namespace wApiMobileForCache.Controllers
{
    public class ReasonsController : BaseController
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public ReasonsController() : base()
        {
        }

        public List<Motivo> Get()
        {
            logger.Info("Consultando motivos de no realizacion");
            DataSet dsMotivos = WebService.getDatosActualizadosFromTabla("MotivosNoRealizacion");
            logger.Info("La consulta de datos se realizó al servidor {0}", WebService.ws.Endpoint.Address);
            List<Motivo> lstMotivos = ListHelper.ToList<Motivo>(dsMotivos.Tables[0]);
            return lstMotivos;
        }

    }
}
