``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 5 5500U with Radeon Graphics, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]     : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  DefaultJob : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT


```
|                         Method |     Mean |     Error |    StdDev | Ratio |   Gen 0 | Allocated |
|------------------------------- |---------:|----------:|----------:|------:|--------:|----------:|
|          GetFullStringNormally | 3.444 μs | 0.0681 μs | 0.0909 μs |  1.00 | 11.3487 |     23 KB |
| GetFullStringWithStringBuilder | 1.146 μs | 0.0060 μs | 0.0053 μs |  0.34 |  0.6733 |      1 KB |
