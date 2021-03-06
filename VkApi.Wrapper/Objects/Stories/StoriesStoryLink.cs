using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StoriesStoryLink
    {
        ///<summary>
        /// Link text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// Link URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}