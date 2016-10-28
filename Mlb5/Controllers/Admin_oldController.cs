//using System;
//using System.IO;
//using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Threading.Tasks;
//using System.Web.Http;
//using Mlb5.Tasks;
//using Mlb5.ViewModels;
//using RazorView = Mlb5.Api.RazorView;

//namespace Mlb5.Controllers
//{
//    [RoutePrefix("admin")]
//    public class AdminController : ApiController
//    {

//        // GET: Admin
//        [HttpGet]
//        [Route("")]
//        public HttpResponseMessage Index()
//        {
//            var response = RazorView.GetResponse("admin-index", "~/Views/Admin/Index.cshtml");
//            return response;
//        }

//        [HttpGet]
//        [Route("load")]
//        public HttpResponseMessage LoadData()
//        {
//            var templatePath = System.Web.HttpContext.Current.Request.MapPath("~/Views/Admin/LoadData.cshtml");

//            var html = File.ReadAllText(templatePath);
//            var response = new HttpResponseMessage();

//            response.Content = new StringContent(html);
//            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
//            return response;

//        }

//        [HttpPost]
//        [Route("load")]
//        public async Task<IHttpActionResult> LoadDataPost(DateTime startDate, DateTime endDate)
//        {
//            if (endDate < startDate)
//                return Ok("Error invalid dates");
//            var date = startDate;
//            var lastDate = endDate.AddDays(1);

            
//            var recordCount = 0;

//            using (var db = new Mlb5Context())
//            {

//                while (date < lastDate)
//                {
//                    if (!db.Games.Any(x => x.Date == date))
//                    {
//                        var mlbApi = new MlbApi();

//                        var games = await mlbApi.GetGameFiles(date);

//                        db.Games.AddRange(games);

//                        var result = await db.SaveChangesAsync();
//                        recordCount = recordCount + result;
//                    }

//                    date = date.AddDays(1);
//                }
//            }

//            return Ok(recordCount);
//        }
//    }
//}