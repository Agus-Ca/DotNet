using System.Globalization;

namespace Benchmark;

public class DateParser
{
    // Example date: "11/14/2022 4:28:32 PM"

    public int GetMonthFromDateTime(string dateTimeAsString)
    {
        var dateTime = DateTime.Parse(dateTimeAsString);
        return dateTime.Month;
    }

    public int GetMonthFromSplit(string dateTimeAsString)
    {
        var split = dateTimeAsString.Split('/');
        return int.Parse(split[0]);
    }

    public int GetMonthFromSubstring(string dateTimeAsString)
    {
        var indexOfSlash = dateTimeAsString.IndexOf("/");
        return int.Parse(dateTimeAsString.Substring(0, indexOfSlash));
    }

    public int GetMonthFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
    {
        var indexOfSlash = dateTimeAsSpan.IndexOf("/");
        return int.Parse(dateTimeAsSpan.Slice(0, indexOfSlash));
    }

    public int GetMonthFromSpanManualConversion(ReadOnlySpan<char> dateTimeAsSpan)
    {
        var indexOfSlash = dateTimeAsSpan.IndexOf("/");
        var monthAsSpan = dateTimeAsSpan.Slice(0, indexOfSlash);

        var temp = 0;
        for (int i = 0; i < monthAsSpan.Length; i++)
        {
            temp = temp * 10 + (monthAsSpan[i] - '0');
        }

        return temp;
    }
}