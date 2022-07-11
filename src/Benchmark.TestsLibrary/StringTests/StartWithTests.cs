using BenchmarkDotNet.Attributes;

namespace Benchmark.TestsLibrary.StringTests
{
    [MemoryDiagnoser]
    public class StartWithTests
    {
        private const string TextTemplate = "Test string";
        private const string SearchedValue = "T";

        [Benchmark]
        public bool StartsWith()
        {
            return TextTemplate.StartsWith(SearchedValue);
        }

        [Benchmark]
        public bool StarstWithOrdinal()
        {
            return TextTemplate.StartsWith(SearchedValue, StringComparison.Ordinal);
        }
    }
}
