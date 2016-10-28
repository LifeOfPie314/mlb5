using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using Mlb5.Models;
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
                    var result =await MlbApi.ImportGamesIfNeeded(db, date);
                        recordCount = recordCount + result;

                    date = date.AddDays(1);
                }
            }

            return Ok(recordCount);


        }

        [HttpGet]
        [Route("datetime")]
        public IHttpActionResult Datetime()
        {
            using (var db = new Mlb5Context())
            {
                SimulationDateTime simDateTime = db.SimulationDateTimes.SingleOrDefault();
                if (simDateTime == null)
                {
                    simDateTime = new SimulationDateTime() {Date = new DateTime(2016,9,23)};
                    db.SimulationDateTimes.Add(simDateTime);
                }

                return Ok(simDateTime);
            }

        }

        [HttpGet]
        [Route("setdatetime")]
        public async Task<IHttpActionResult> SetDatetime(DateTime date, int hours)
        {
            SimulationDateTime simDateTime = new SimulationDateTime();
            using (var db = new Mlb5Context())
            {
                simDateTime = db.SimulationDateTimes.SingleOrDefault();
                simDateTime.Date = date;
                simDateTime.Hours = hours;

                await db.SaveChangesAsync();
            }

            return Ok(simDateTime);
        }
    }
}