using BenchmarkDotNet.Attributes;

namespace Benchmark.TestsLibrary.ComparsionOfAny
{
    [MemoryDiagnoser]
    public class CollectionContainsAnyItemTests
    {
        private readonly List<int> _testList = new List<int> { 1, 2, 3};

        [Benchmark]
        public bool ListAny()
        {
            return _testList.Any();
        }

        [Benchmark]
        public bool CheckByLenght()
        {
            return _testList.Count > 0;
        }

        [Benchmark]
        public bool CheckByLenghtWithNullCheckOperator()
        {
            return _testList?.Count > 0;
        }

        [Benchmark]
        public bool CheckByLenghtWithNullCkeck()
        {
            return _testList != null && _testList.Count > 0;
        }

    }
}
