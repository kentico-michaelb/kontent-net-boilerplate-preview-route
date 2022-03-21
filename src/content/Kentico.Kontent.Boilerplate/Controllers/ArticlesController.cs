using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kentico.Kontent.Boilerplate.Models.ContentTypes;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.Urls.QueryParameters;
using Kentico.Kontent.Delivery.Urls.QueryParameters.Filters;

namespace Kentico.Kontent.Boilerplate.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly IDeliveryClient _client;

        public ArticlesController(IDeliveryClient deliveryClient)
        {
            _client = deliveryClient;
        }

        public async Task<ActionResult> Show(string urlSlug)
        {
            var response = await _client.GetItemsAsync<Article>(
                new EqualsFilter($"elements.{Article.UrlPatternCodename}", urlSlug),
                new DepthParameter(1)
            );

            if (response.Items.Count == 0)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    var article = response.Items[0];
                    
                        return View(article);
                }
                catch (Exception)
                {
                    return View(response.Items[0]);
                }
            }
        }
    }
}
