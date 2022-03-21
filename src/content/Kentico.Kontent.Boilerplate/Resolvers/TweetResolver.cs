using Kentico.Kontent.Boilerplate.Models.ContentTypes;
using Kentico.Kontent.Delivery.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kentico.Kontent.Boilerplate.Resolvers
{
    public class TweetResolver : IInlineContentItemsResolver<Tweet>
    {
        public string Resolve(Tweet data)
        {
            return
                $"<div data-kontent-component-id=\"{data.System.Id}\"><blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"light\"><a href=\"{data.TweetLink}\"></a></blockquote></div>";
        }
    }
}
