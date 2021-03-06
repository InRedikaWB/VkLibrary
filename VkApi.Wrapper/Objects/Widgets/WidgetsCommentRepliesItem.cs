using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WidgetsCommentRepliesItem
    {
        ///<summary>
        /// Comment ID
        ///</summary>
        [JsonProperty("cid")]
        public int Cid { get; set; }

        ///<summary>
        /// Date when the comment has been added in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }
        [JsonProperty("likes")]
        public WidgetsWidgetLikes Likes { get; set; }

        ///<summary>
        /// Comment text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("uid")]
        public int Uid { get; set; }
        [JsonProperty("user")]
        public UsersUserFull User { get; set; }
    }
}