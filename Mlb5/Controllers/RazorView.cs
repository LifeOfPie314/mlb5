using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using RazorEngine;
using RazorEngine.Templating;

namespace Mlb5.Api
{
    public static class RazorView
    {
        public static HttpResponseMessage GetResponse(string templateName, string templateLocation)
        {
            var response = new HttpResponseMessage();

            var templatePath = System.Web.HttpContext.Current.Request.MapPath(templateLocation);

            var razorTemplate = File.ReadAllText(templatePath);
            var html = Engine.Razor.RunCompile(
                razorTemplate,
                templateName);

            response.Content = new StringContent(html);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;

        }

        public static HttpResponseMessage GetResponseWithModel<T>(string templateName, string templateLocation, T model)
        {
            var response = new HttpResponseMessage();

            var templatePath = System.Web.HttpContext.Current.Request.MapPath(templateLocation);

            var razorTemplate = File.ReadAllText(templatePath);
            var html = Engine.Razor.RunCompile(
                razorTemplate,
                templateName,
                modelType: typeof(T),
                model: model);

            response.Content = new StringContent(html);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}