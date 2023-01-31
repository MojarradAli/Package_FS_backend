namespace System;

public static class DateTimeExtensions
{
    public static long ToUnixTimeMiliSeconds(this DateTime dateTime)
    {
        return (long)dateTime.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
    }
}
