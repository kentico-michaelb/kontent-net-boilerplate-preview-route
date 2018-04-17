// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace CloudBoilerplateNet.Models
{
    public partial class Brewer
    {
        public const string Codename = "brewer";
        public const string ProductNameCodename = "product_name";
        public const string PriceCodename = "price";
        public const string ImageCodename = "image";
        public const string ProductStatusCodename = "product_status";
        public const string ShortDescriptionCodename = "short_description";
        public const string LongDescriptionCodename = "long_description";
        public const string UrlPatternCodename = "url_pattern";
        public const string ManufacturerCodename = "manufacturer";
        public const string MetaTitleCodename = "metadata__meta_title";
        public const string MetaDescriptionCodename = "metadata__meta_description";
        public const string OgTitleCodename = "metadata__og_title";
        public const string OgDescriptionCodename = "metadata__og_description";
        public const string OgImageCodename = "metadata__og_image";
        public const string TwitterSiteCodename = "metadata__twitter_site";
        public const string TwitterCreatorCodename = "metadata__twitter_creator";
        public const string TwitterTitleCodename = "metadata__twitter_title";
        public const string TwitterDescriptionCodename = "metadata__twitter_description";
        public const string TwitterImageCodename = "metadata__twitter_image";

        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public IEnumerable<TaxonomyTerm> ProductStatus { get; set; }
        public IRichTextContent ShortDescription { get; set; }
        public IRichTextContent LongDescription { get; set; }
        public string UrlPattern { get; set; }
        public IEnumerable<TaxonomyTerm> Manufacturer { get; set; }
        public string MetadataMetaTitle { get; set; }
        public string MetadataMetaDescription { get; set; }
        public string MetadataOgTitle { get; set; }
        public string MetadataOgDescription { get; set; }
        public IEnumerable<Asset> MetadataOgImage { get; set; }
        public string MetadataTwitterSite { get; set; }
        public string MetadataTwitterCreator { get; set; }
        public string MetadataTwitterTitle { get; set; }
        public string MetadataTwitterDescription { get; set; }
        public IEnumerable<Asset> MetadataTwitterImage { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}