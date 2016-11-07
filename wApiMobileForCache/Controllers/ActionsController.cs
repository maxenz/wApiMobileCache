using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wApiMobileForCache.Context;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;

namespace wApiMobile.Controllers
{
    public class ActionsController : Controller
    {

        WebService ws = new WebService();

        [HttpPost]
        public string setLlegadaMovil(string licencia, string movil, int viajeID)
        {
            ws.ChangeEndPoint(Helper.getServerConnectiongBySerial(licencia));
            Resultado resultado = ws.setLlegadaMovil(movil, viajeID);
            return JsonConvert.SerializeObject(resultado);
        }

        [HttpPost]
        public string setSalidaMovil(string licencia, string movil, int viajeID)
        {
            ws.ChangeEndPoint(Helper.getServerConnectiongBySerial(licencia));
            Resultado resultado = ws.setSalidaMovil(movil, viajeID);
            return JsonConvert.SerializeObject(resultado);
        }

        [HttpPost]
        public string setFinalServicio(long reportNumber, string licencia, string movil, int viajeID, int motivoID, int diagnosticoID, string observaciones, int copago, string derivationTime)
        {
            ws.ChangeEndPoint(Helper.getServerConnectiongBySerial(licencia));
            int horEsp = Helper.getHoursFromTime(derivationTime);
            int minEsp = Helper.getMinutesFromTime(derivationTime);

            Resultado resultado = ws.setFinalServicio(movil, viajeID, motivoID, diagnosticoID, observaciones, copago, reportNumber, horEsp, minEsp);
            return JsonConvert.SerializeObject(resultado);
        }

        [HttpPost]
        public string setCancelacionServicio(string licencia, string movil, int viajeID, string observaciones)
        {
            ws.ChangeEndPoint(Helper.getServerConnectiongBySerial(licencia));
            Resultado resultado = ws.setCancelacionServicio(movil, viajeID, observaciones);
            return JsonConvert.SerializeObject(resultado);
        }
        

    }
}
