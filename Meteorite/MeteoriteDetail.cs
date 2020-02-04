using Meteorite.Models;
using System;
using System.Threading;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Meteorite
{
    public class MeteoriteDetail
    {
        public async static Task<List<MeteoriteLanding>> GetMeteoriteLendingDetailsSmallPaylad()
        {
            var data = await GetMeteoriteLendingDetails(@"DataFiles\MeteoriteLandings.json");
            return data;
        }

        public async static Task<List<MeteoriteLanding>> GetMeteoriteLendingDetailsLargePayLoad()
        {
            var data = await GetMeteoriteLendingDetails(@"DataFiles\MeteoriteLandingsLarge.json");
            return data;
        }
        private async static Task<List<MeteoriteLanding>> GetMeteoriteLendingDetails(string fileName)
        {
            var data = await File.ReadAllTextAsync(@"DataFiles\MeteoriteLandings.json");
            return  JsonConvert.DeserializeObject<List<MeteoriteLanding>>(data);
        }
    }
}
