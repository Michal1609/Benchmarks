using BenchmarkDotNet.Attributes;

namespace Benchmark.TestsLibrary.ComparsionOfAny
{
    [MemoryDiagnoser]
    public class AnyVsContainsTests
    {
        private readonly int[] _array;
        private readonly List<int> _list;
        private const int ItemsCount = 1000;
        private const int SearchedValue = 999;

        public AnyVsContainsTests()
        {
            _array = new int[ItemsCount];
            _list = new List<int>(ItemsCount);
            for (int i = 0; i < ItemsCount; i++)
            {
                _array[i] = i;
                _list.Add(i);
            }
        }

        [Benchmark]
        public bool ListAnyConcreteItem()
        {
            return _list.Any(x => x == SearchedValue);
        }

        [Benchmark]
        public bool ListContainsConcreteItem()
        {
            return _list.Contains(SearchedValue);
        }

        [Benchmark]
        public bool ArrayAnyConcreteItem()
        {
            return _array.Any(x => x == SearchedValue);
        }

        [Benchmark]
        public bool ArrayContainsConcreteItem()
        {
            return _array.Contains(SearchedValue);
        }
    }
}
