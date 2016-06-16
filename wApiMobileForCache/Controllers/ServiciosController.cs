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
using wApiMobileForCache.wsIncidentesMobile;

namespace wApiMobileForCache.Controllers
{
    public class ServiciosController : ApiController
    {
        WebService ws = new WebService();

        public List<Servicio> Get()
        {
            string idMovil = Helper.getValueFromQueryString("idMovil");
            DataSet dsViajes = ws.getViajesMovil(idMovil);
            List<Servicio> lstServ = ListHelper.ToList<Servicio>(dsViajes.Tables[0]);
            Helper.formatColorServicios(ref lstServ);
            return lstServ;         
        }

        public ServicioDetalle Get(int id)
        {
            string idMovil = Helper.getValueFromQueryString("idMovil");
            DataSet dsViaje = ws.getViaje(idMovil,id);
            List<ServicioDetalle> lstServ = ListHelper.ToList<ServicioDetalle>(dsViaje.Tables[0]);
            ServicioDetalle servicio = lstServ.FirstOrDefault();
            servicio.ColorHexa = Helper.argbToHexa(servicio.ColorHexa);
            return servicio;
        }
    }  
}
