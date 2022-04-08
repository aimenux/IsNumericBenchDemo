using App;
using BenchmarkDotNet.Running;

var benchmarks = new[]
{
    typeof(SmallNumericBench),
    typeof(LargeNumericBench)
};

var switcher = new BenchmarkSwitcher(benchmarks);
switcher.Run(args);