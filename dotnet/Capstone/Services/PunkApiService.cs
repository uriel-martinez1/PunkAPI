using RestSharp; 

namespace Capstone.Services
{
    public class PunkApiService
    {
        private string apiURL;

        public PunkApiService(string apiURL)
        {
            this.apiURL = apiURL;
        }
    }
}
