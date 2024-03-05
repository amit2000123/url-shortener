using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using url_shortener.Models;

namespace url_shortener.Controllers
{
    public class RedirectController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage RedirectUrl(string shortLink)
        {
            try
            {
                string originUrl = Functions.GetOriginUrl(shortLink);
                if (originUrl != null)
                {
                    var response = Request.CreateResponse(HttpStatusCode.Moved);
                    response.Headers.Location = new Uri(originUrl);
                    return response;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Short link not found");
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "An error occurred while processing your request");
            }
        }
    }
}