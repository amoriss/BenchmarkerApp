``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 5 5500U with Radeon Graphics, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.302
  [Host]               : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  .NET 5.0             : .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
  .NET Framework 4.7.2 : .NET Framework 4.8 (4.8.4510.0), X64 RyuJIT


```
|                         Method |                  Job |              Runtime |     Mean |     Error |    StdDev | Ratio |   Gen 0 | Allocated |
|------------------------------- |--------------------- |--------------------- |---------:|----------:|----------:|------:|--------:|----------:|
|          GetFullStringNormally |             .NET 5.0 |             .NET 5.0 | 3.367 μs | 0.0437 μs | 0.0409 μs |  0.40 | 11.3487 |     23 KB |
| GetFullStringWithStringBuilder |             .NET 5.0 |             .NET 5.0 | 1.111 μs | 0.0079 μs | 0.0074 μs |  0.13 |  0.6733 |      1 KB |
|          GetFullStringNormally | .NET Framework 4.7.2 | .NET Framework 4.7.2 | 8.321 μs | 0.0186 μs | 0.0165 μs |  1.00 | 11.6882 |     24 KB |
| GetFullStringWithStringBuilder | .NET Framework 4.7.2 | .NET Framework 4.7.2 | 6.140 μs | 0.0155 μs | 0.0129 μs |  0.74 |  2.1362 |      4 KB |
