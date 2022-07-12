using BenchmarkDotNet.Attributes;

namespace Benchmark.TestsLibrary.StringTests
{
    [MemoryDiagnoser]
    public class StartWithTests
    {
        private const string TextTemplate = "Test string";
        private const string SearchedText = "T";
        private const char SearchedCharacter = 'T';

        [Benchmark]
        public bool StartsWithString()
        {
            return TextTemplate.StartsWith(SearchedText);
        }

        [Benchmark]
        public bool StarstWithStringOrdinal()
        {
            return TextTemplate.StartsWith(SearchedText, StringComparison.Ordinal);
        }

        [Benchmark]
        public bool StarstWithStringInvariant()
        {
            return TextTemplate.StartsWith(SearchedText, StringComparison.InvariantCulture);
        }

        [Benchmark]
        public bool StartsWithCharacter()
        {
            return TextTemplate.StartsWith(SearchedCharacter);
        }
    }
}
