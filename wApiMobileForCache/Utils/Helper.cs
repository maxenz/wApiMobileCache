using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using wApiMobileForCache.Models;

namespace wApiMobileForCache.Utils
{
    public static class Helper
    {
        public static string getValueFromQueryString(string key)
        {
            var query = HttpContext.Current.Request.QueryString;
            if (query.GetValues(key) != null)
            {
                return query.GetValues(key)[0];
            }
            return null;
        }

        public static void formatColorServicios(ref List<Servicio> servicios)
        {
            foreach (Servicio s in servicios)
            {
                s.ColorHexa = oleToHexa(s.ColorHexa);                                
            }
        }

        public static void formatColorHC(ref List<HistoriaClinica> hc)
        {
            foreach (HistoriaClinica h in hc)
            {
                h.ColorHexa = oleToHexa(h.ColorHexa);
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

        public static string oleToHexa(string colorFromConsulta)
        {
            Color color = ColorTranslator.FromOle(Convert.ToInt32(colorFromConsulta));

            return HexConverter(color);
        }

        private static string HexConverter(Color c)
        {
            return c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public static AndroidFtpDto getAndroidFtpData(string serial)
        {
            var url = string.Format("{0}{1}", ConfigurationManager.AppSettings["GestionUrlAndroidFtp"], serial);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Http.Get;
            request.Accept = "application/json";
            request.ContentType = "application/json; charset=utf-8";

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                JObject data = JObject.Parse(responseText);
                if (data.Property("Error") != null)
                {
                    return null;
                }

                return new AndroidFtpDto()
                {
                    Dir = data.Property("FtpAndroidDir").Value.ToString(),
                    User = data.Property("FtpAndroidUser").Value.ToString(),
                    Password = data.Property("FtpAndroidPassword").Value.ToString()
                };

            }

        }

        public static void UploadToFtp(AndroidFtpDto ftpData)
        {
            string path = string.Format(@"AndroidUploads/{0}/{1}", ftpData.License, ftpData.Mobile);
            MakeFTPDir(ftpData, path);

            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential(ftpData.User, ftpData.Password);
                client.UploadFile(ftpData.RemoteFileDir + new FileInfo(ftpData.LocalFileDir).Name, "STOR", ftpData.LocalFileDir);
            }
        }

        private static void MakeFTPDir(AndroidFtpDto ftpData, string pathToCreate)
        {
            FtpWebRequest reqFTP = null;
            Stream ftpStream = null;

            string[] subDirs = pathToCreate.Split('/');

            string currentDir = ftpData.Dir;

            foreach (string subDir in subDirs)
            {
                try
                {
                    currentDir = currentDir + "/" + subDir;
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(currentDir);
                    reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                    reqFTP.UseBinary = true;
                    reqFTP.Credentials = new NetworkCredential(ftpData.User, ftpData.Password);
                    FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                    ftpStream = response.GetResponseStream();
                    ftpStream.Close();
                    response.Close();
                }
                catch (Exception ex)
                {
                    //directory already exist I know that is weak but there is no way to check if a folder exist on ftp...
                }
            }
        }

        public static int getHoursFromTime(string time)
        {
            if (String.IsNullOrEmpty(time) || time == "null")
            {
                return 0;
            }

            return Convert.ToInt32(time.Split(':')[0]);
        }

        public static int getMinutesFromTime(string time)
        {
            if (String.IsNullOrEmpty(time) || time == "null")
            {
                return 0;
            }

            return Convert.ToInt32(time.Split(':')[1]);
        }

        public static string getServerConnectiongBySerial(string serial)
        {
            var url = string.Format("{0}{1}", ConfigurationManager.AppSettings["GestionUrlServerConnection"], serial);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Http.Get;
            request.Accept = "application/json";
            request.ContentType = "application/json; charset=utf-8";

            var httpResponse = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                JObject cnnString = JObject.Parse(responseText);
                if (cnnString.Property("ConexionServidor") != null)
                {
                    return cnnString.Property("ConexionServidor").Value.ToString();
                }
            }

            return null;

        }

    }
}