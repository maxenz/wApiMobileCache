using System;
using System.Web;
using System.Web.Http;
using wApiMobileForCache.Context;
using wApiMobileForCache.Utils;

namespace wApiMobileForCache.Controllers
{
    public class BaseController : ApiController
    {

        #region Properties

        public string License { get; set; }

        public string MobileId { get; set; }

        public string Endpoint { get; set; }

        public WebService WebService { get; set; }

        #endregion

        #region Constructors

        public BaseController()
        {
            this.License = Helper.getValueFromQueryString("licencia");
            this.MobileId = Helper.getValueFromQueryString("idMovil");

            if (this.License == null)
            {
                var form = HttpContext.Current.Request.Form;
                if (form["license"] != null)
                {
                    this.License = form["license"];
                }
                else
                {
                    throw new ArgumentNullException("Licencia");
                }

            }

            this.Endpoint = Helper.getServerConnectiongBySerial(this.License);
            this.WebService = new WebService(this.Endpoint);
        }

        #endregion

    }
}
