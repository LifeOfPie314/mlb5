using System.Net.Http;
using System.Web.Http;
using Mlb5.ViewModels;

namespace Mlb5.Api
{
    [AllowAnonymous]
    public class HomeController : ApiController
    {

        [HttpGet]
        [Route("")]
        public HttpResponseMessage Index()
        {
            var model = new HomeViewModel
            {
                Setting1 = "mySettingFromHomeController"
            };

            var response = RazorView.GetResponseWithModel("home", "~/Views/Home/Index.cshtml", model);
            return response;
        }

        [HttpGet]
        [Route("viewer")]
        public HttpResponseMessage Viewer()
        {
            var response = RazorView.GetResponse("viewer", "~/Views/Home/Viewer.cshtml");
            return response;
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Mlb5.ViewModels;

//namespace Mlb5.Controllers
//{
//    public class HomeController : Controller
//    {
//        // GET: Home
//        public ActionResult Index()
//        {
//            
//            return View(model);
//        }
//    }
//}