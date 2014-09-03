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
            ws.Open();
            DataSet dsHistoriaClinica = ws.GetHC(idServicio);
            ws.Abort();
            return dsHistoriaClinica;
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

        public Resultado setFinalServicio(string movil, int viajeID, int motivoID, int diagnosticoID, string observaciones, int copago)
        {
            ws.Open();
            DataTable dtResultado = ws.SetFinal(viajeID, movil, diagnosticoID, motivoID, copago, observaciones, 0, 0, "").Tables[0];
            ws.Abort();
            Resultado resultado = ListHelper.ToList<Resultado>(dtResultado).FirstOrDefault();
            if (resultado.Message == "") resultado.Message = "El servicio se ha finalizado correctamente";
            return resultado;
        }

        public Resultado setCancelacionServicio(string movil, int viajeID, string observaciones)
        {
            ws.Open();
            DataTable dtResultado = ws.SetCancelacion(viajeID, movil, observaciones, 0, 0, "").Tables[0];
            ws.Abort();
            Resultado resultado = ListHelper.ToList<Resultado>(dtResultado).FirstOrDefault();
            if (resultado.Message == "") resultado.Message = "El servicio se ha cancelado correctamente";
            return resultado;
        }

    }
}