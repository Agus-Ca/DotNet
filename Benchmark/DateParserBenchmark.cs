using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using CommandLine;

namespace Benchmark;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateParserBenchmark
{
    private const string _Date = "11/14/2022 4:28:32 PM";
    private static readonly DateParser _DateParser = new();

    [Benchmark(Baseline = true)]
    public void GetMonthFromDateTime()
    {
        _DateParser.GetMonthFromDateTime(_Date);
    }

    [Benchmark]
    public void GetMonthFromSplit()
    {
        _DateParser.GetMonthFromSplit(_Date);
    }

    [Benchmark]
    public void GetMonthFromSubstring()
    {
        _DateParser.GetMonthFromSubstring(_Date);
    }

    [Benchmark]
    public void GetMonthFromSpan()
    {
        _DateParser.GetMonthFromSpan(_Date);
    }

    [Benchmark]
    public void GetMonthFromSpanManualConversion()
    {
        _DateParser.GetMonthFromSpanManualConversion(_Date);
    }
}