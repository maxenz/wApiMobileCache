﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace wApiMobileForCache.Controllers
{
    public class PushNotificationController : ApiController
    {
        public bool Get(string nroMovil, string mensaje, string appID, string restApiKey)
        {
            //application id example Yu5MsVhQi7ih2ltKlNrQcrpFfvRlexZnGiecJZHd
            //rest api key example KRAjomjaryxsslXvwnuwHkZk7CRJpSwpGFkfY0aP

            string channel = "m" + nroMovil;

            bool isPushMessageSend = false;

            string postString = "";
            string urlpath = "https://api.parse.com/1/push";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlpath);
            postString = "{ \"channels\": [ \"" + channel + "\"  ], " +
                             "\"data\" : {\"alert\":\"" + mensaje + "\"}" +
                             "}";
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.ContentLength = postString.Length;
            httpWebRequest.Headers.Add("X-Parse-Application-Id", appID);
            httpWebRequest.Headers.Add("X-Parse-REST-API-KEY", restApiKey);
            httpWebRequest.Method = "POST";
            StreamWriter requestWriter = new StreamWriter(httpWebRequest.GetRequestStream());
            requestWriter.Write(postString);
            requestWriter.Close();
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                JObject jObjRes = JObject.Parse(responseText);
                if (Convert.ToString(jObjRes).IndexOf("true") != -1)
                {
                    isPushMessageSend = true;
                }
            }

            return isPushMessageSend;
        }
    }
}
