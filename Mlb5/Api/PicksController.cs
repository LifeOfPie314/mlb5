using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Mlb5.Tasks;

namespace Mlb5.Api
{
    [RoutePrefix("api/picks")]
    public class PicksController : ApiController
    {
        [Route("{year}/{month}/{day}")]
        [HttpGet]
        public async Task<IHttpActionResult> Index(int year, int month, int day)
        {
            var date = new DateTime(year, month, day);

            var mlbApi = new MlbApi();
            var response = await mlbApi.GetGameFiles(date);

            return Ok(response);
        }

        [Route("{year}/{month}/{day}/xml")]
        [HttpGet]
        public async Task<IHttpActionResult> Xml(int year, int month, int day)
        {
            var date = new DateTime(year, month, day);

            var mlbApi = new MlbApi();
            var response = await mlbApi.GetGameFiles(date);

            return Ok(response);
        }

        [Route("{year}/{month}/{day}/json")]
        [HttpGet]
        public async Task<IHttpActionResult> Json(int year, int month, int day)
        {
            var date = new DateTime(year, month, day);

            var mlbApi = new MlbApi();
            var response = await mlbApi.Get(date);

            return Ok(response);
        }
    }
}
