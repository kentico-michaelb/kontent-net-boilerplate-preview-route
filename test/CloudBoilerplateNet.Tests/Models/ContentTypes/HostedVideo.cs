// This code was generated by a cloud-generators-net tool 
// (see https://github.com/Kentico/cloud-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using KenticoCloud.Delivery;

namespace CloudBoilerplateNet.Tests.Models
{
    public partial class HostedVideo
    {
        public const string Codename = "hosted_video";
        public const string VideoIdCodename = "video_id";
        public const string VideoHostCodename = "video_host";

        public string VideoId { get; set; }
        public IEnumerable<MultipleChoiceOption> VideoHost { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}