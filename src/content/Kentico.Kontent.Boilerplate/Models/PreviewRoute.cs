using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kentico.Kontent.Boilerplate.Models
{
    public class PreviewRoute
    {
        [FromHeader]
        public string UrlSlug { get; set; }
        [FromHeader]
        public string RouteController { get; set; }
        [FromHeader]
        public string RouteAction { get; set; }
        [FromQuery]
        public string Secret { get; set; }

    }
}
