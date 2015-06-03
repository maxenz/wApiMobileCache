using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wApiMobileForCache.Context;
using wApiMobileForCache.Models;

namespace wApiMobileForCache.Controllers
{
    public class AccionesController : Controller
    {
        WebService ws = new WebService();

        [HttpPost]
        public string setLlegadaMovil(string movil, int viajeID)
        {
            Resultado resultado = ws.setLlegadaMovil(movil, viajeID);
            return JsonConvert.SerializeObject(resultado);
        }

        [HttpPost]
        public string setSalidaMovil(string movil, int viajeID)
        {
            Resultado resultado = ws.setSalidaMovil(movil, viajeID);
            return JsonConvert.SerializeObject(resultado);
        }

        [HttpPost]
        public string setFinalServicio(string movil, int viajeID, int motivoID, int diagnosticoID, string observaciones, int copago)
        {
            Resultado resultado = ws.setFinalServicio(movil, viajeID, motivoID, diagnosticoID, observaciones,copago,0);
            return JsonConvert.SerializeObject(resultado);
        }

        [HttpPost]
        public string setCancelacionServicio(string movil, int viajeID, string observaciones)
        {
            Resultado resultado = ws.setCancelacionServicio(movil, viajeID, observaciones);
            return JsonConvert.SerializeObject(resultado);
        }

    }
}
