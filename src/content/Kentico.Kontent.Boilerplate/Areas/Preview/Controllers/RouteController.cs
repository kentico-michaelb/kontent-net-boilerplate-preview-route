using Kentico.Kontent.Boilerplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Kentico.Kontent.Boilerplate.Areas.Preview.Controllers
{
    [Area("Preview")]
    public class RouteController : Controller
    {
        public bool CheckSecret([FromQuery] string secret)
        {
            // HMAC/secret logic here
            if (secret == "good_secret")
            {
                return true;
            }

            return false;
        }
            [HttpGet("GetHeaderData")]
        public PreviewRoute GetRouteValues([FromRoute] RouteValueDictionary rv)
        {
            PreviewRoute pvRoute = new PreviewRoute();

            pvRoute.RouteController = (string)rv["routeController"];
            pvRoute.RouteAction = (string)rv["routeAction"];
            pvRoute.UrlSlug = (string)rv["urlSlug"];

            return pvRoute;
        }

        [HttpGet("GetHeaderData")]
        public PreviewRoute GetHeaderData(string headerKey)
        {
            Request.Headers.TryGetValue(headerKey, out var headerValue);

            if(headerValue == "https://app.kontent.ai/") 
            {
                Request.Query.TryGetValue("secret", out var vs);
                bool secret = CheckSecret(vs);

                var preview_route = new PreviewRoute();

                if (secret)
                {
                    preview_route = GetRouteValues(Request.RouteValues);
                }
                else
                {
                    preview_route.RouteAction = "Status";
                    preview_route.RouteController = "Error";
                }

                return preview_route;


            }

            return null;
        }

        

        [HttpGet]
        public IActionResult Check()
        {
            var result = GetHeaderData("Referer");

            return RedirectToAction(result.RouteAction, result.RouteController, new { urlSlug = result.UrlSlug });
        }
    }
}
