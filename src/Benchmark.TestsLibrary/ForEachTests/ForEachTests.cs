using BenchmarkDotNet.Attributes;
using System.Runtime.InteropServices;

namespace Benchmark.TestsLibrary.ForEachTests
{
    [MemoryDiagnoser]
    public class ForEachTests
    {
        private List<int> _list = default!;

        [Params(10, 100, 1_000, 10_000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            _list = new List<int>(Size);
            for (var i = 0; i < Size; i++)
            {
                _list.Add(i);
            }
        }

        [Benchmark(Baseline = true)]
        public void Foreach()
        {
            foreach (var item in _list)
            {
            }
        }

        [Benchmark]
        public void List_Foreach()
        {
            _list.ForEach(_ => { });
        }

        [Benchmark]
        public void For()
        {
            for (var i = 0; i < _list.Count; i++)
            {
                _ = _list[i];
            }
        }

        [Benchmark]
        public void Foreach_Span()
        {
            foreach (var item in CollectionsMarshal.AsSpan(_list))
            {
            }
        }
    }
}
