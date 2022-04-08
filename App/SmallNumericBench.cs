using System.Numerics;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;
using static App.Extensions;

namespace App;

[Config(typeof(BenchConfig))]
[BenchmarkCategory(nameof(BenchCategory.Large))]
public class SmallNumericBench
{
    public string Number { get; set; }

    [Params(5, 10, 15, 19)]
    public int Size { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        Number = RandomString(Size);
    }

    [Benchmark]
    public bool UsingLinq()
    {
        return Number.All(char.IsDigit);
    }

    [Benchmark]
    public bool UsingTryParse()
    {
        return long.TryParse(Number, out var _);
    }

    [Benchmark]
    public bool UsingInlineRegex()
    {
        return Regex.IsMatch(Number, @"^\d+$");
    }

    [Benchmark]
    public bool UsingCompiledRegex()
    {
        return NumberRegex.IsMatch(Number);
    }

    [Benchmark]
    public bool UsingBigInteger()
    {
        return BigInteger.TryParse(Number, out var _);
    }
}