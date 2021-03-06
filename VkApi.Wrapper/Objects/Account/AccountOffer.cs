using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AccountOffer
    {
        ///<summary>
        /// Offer description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Offer ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// URL of the preview image
        ///</summary>
        [JsonProperty("img")]
        public String Img { get; set; }

        ///<summary>
        /// Instruction how to process the offer
        ///</summary>
        [JsonProperty("instruction")]
        public String Instruction { get; set; }

        ///<summary>
        /// Instruction how to process the offer (HTML format)
        ///</summary>
        [JsonProperty("instruction_html")]
        public String InstructionHtml { get; set; }

        ///<summary>
        /// Offer price
        ///</summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        ///<summary>
        /// Offer short description
        ///</summary>
        [JsonProperty("short_description")]
        public String ShortDescription { get; set; }

        ///<summary>
        /// Offer tag
        ///</summary>
        [JsonProperty("tag")]
        public String Tag { get; set; }

        ///<summary>
        /// Offer title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Currency amount
        ///</summary>
        [JsonProperty("currency_amount")]
        public double CurrencyAmount { get; set; }

        ///<summary>
        /// Link id
        ///</summary>
        [JsonProperty("link_id")]
        public int LinkId { get; set; }

        ///<summary>
        /// Link type
        ///</summary>
        [JsonProperty("link_type")]
        public String LinkType { get; set; }
    }
}