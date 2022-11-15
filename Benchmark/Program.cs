using Benchmark;
using BenchmarkDotNet.Running;



//var dateTime = "11/14/2022 4:28:32 PM";
//var parser = new DateParser();

//Console.WriteLine(parser.GetMonthFromDateTime(dateTime));
//Console.WriteLine(parser.GetMonthFromSplit(dateTime));
//Console.WriteLine(parser.GetMonthFromSubstring(dateTime));
//Console.WriteLine(parser.GetMonthFromSpan(dateTime));
//Console.WriteLine(parser.GetMonthFromSpanManualConversion(dateTime));

BenchmarkRunner.Run<DateParserBenchmark>();