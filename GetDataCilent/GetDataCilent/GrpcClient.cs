using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcService;
using static GrpcService.GrpcDataRepo;

namespace GetDataCilent
{
    public class GrpcClient
    {
        private readonly GrpcDataRepoClient client;

        public GrpcClient()
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            client = new GrpcDataRepo.GrpcDataRepoClient(GrpcChannel.ForAddress("https://localhost:5001"));
        }
        public async Task<MeteoriteLandingList> GetSmallPayLoad()
        {
            var result = await client.GetDataAsync(new Request() { PayLoadSize = "s" });
            return result;

        }

        public async Task<MeteoriteLandingList> GetLargePayLoad()
        {
            var result = await client.GetDataAsync(new Request() { PayLoadSize = "l" });
            return result;
        }

    }
}
