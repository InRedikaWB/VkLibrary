using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Streaming
    {
        private readonly Vkontakte _vkontakte;

        internal Streaming(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Allows to receive data for the connection to Streaming API.
        ///</summary>
        public Task<StreamingGetServerUrlResponse> GetServerUrl()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<StreamingGetServerUrlResponse>("streaming.getServerUrl", parameters);
        }
    }
}