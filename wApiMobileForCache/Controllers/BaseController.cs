using System;
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
            if (this.License != null)
            {
                this.Endpoint = Helper.getServerConnectiongBySerial(this.License);
                this.WebService = new WebService(this.Endpoint);
            }
            else
            {
                throw new ArgumentNullException("Licencia");
            }

        }

        #endregion

    }
}
