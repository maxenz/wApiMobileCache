using Newtonsoft.Json;
using System.Web.Http;
using wApiMobileForCache.Models;

namespace wApiMobileForCache.Controllers
{
    public class MobileAccessController : BaseController
    {
        public MobileAccessController() : base() {  }

		[HttpPost]
		public string Post(MobileAccessTime mobileAccessTime)
		{
			Resultado resultado = WebService.setIngresoDiario(mobileAccessTime);
			return JsonConvert.SerializeObject(resultado);
		}

	}
}
