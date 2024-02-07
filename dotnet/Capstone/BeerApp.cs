using Capstone.Services;
using Capstone.Models;

namespace Capstone
{
    public class BeerApp
    {
        private readonly PunkApiService punkApiService;


        public BeerApp(string apiURL)
        {
            this.punkApiService = new PunkApiService(apiURL);
        }
    }
}
