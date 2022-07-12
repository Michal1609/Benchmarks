using BenchmarkDotNet.Attributes;

namespace Benchmark.TestsLibrary.CollectionsTests
{
    [MemoryDiagnoser]
    public class ListWithInitialCapacityTests
    {
        [Params(10, 1_000)]
        public int Size { get; set; }

        [Benchmark]
        public void AddWithoutInitializationOfCapacity()
        {
            var list = new List<string>();

            for(int i = 0; i < Size; i++)
            {
                list.Add($"Row number");
            }
        }

        [Benchmark]
        public void AddWithInitializationOfCapacity()
        {
            var list = new List<string>(Size);

            for (int i = 0; i < Size; i++)
            {
                list.Add($"Row number");
            }
        }
    }
}
