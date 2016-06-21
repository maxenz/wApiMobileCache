using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using wApiMobileForCache.Context;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;

namespace wApiMobile.Controllers
{
    public class ServicesController : ApiController
    {
        WebService ws = new WebService();

        public List<Servicio> Get()
        {
            string license = Helper.getValueFromQueryString("licencia");
            string idMovil = Helper.getValueFromQueryString("idMovil");
            DataSet dsViajes = ws.getViajesMovil(idMovil);
            List<Servicio> lstServ = ListHelper.ToList<Servicio>(dsViajes.Tables[0]);
            Helper.formatColorServicios(ref lstServ);
            return lstServ;
        }

        public ServicioDetalle Get(int id)
        {
            string license = Helper.getValueFromQueryString("licencia");
            string idMovil = Helper.getValueFromQueryString("idMovil");
            DataSet dsViaje = ws.getViaje(idMovil, id);
            List<ServicioDetalle> lstServ = ListHelper.ToList<ServicioDetalle>(dsViaje.Tables[0]);
            ServicioDetalle servicio = lstServ.FirstOrDefault();
            servicio.ColorHexa = Helper.oleToHexa(servicio.ColorHexa);
            return servicio;
        }

    }
}