using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GetDataCilent
{
    //
    public class RestClient
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<List<Meteorite.Models.MeteoriteLanding>> GetSmallPayLoad()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync("http://localhost:53057/Meteorite/SmallPayload");
            return JsonConvert.DeserializeObject<List<Meteorite.Models.MeteoriteLanding>>(response);
        }

        public async Task<List<Meteorite.Models.MeteoriteLanding>> GetLargePayLoad()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetStringAsync("http://localhost:53057/Meteorite/LargePayload");
            return JsonConvert.DeserializeObject<List<Meteorite.Models.MeteoriteLanding>>(response);
        }
    }
}
