using HealthAppFrontend.DataRepository.IDataRepository;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace HealthAppFrontend.DataRepository
{
    public class DataRepository<T> : IDataRepository<T> where T : class
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public DataRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<T>> GetAllAsync(string ApiURL)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, ApiURL);

            var client = _httpClientFactory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if(response.StatusCode == HttpStatusCode.OK)
            {
                var stringJson = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<T>>(stringJson);
            }
            return null;
        }

        public async Task<T> GetByIdAsync(string ApiURL)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, ApiURL);

            var client = _httpClientFactory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringJson = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(stringJson);
            }
            return null;
        }

        public Task<bool> InsertAsync(string ApiURL, T newObject)
        {
            throw new System.NotImplementedException();
        }
    }
}
