``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Xeon Platinum 8259CL CPU 2.50GHz, 1 CPU, 2 logical cores and 1 physical core
Frequency=3579545 Hz, Resolution=279.3651 ns, Timer=ACPI
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|                    Method | IterationCount |     Mean |    Error |   StdDev |
|-------------------------- |--------------- |---------:|---------:|---------:|
|  **RestGetSmallPayloadAsync** |            **100** |  **4.273 s** | **0.0844 s** | **0.1036 s** |
|  RestGetLargePayloadAsync |            100 |  4.153 s | 0.0437 s | 0.0365 s |
|  GrpcGetSmallPayloadAsync |            100 |  5.543 s | 0.1076 s | 0.1361 s |
|  GrpcGetLargePayloadAsync |            100 |  5.443 s | 0.0607 s | 0.0538 s |
| NugetGetSmallPayloadAsync |            100 |  1.849 s | 0.0331 s | 0.0277 s |
| NugetGetLargePayloadAsync |            100 |  1.820 s | 0.0202 s | 0.0189 s |
|  **RestGetSmallPayloadAsync** |            **200** |  **8.206 s** | **0.1588 s** | **0.1326 s** |
|  RestGetLargePayloadAsync |            200 |  8.310 s | 0.1635 s | 0.1946 s |
|  GrpcGetSmallPayloadAsync |            200 | 10.966 s | 0.2181 s | 0.2240 s |
|  GrpcGetLargePayloadAsync |            200 | 11.140 s | 0.2402 s | 0.3123 s |
| NugetGetSmallPayloadAsync |            200 |  3.729 s | 0.0460 s | 0.0430 s |
| NugetGetLargePayloadAsync |            200 |  3.697 s | 0.0456 s | 0.0381 s |
|  **RestGetSmallPayloadAsync** |            **300** | **12.570 s** | **0.1306 s** | **0.1019 s** |
|  RestGetLargePayloadAsync |            300 | 12.560 s | 0.2481 s | 0.2321 s |
|  GrpcGetSmallPayloadAsync |            300 | 16.543 s | 0.2783 s | 0.2603 s |
|  GrpcGetLargePayloadAsync |            300 | 16.510 s | 0.3631 s | 0.3396 s |
| NugetGetSmallPayloadAsync |            300 |  5.554 s | 0.0906 s | 0.0757 s |
| NugetGetLargePayloadAsync |            300 |  5.517 s | 0.0843 s | 0.0789 s |
|  **RestGetSmallPayloadAsync** |            **500** | **20.886 s** | **0.2731 s** | **0.2421 s** |
|  RestGetLargePayloadAsync |            500 | 20.901 s | 0.4173 s | 0.3903 s |
|  GrpcGetSmallPayloadAsync |            500 | 27.709 s | 0.3391 s | 0.3172 s |
|  GrpcGetLargePayloadAsync |            500 | 29.791 s | 0.5923 s | 1.0680 s |
| NugetGetSmallPayloadAsync |            500 |  9.233 s | 0.1325 s | 0.1240 s |
| NugetGetLargePayloadAsync |            500 |  9.261 s | 0.0857 s | 0.0801 s |
|  **RestGetSmallPayloadAsync** |            **800** | **33.665 s** | **0.5898 s** | **0.5517 s** |
|  RestGetLargePayloadAsync |            800 | 36.857 s | 0.7047 s | 0.6921 s |
|  GrpcGetSmallPayloadAsync |            800 | 50.699 s | 0.5267 s | 0.4927 s |
|  GrpcGetLargePayloadAsync |            800 | 50.802 s | 0.6375 s | 0.5963 s |
| NugetGetSmallPayloadAsync |            800 | 15.205 s | 0.1965 s | 0.1838 s |
| NugetGetLargePayloadAsync |            800 | 15.198 s | 0.1633 s | 0.1528 s |
|  **RestGetSmallPayloadAsync** |           **1000** | **46.187 s** | **0.7215 s** | **0.6396 s** |
|  RestGetLargePayloadAsync |           1000 | 45.907 s | 0.8865 s | 0.8293 s |
|  GrpcGetSmallPayloadAsync |           1000 | 63.339 s | 0.8313 s | 0.7776 s |
|  GrpcGetLargePayloadAsync |           1000 | 62.562 s | 0.5007 s | 0.4683 s |
| NugetGetSmallPayloadAsync |           1000 | 18.881 s | 0.2120 s | 0.1879 s |
| NugetGetLargePayloadAsync |           1000 | 19.100 s | 0.1349 s | 0.1196 s |
|  **RestGetSmallPayloadAsync** |           **1300** | **60.089 s** | **1.0423 s** | **0.9240 s** |
|  RestGetLargePayloadAsync |           1300 | 59.419 s | 0.8330 s | 0.7792 s |
|  GrpcGetSmallPayloadAsync |           1300 | 82.088 s | 0.5295 s | 0.4953 s |
|  GrpcGetLargePayloadAsync |           1300 | 82.289 s | 0.7383 s | 0.6906 s |
| NugetGetSmallPayloadAsync |           1300 | 25.005 s | 0.1792 s | 0.1677 s |
| NugetGetLargePayloadAsync |           1300 | 24.691 s | 0.2189 s | 0.2048 s |
