``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 5 5500U with Radeon Graphics, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|                         Method |     Mean |     Error |    StdDev |   Gen 0 | Allocated |
|------------------------------- |---------:|----------:|----------:|--------:|----------:|
|          GetFullStringNormally | 4.041 μs | 0.0314 μs | 0.0279 μs | 11.3449 |     23 KB |
| GetFullStringWithStringBuilder | 1.344 μs | 0.0123 μs | 0.0109 μs |  0.6733 |      1 KB |
