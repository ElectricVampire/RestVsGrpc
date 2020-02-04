using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Validators;

using System.Linq;
using System.Threading.Tasks;

namespace GetDataCilent
{
    [AsciiDocExporter]
    [CsvExporter]
    [HtmlExporter]
   public class BenchMarkFinder
    {
        [Params(100, 200, 300, 500, 800, 1000, 1300)]
        public int IterationCount;

        NugetClient nugetClient = new NugetClient();
        GrpcClient grpcClient = new GrpcClient();
        RestClient restClient = new RestClient();
        [Benchmark]
        public async Task RestGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await restClient.GetSmallPayLoad();
            }
        }

        [Benchmark]
        public async Task RestGetLargePayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await restClient.GetLargePayLoad();
            }
        }
        [Benchmark]
        public async Task GrpcGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await grpcClient.GetSmallPayLoad();
            }
        }

        [Benchmark]
        public async Task GrpcGetLargePayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await grpcClient.GetLargePayLoad();
            }
        }
        [Benchmark]
        public async Task NugetGetSmallPayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await nugetClient.GetSmallPayLoad();
            }
        }

        [Benchmark]
        public async Task NugetGetLargePayloadAsync()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                await nugetClient.GetLargePayLoad();
            }
        }
    }
}
