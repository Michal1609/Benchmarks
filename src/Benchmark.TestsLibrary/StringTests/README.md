BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1806 (21H1/May2021Update)
Intel Core i5-6300HQ CPU 2.30GHz (Skylake), 1 CPU, 4 logical and 4 physical cores
.NET SDK=7.0.100-preview.5.22307.18
  [Host]     : .NET 7.0.0 (7.0.22.30112), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 7.0.0 (7.0.22.30112), X64 RyuJIT

|                    Method |        Mean |      Error |     StdDev | Allocated |
|-------------------------- |------------:|-----------:|-----------:|----------:|
|          StartsWithString | 760.3081 ns | 13.1544 ns | 14.6210 ns |         - |
|   StarstWithStringOrdinal |   2.0281 ns |  0.0582 ns |  0.0516 ns |         - |
| StarstWithStringInvariant |  25.6749 ns |  0.5565 ns |  1.0723 ns |         - |
|       StartsWithCharacter |   0.4732 ns |  0.0518 ns |  0.0532 ns |         - |


|                      Method |        Mean |     Error |     StdDev |      Median | Allocated |
|---------------------------- |------------:|----------:|-----------:|------------:|----------:|
|                    Contains |    11.62 ns |  0.212 ns |   0.188 ns |    11.58 ns |         - |
|             ContainsOrdinal |    15.76 ns |  0.354 ns |   0.550 ns |    15.81 ns |         - |
|           ContainsInvariant |    52.08 ns |  1.087 ns |   1.875 ns |    51.93 ns |         - |
|   ContainsOrdinalIgnoreCase |    29.66 ns |  0.633 ns |   0.677 ns |    29.59 ns |         - |
| ContainsInvariantIgnoreCase |    57.58 ns |  1.181 ns |   1.731 ns |    57.49 ns |         - |
|                     IndexOf | 2,756.28 ns | 54.401 ns | 122.792 ns | 2,733.78 ns |         - |
|              IndexOfOrdinal | 2,682.05 ns | 53.685 ns | 136.645 ns | 2,635.46 ns |         - |
|            IndexOfInvariant | 2,697.78 ns | 53.412 ns | 142.567 ns | 2,650.65 ns |         - |
|    IndexOfOrdinalIgnoreCase |    30.85 ns |  0.628 ns |   1.782 ns |    29.97 ns |         - |
|  IndexOfInvariantIgnoreCase |    60.88 ns |  1.258 ns |   3.201 ns |    61.80 ns |         - |