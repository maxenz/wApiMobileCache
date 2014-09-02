using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using wApiMobileForCache.Models;
using wApiMobileForCache.Utils;
using wApiMobileForCache.wsIncidentesMobile;

namespace wApiMobileForCache.Context
{
    public class WebService
    {
        private IncidentesMobileSoapClient ws;
        public WebService()
        {
            ws = new IncidentesMobileSoapClient();
        }

        public DataSet getViajesMovil(string idMovil)
        {
            ws.Open();
            DataSet dsViajes = ws.GetViajesMovil(idMovil);
            ws.Abort();
            return dsViajes;
        }

        public DataSet getViaje(string idMovil, int idServicio)
        {
            ws.Open();
            DataSet dsViaje = ws.GetViaje(idServicio, idMovil);
            ws.Abort();
            return dsViaje;
        }

        public DataSet getHistoriaClinica(int idServicio)
        {   
            return new DataSet();
        }

        public DataSet getDatosActualizadosFromTabla(string tabla)
        {
            ws.Open();
            DataSet dsFullList = ws.GetFullList(tabla);
            ws.Abort();
            return dsFullList;
        }

        public Resultado setLlegadaMovil(string movil, int viajeID)
        {
            ws.Open();
            DataTable dtResultado = ws.SetLlegada(viajeID, movil, 0, 0, "").Tables[0];
            ws.Abort();
            Resultado resultado = ListHelper.ToList<Resultado>(dtResultado).FirstOrDefault();
            if (resultado.Message == "") resultado.Message = "La llegada se dio correctamente";
            return resultado;
        }

        public Resultado setSalidaMovil(string movil, int viajeID)
        {
            ws.Open();
            DataTable dtResultado = ws.SetSalida(viajeID, movil, 0, 0, "").Tables[0];
            ws.Abort();
            Resultado resultado = ListHelper.ToList<Resultado>(dtResultado).FirstOrDefault();
            if (resultado.Message == "") resultado.Message = "La salida se dio correctamente";
            return resultado;
        }

    }
}