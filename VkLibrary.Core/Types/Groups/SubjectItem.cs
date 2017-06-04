using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Groups
{
    public class SubjectItem
    {
        /// <summary>
        /// Subject ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Subject title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}