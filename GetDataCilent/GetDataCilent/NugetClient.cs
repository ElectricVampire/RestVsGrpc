using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetDataCilent
{
    class NugetClient
    {
        public async Task<List<Meteorite.Models.MeteoriteLanding>> GetSmallPayLoad()
        {
            var result = await Meteorite.MeteoriteDetail.GetMeteoriteLendingDetailsSmallPaylad();
            return result;

        }

        public async Task<List<Meteorite.Models.MeteoriteLanding>> GetLargePayLoad()
        {
            var result = await Meteorite.MeteoriteDetail.GetMeteoriteLendingDetailsLargePayLoad();
            return result;
        }
    }
}
