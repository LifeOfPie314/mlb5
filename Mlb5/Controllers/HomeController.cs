using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using Mlb5.Tasks;
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

        [HttpGet]
        [Route("load")]
        public HttpResponseMessage Load()
        {
            var templatePath = System.Web.HttpContext.Current.Request.MapPath("~/Views/Home/Load.cshtml");

            var html = File.ReadAllText(templatePath);
            var response = new HttpResponseMessage();

            response.Content = new StringContent(html);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }

        [HttpGet]
        [Route("loaddata")]
        public async Task<IHttpActionResult> LoadData(DateTime startdate, DateTime enddate)
        {
            if (enddate < startdate)
                return Ok("Error invalid dates");
            var date = startdate;
            var lastDate = enddate.AddDays(1);


            var recordCount = 0;

            using (var db = new Mlb5Context())
            {

                while (date < lastDate)
                {
                    if (!db.Games.Any(x => x.Date == date))
                    {
                        var mlbApi = new MlbApi();

                        var games = await mlbApi.GetGameFiles(date);

                        db.Games.AddRange(games);

                        var result = await db.SaveChangesAsync();
                        recordCount = recordCount + result;
                    }

                    date = date.AddDays(1);
                }
            }

            return Ok(recordCount);


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