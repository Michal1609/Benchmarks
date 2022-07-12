using BenchmarkDotNet.Attributes;
using System;

namespace Benchmark.TestsLibrary.StringTests
{
    [MemoryDiagnoser]
    public class CheckStringContainsSubstringTests
    {
        private const string TestString = "Some short testing string.";
        private const string SearchedSubstring = "short";

        [Benchmark]
        public void Contains()
        {
            _ = TestString.Contains(SearchedSubstring);
        }

        [Benchmark]
        public void ContainsOrdinal()
        {
            _ = TestString.Contains(SearchedSubstring, StringComparison.Ordinal);
        }

        [Benchmark]
        public void ContainsInvariant()
        {
            _ = TestString.Contains(SearchedSubstring, StringComparison.InvariantCulture);
        }

        [Benchmark]
        public void ContainsOrdinalIgnoreCase()
        {
            _ = TestString.Contains(SearchedSubstring, StringComparison.OrdinalIgnoreCase);
        }

        [Benchmark]
        public void ContainsInvariantIgnoreCase()
        {
            _ = TestString.Contains(SearchedSubstring, StringComparison.InvariantCultureIgnoreCase);
        }

        [Benchmark]
        public void IndexOf()
        {
            _ = TestString.IndexOf(SearchedSubstring) >= 0;
        }

        [Benchmark]
        public void IndexOfOrdinal()
        {
            _ = TestString.IndexOf(SearchedSubstring) >= 0;
        }

        [Benchmark]
        public void IndexOfInvariant()
        {
            _ = TestString.IndexOf(SearchedSubstring) >= 0;
        }

        [Benchmark]
        public void IndexOfOrdinalIgnoreCase()
        {
            _ = TestString.IndexOf(SearchedSubstring, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        [Benchmark]
        public void IndexOfInvariantIgnoreCase()
        {
            _ = TestString.IndexOf(SearchedSubstring, StringComparison.InvariantCultureIgnoreCase) >= 0;
        }
    }
}
