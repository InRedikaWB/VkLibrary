using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Stats
{
    public class Age
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors { get; set; }

        /// <summary>
        /// Age interval
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}