This is a simple repository trying to measure performance for serializing large list of small data.

Result being :
## .Net Core 3.1 ##

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  DefaultJob : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

### LargeSimpleListBenchMark ###

|                                Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |
|-------------------------------------- |---------:|---------:|---------:|---------:|------:|--------:|
|                             UsingList | 702.8 ms |  6.60 ms |  5.85 ms | 702.5 ms |  1.00 |    0.00 |
|                 UsingPreAllocatedList | 675.1 ms |  7.07 ms |  6.27 ms | 673.1 ms |  0.96 |    0.01 |
|                             UsingEnum | 679.1 ms | 12.98 ms | 31.59 ms | 668.9 ms |  0.93 |    0.02 |
|                    UsingEnumWithClass | 663.1 ms | 11.52 ms | 19.25 ms | 662.6 ms |  0.96 |    0.03 |
|          UsingEnumWithClassAndJsonNet | 403.4 ms |  7.19 ms |  6.72 ms | 402.2 ms |  0.57 |    0.01 |
|             UsingEnumAndStringBuilder | 209.9 ms |  4.14 ms |  6.20 ms | 208.4 ms |  0.30 |    0.01 |
| UsingEnumAndPreAllocatedStringBuilder | 141.1 ms |  2.81 ms |  4.21 ms | 140.1 ms |  0.20 |    0.01 |

### SingleObjectBenchMark ###

|                               Method |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------------- |----------:|----------:|----------:|------:|--------:|
|            UsingAnymousSerialization | 10.434 us | 0.2083 us | 0.5227 us |  1.00 |    0.00 |
| UsingAnymousSerializationWithJsonNet |  6.407 us | 0.1232 us | 0.3113 us |  0.62 |    0.04 |
|                     UsingStringBuild |  3.596 us | 0.0795 us | 0.2294 us |  0.35 |    0.03 |

## .Net Framework 4.8 ##

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT
  DefaultJob : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT

### LargeSimpleListBenchMark ###
|                                Method |     Mean |    Error |   StdDev | Ratio | RatioSD |
|-------------------------------------- |---------:|---------:|---------:|------:|--------:|
|                             UsingList | 949.9 ms |  6.78 ms |  6.34 ms |  1.00 |    0.00 |
|                 UsingPreAllocatedList | 929.7 ms |  9.97 ms |  8.84 ms |  0.98 |    0.01 |
|                             UsingEnum | 820.0 ms |  6.72 ms |  5.61 ms |  0.86 |    0.01 |
|                    UsingEnumWithClass | 800.2 ms | 15.31 ms | 14.32 ms |  0.84 |    0.02 |
|          UsingEnumWithClassAndJsonNet | 743.5 ms |  7.93 ms |  7.03 ms |  0.78 |    0.01 |
|             UsingEnumAndStringBuilder | 301.9 ms |  3.94 ms |  3.50 ms |  0.32 |    0.00 |
| UsingEnumAndPreAllocatedStringBuilder | 245.3 ms |  1.96 ms |  1.83 ms |  0.26 |    0.00 |

### SingleObjectBenchMark ###

|                               Method |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------------- |----------:|----------:|----------:|------:|--------:|
|            UsingAnymousSerialization | 14.125 us | 0.2779 us | 0.6385 us |  1.00 |    0.00 |
| UsingAnymousSerializationWithJsonNet | 12.135 us | 0.1500 us | 0.1171 us |  0.89 |    0.03 |
|                     UsingStringBuild |  4.917 us | 0.0979 us | 0.2250 us |  0.35 |    0.02 |

## .Net 5.0-preview.6 ##

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-preview.6.20318.15
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.30506, CoreFX 5.0.20.30506), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.30506, CoreFX 5.0.20.30506), X64 RyuJIT

### LargeSimpleListBenchMark ###

|                                Method |     Mean |    Error |   StdDev |   Median | Ratio | RatioSD |
|-------------------------------------- |---------:|---------:|---------:|---------:|------:|--------:|
|                             UsingList | 706.5 ms | 16.50 ms | 47.59 ms | 692.1 ms |  1.00 |    0.00 |
|                 UsingPreAllocatedList | 707.5 ms | 15.24 ms | 42.73 ms | 705.0 ms |  1.01 |    0.08 |
|                             UsingEnum | 646.5 ms | 12.80 ms | 32.34 ms | 640.5 ms |  0.93 |    0.07 |
|                    UsingEnumWithClass | 622.1 ms | 11.98 ms | 27.78 ms | 615.5 ms |  0.90 |    0.07 |
|          UsingEnumWithClassAndJsonNet | 436.5 ms | 10.68 ms | 30.80 ms | 435.3 ms |  0.62 |    0.06 |
|             UsingEnumAndStringBuilder | 229.1 ms |  4.78 ms | 13.94 ms | 229.3 ms |  0.33 |    0.03 |
| UsingEnumAndPreAllocatedStringBuilder | 180.1 ms |  3.57 ms |  8.21 ms | 180.7 ms |  0.26 |    0.02 |

### SingleObjectBenchMark ###

|                               Method |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------------------- |----------:|----------:|----------:|------:|--------:|
|            UsingAnymousSerialization | 10.180 us | 0.2012 us | 0.5047 us |  1.00 |    0.00 |
| UsingAnymousSerializationWithJsonNet |  5.392 us | 0.1057 us | 0.1258 us |  0.53 |    0.03 |
|                     UsingStringBuild |  3.527 us | 0.0740 us | 0.2182 us |  0.35 |    0.03 |