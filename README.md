[![.NET](https://github.com/aimenux/IsNumericBenchDemo/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/aimenux/IsNumericBenchDemo/actions/workflows/ci.yml)

# IsNumericBenchDemo
```
Benchmarking ways of checking if some small or large string is numeric
```

In this demo, i m using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library in order to benchmark various ways of checking if some small or large string is numeric.
>
> :one: `SmallNumericBench` : a bench for small numbers (size less than or equal to 19 characters)
>
> :two: `LargeNumericBench` : a bench for large numbers (size greater than or equal to 20 characters)
>

```
|             Method | Size |      Mean |     Error |    StdDev |    Median |       Min |         Max | Rank |  Gen 0 | Allocated |
|------------------- |----- |----------:|----------:|----------:|----------:|----------:|------------:|-----:|-------:|----------:|
| UsingCompiledRegex |   30 |  72.63 ns |  1.469 ns |  3.255 ns |  71.82 ns |  68.24 ns |    79.17 ns |    1 |      - |         - |
|   UsingInlineRegex |   30 | 201.52 ns |  4.018 ns |  9.550 ns | 199.17 ns | 188.32 ns |   227.30 ns |    2 |      - |         - |
|          UsingLinq |   30 | 218.27 ns |  4.226 ns |  9.007 ns | 218.11 ns | 205.91 ns |   244.27 ns |    3 | 0.0229 |      96 B |
|    UsingBigInteger |   30 | 404.30 ns | 26.651 ns | 78.162 ns | 381.75 ns | 308.10 ns |   587.99 ns |    4 | 0.0591 |     248 B |
|                    |      |           |           |           |           |           |             |      |        |           |
| UsingCompiledRegex |   50 | 123.61 ns |  3.223 ns |  9.248 ns | 121.02 ns | 111.83 ns |   148.08 ns |    1 |      - |         - |
|   UsingInlineRegex |   50 | 341.35 ns |  9.703 ns | 27.525 ns | 338.48 ns | 294.16 ns |   417.68 ns |    2 |      - |         - |
|          UsingLinq |   50 | 420.34 ns |  9.626 ns | 28.231 ns | 413.98 ns | 383.72 ns |   488.03 ns |    3 | 0.0229 |      96 B |
|    UsingBigInteger |   50 | 584.54 ns | 25.072 ns | 71.936 ns | 568.99 ns | 473.93 ns |   756.06 ns |    4 | 0.0935 |     392 B |
|                    |      |           |           |           |           |           |             |      |        |           |
| UsingCompiledRegex |  100 | 171.69 ns |  3.448 ns |  8.776 ns | 172.94 ns | 157.41 ns |   192.96 ns |    1 |      - |         - |
|   UsingInlineRegex |  100 | 484.29 ns |  9.684 ns | 17.214 ns | 486.04 ns | 447.21 ns |   513.31 ns |    2 |      - |         - |
|          UsingLinq |  100 | 751.83 ns | 33.319 ns | 96.132 ns | 723.61 ns | 625.77 ns | 1,030.50 ns |    3 | 0.0229 |      96 B |
|    UsingBigInteger |  100 | 982.55 ns | 24.110 ns | 66.808 ns | 979.44 ns | 881.09 ns | 1,173.20 ns |    4 | 0.1469 |     616 B |
```

>
**`Tools`** : vs22, net 6.0, xunit, fluent-assertions benchmark-dotnet