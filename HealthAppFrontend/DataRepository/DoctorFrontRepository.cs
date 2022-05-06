using HealthAppFrontend.DataRepository.IDataRepository;
using HealthAppFrontend.Models;
using System.Net.Http;

namespace HealthAppFrontend.DataRepository
{
    public class DoctorFrontRepository : DataRepository<DoctorFront>, IDoctorFrontRepository
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public DoctorFrontRepository(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
    }
}
