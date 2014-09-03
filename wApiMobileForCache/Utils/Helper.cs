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
                Color colorArgb = Color.FromArgb(Convert.ToInt32(s.ColorHexa));
                s.ColorHexa = "#" + colorArgb.R.ToString("X2") + colorArgb.G.ToString("X2") + colorArgb.B.ToString("X2");                                 
            }
        }
    }
}