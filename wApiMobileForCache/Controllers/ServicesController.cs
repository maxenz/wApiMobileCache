using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using wApiMobileForCache.Context;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;

namespace wApiMobileForCache.Controllers
{
    public class ServicesController : BaseController
    {

        public ServicesController() : base() { }

        public List<Servicio> Get()
        {

            DataSet dsViajes = WebService.getViajesMovil(MobileId);
            List<Servicio> lstServ = ListHelper.ToList<Servicio>(dsViajes.Tables[0]);
            Helper.formatColorServicios(ref lstServ);
            return lstServ;
        }

        public ServicioDetalle Get(int id)
        {
            DataSet dsViaje = WebService.getViaje(MobileId, id);
            List<ServicioDetalle> lstServ = ListHelper.ToList<ServicioDetalle>(dsViaje.Tables[0]);
            ServicioDetalle servicio = lstServ.FirstOrDefault();
            servicio.ColorHexa = Helper.oleToHexa(servicio.ColorHexa);
            return servicio;
        }

    }
}