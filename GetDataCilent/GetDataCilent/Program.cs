using System;
using System.Net.Http;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;
using Grpc.Net.Client;
using GrpcService;

namespace GetDataCilent
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            //AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            //using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new GrpcDataRepo.GrpcDataRepoClient(channel);
            //var reply = await client.GetDataAsync(new Request() { PayLoadSize = "s"}) ;
            //var result = reply.CalculateSize();
            BenchmarkRunner.Run<BenchMarkFinder>();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
        }
    }
}
