using BenchmarkDotNet.Running;
namespace DotNetJsonSerializationBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
            var benchmark = new BenchMark();

            var dummy = benchmark.UsingEnum();
            var dummy2 = benchmark.UsingEnumAndStringBuilder();

            var same = dummy == dummy2;
            #else
            var summary = BenchmarkRunner.Run<BenchMark>();
            #endif
        }
    }
}
