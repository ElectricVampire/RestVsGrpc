using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Meteorite;

namespace GrpcService
{
    public class GrpcDataService : GrpcDataRepo.GrpcDataRepoBase
    {
        private readonly ILogger<GrpcDataService> _logger;
        public GrpcDataService(ILogger<GrpcDataService> logger)
        {
            _logger = logger;
        }

        public override async Task<MeteoriteLandingList> GetData(Request request, ServerCallContext context)
        {
            List<MeteoriteLanding> data = null;
            if (request.PayLoadSize == "s")
            { 
                data = await MeteoriteDetail.GetMeteoriteLendingDetailsSmallPaylad(); 
            }
            else
            {
                data = await MeteoriteDetail.GetMeteoriteLendingDetailsLargePayLoad();
            }
            var obj = new MeteoriteLandingList();
            obj.MeteoriteLandings.AddRange(data);
            return await Task.FromResult(obj);
        }
    }
}
