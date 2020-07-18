using BenchmarkDotNet.Running;
namespace DotNetJsonSerializationBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
            var benchmark = new SingleObjectBenchMark();

            var dummy = benchmark.UsingAnymousSerialization();
            var dummy2 = benchmark.UsingStringBuild();

            var same = dummy == dummy2;
            #else
            BenchmarkRunner.Run(typeof(Program).Assembly);
            #endif
        }
    }
}
