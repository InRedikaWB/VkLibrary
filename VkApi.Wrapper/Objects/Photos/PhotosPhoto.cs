using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class PhotosPhoto
    {
        ///<summary>
        /// Access key for the photo
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }

        ///<summary>
        /// Album ID
        ///</summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }

        ///<summary>
        /// Date when uploaded
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Original photo height
        ///</summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        ///<summary>
        /// Photo ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("images")]
        public PhotosImage[] Images { get; set; }

        ///<summary>
        /// Latitude
        ///</summary>
        [JsonProperty("lat")]
        public double Lat { get; set; }

        ///<summary>
        /// Longitude
        ///</summary>
        [JsonProperty("long")]
        public double Long { get; set; }

        ///<summary>
        /// Photo owner's ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
        [JsonProperty("sizes")]
        public PhotosPhotoSizes[] Sizes { get; set; }

        ///<summary>
        /// Photo caption
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// ID of the user who have uploaded the photo
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        ///<summary>
        /// Original photo width
        ///</summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        ///<summary>
        /// Whether photo has attached tag links
        ///</summary>
        [JsonProperty("has_tags")]
        public Boolean HasTags { get; set; }
    }
}