using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using wApiMobileForCache.Models;

namespace wApiMobileForCache.Utils
{
    public class Helper
    {
        public static string getValueFromQueryString(string key)
        {
            var query = HttpContext.Current.Request.QueryString;
            return query.GetValues(key)[0];
        }

        public static void formatColorServicios(ref List<Servicio> servicios)
        {
            foreach (Servicio s in servicios)
            {
                s.ColorHexa = argbToHexa(s.ColorHexa);                                
            }
        }

        public static void formatColorHC(ref List<HistoriaClinica> hc)
        {
            foreach (HistoriaClinica h in hc)
            {
                h.ColorHexa = argbToHexa(h.ColorHexa);
            }
        }

        public static void formatFechaHC(ref List<HistoriaClinica> hc)
        {
            foreach (HistoriaClinica h in hc)
            {
                h.FecIncidente = ansiFechaToFormatted(h.FecIncidente);
            }
        }

        public static string ansiFechaToFormatted(string fecha)
        {
            return fecha.Substring(6, 2) + "/" + fecha.Substring(4, 2) + "/" + fecha.Substring(0, 4);
        }

        public static string argbToHexa(string colorFromConsulta)
        {
            Color colorArgb = Color.FromArgb(Convert.ToInt32(colorFromConsulta));
            return colorArgb.R.ToString("X2") + colorArgb.G.ToString("X2") + colorArgb.B.ToString("X2");   
        }

    }
}