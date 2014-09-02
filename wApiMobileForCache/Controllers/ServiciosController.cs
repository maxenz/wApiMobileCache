using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;

namespace wApiMobileForCache.Controllers
{
    public class ServiciosController : ApiController
    {

        // GET api/<controller>
        public List<Servicio> Get()
        {

            string idMovil = Helper.getValueFromQueryString("idMovil");
            wsIncidentesMobile.IncidentesMobileSoapClient ws = new wsIncidentesMobile.IncidentesMobileSoapClient();
            ws.Open();
            DataSet dsViajes = ws.GetViajesMovil(idMovil);
            ws.Abort();
            List<Servicio> lstServ = ListHelper.ToList<Servicio>(dsViajes.Tables[0]);
            //List<Servicio> servicios = db.Database.SqlQuery<Servicio>("sp_GetViajesMovil @movil = {0}", idMovil).ToList<Servicio>();
            return lstServ;
           
        }

        // GET api/<controller>/5
        //public ServicioDetalle Get(int id)
        //{
        //    string idMovil = Helper.getValueFromQueryString("idMovil");
        //    //ServicioDetalle svDetalle = db.Database.SqlQuery<ServicioDetalle>("sp_GetViaje @viajeId = {0},@movil = {1}", id,idMovil)
        //                                //.FirstOrDefault();

        //    return svDetalle;
        //}

    }
    
}
