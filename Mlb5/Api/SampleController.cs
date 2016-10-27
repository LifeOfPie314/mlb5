using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace Mlb5.Api
{
    [Authorize]
    [RoutePrefix("api/sample")]
    public class SampleController : ApiController
    {
        // GET: Sample
        [HttpGet]
        [Route]
        public IHttpActionResult Index()
        {
            var identity = User.Identity as ClaimsIdentity;

            List<Claim> claims = identity.Claims.Select(c => new Claim(c.Subject.Name, c.Type, c.Value)).ToList();

            return Ok(claims);
        }

        public class Claim
        {
            public Claim(string subject, string type, string value)
            {
                Subject = subject;
                Type = type;
                Value = value;
            }

            public string Subject { get; set; }
            public string Type { get; set; }
            public string Value { get; set; }
        }
    }
}