This is a simple repository trying to measure performance for serializing large list of small data.

Result being :
## .Net Core 3.1 ##

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  DefaultJob : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT


|                                Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |
|-------------------------------------- |---------:|---------:|---------:|---------:|------:|--------:|
|                             UsingList | 714.3 ms | 13.24 ms | 21.39 ms | 703.8 ms |  1.00 |    0.00 |
|                 UsingPreAllocatedList | 674.8 ms | 10.10 ms |  8.95 ms | 671.6 ms |  0.92 |    0.03 |
|                             UsingEnum | 654.5 ms |  9.29 ms | 10.33 ms | 651.8 ms |  0.91 |    0.03 |
|                    UsingEnumWithClass | 636.8 ms | 12.22 ms | 11.43 ms | 631.1 ms |  0.87 |    0.02 |
|             UsingEnumAndStringBuilder | 203.3 ms |  2.78 ms |  2.46 ms | 204.0 ms |  0.28 |    0.01 |
| UsingEnumAndPreAllocatedStringBuilder | 138.3 ms |  1.38 ms |  1.29 ms | 138.5 ms |  0.19 |    0.01 |

## .Net Framework 4.8 ##

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT
  DefaultJob : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT


|                                Method |       Mean |    Error |   StdDev | Ratio | RatioSD |
|-------------------------------------- |-----------:|---------:|---------:|------:|--------:|
|                             UsingList | 1,007.1 ms | 20.06 ms | 43.62 ms |  1.00 |    0.00 |
|                 UsingPreAllocatedList |   956.2 ms | 17.63 ms | 16.49 ms |  0.97 |    0.03 |
|                             UsingEnum |   809.3 ms | 13.47 ms | 16.03 ms |  0.81 |    0.03 |
|                    UsingEnumWithClass |   832.6 ms | 11.32 ms | 10.04 ms |  0.85 |    0.03 |
|             UsingEnumAndStringBuilder |   308.3 ms |  3.67 ms |  3.43 ms |  0.31 |    0.01 |
| UsingEnumAndPreAllocatedStringBuilder |   247.6 ms |  0.66 ms |  0.55 ms |  0.25 |    0.01 |