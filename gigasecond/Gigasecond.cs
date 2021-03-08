using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        const int Gigasecond = 1_000_000_000;
        return moment.AddSeconds(Gigasecond);
    }
}