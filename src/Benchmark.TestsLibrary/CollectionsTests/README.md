Results

|                                          Method |    Size |            Mean |          Error |         StdDev |     Gen 0 |     Gen 1 |     Gen 2 |   Allocated |
|------------------------------------------------ |-------- |----------------:|---------------:|---------------:|----------:|----------:|----------:|------------:|
| AddItemsIntoListWithoutInitializationOfCapacity |      10 |        80.78 ns |       1.432 ns |       1.471 ns |    0.0688 |         - |         - |       216 B |
|    AddItemsIntoListWithInitializationOfCapacity |      10 |        70.50 ns |       1.418 ns |       1.632 ns |    0.0305 |         - |         - |        96 B |
| AddItemsIntoListWithoutInitializationOfCapacity |    1000 |     2,727.74 ns |      31.496 ns |      26.300 ns |    2.6817 |         - |         - |     8,424 B |
|    AddItemsIntoListWithInitializationOfCapacity |    1000 |     2,165.15 ns |      38.648 ns |      63.500 ns |    1.2894 |         - |         - |     4,056 B |
| AddItemsIntoListWithoutInitializationOfCapacity |   10000 |    29,632.20 ns |     447.809 ns |     396.971 ns |   41.6565 |         - |         - |   131,400 B |
|    AddItemsIntoListWithInitializationOfCapacity |   10000 |    22,496.33 ns |     418.901 ns |     744.596 ns |   12.6343 |         - |         - |    40,056 B |
| AddItemsIntoListWithoutInitializationOfCapacity | 1000000 | 7,300,130.34 ns | 145,099.433 ns | 350,431.440 ns | 1781.2500 | 1781.2500 | 1781.2500 | 8,389,611 B |
|    AddItemsIntoListWithInitializationOfCapacity | 1000000 | 4,692,637.22 ns |  50,507.266 ns |  44,773.375 ns |  992.1875 |  992.1875 |  992.1875 | 4,000,395 B |


|                             Method | Size |        Mean |      Error |     StdDev |      Median |  Gen 0 | Allocated |
|----------------------------------- |----- |------------:|-----------:|-----------:|------------:|-------:|----------:|
| AddWithoutInitializationOfCapacity |   10 |   162.61 ns |   3.354 ns |   9.889 ns |   164.95 ns | 0.1044 |     328 B |
|    AddWithInitializationOfCapacity |   10 |    68.33 ns |   1.648 ns |   4.754 ns |    65.88 ns | 0.0433 |     136 B |
| AddWithoutInitializationOfCapacity | 1000 | 6,903.93 ns | 144.439 ns | 416.740 ns | 6,693.84 ns | 5.2872 |  16,600 B |
|    AddWithInitializationOfCapacity | 1000 | 5,187.71 ns |  88.029 ns | 225.651 ns | 5,112.54 ns | 2.5635 |   8,056 B |