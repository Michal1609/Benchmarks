Results


Any vs Contains
|                    Method |        Mean |     Error |    StdDev | Allocated |
|-------------------------- |------------:|----------:|----------:|----------:|
|       ListAnyConcreteItem | 12,128.2 ns | 238.30 ns | 398.14 ns |      40 B |
|  ListContainsConcreteItem |    120.7 ns |   2.46 ns |   2.83 ns |         - |
|      ArrayAnyConcreteItem |  8,576.8 ns | 171.36 ns | 326.03 ns |      32 B |
| ArrayContainsConcreteItem |    142.1 ns |   2.61 ns |   3.01 ns |         - |


Checking if collection contains any data. Ite means is not null and not empty.
|                             Method |      Mean |     Error |    StdDev |    Median | Allocated |
|----------------------------------- |----------:|----------:|----------:|----------:|----------:|
|                            ListAny | 5.5480 ns | 0.1576 ns | 0.1618 ns | 5.5334 ns |         - |
|                      CheckByLenght | 0.0531 ns | 0.0368 ns | 0.0673 ns | 0.0151 ns |         - |
| CheckByLenghtWithNullCheckOperator | 0.3207 ns | 0.0325 ns | 0.0288 ns | 0.3210 ns |         - |
|         CheckByLenghtWithNullCkeck | 0.0008 ns | 0.0034 ns | 0.0028 ns | 0.0000 ns |         - |