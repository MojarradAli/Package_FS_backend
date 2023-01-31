namespace Package_FS_API.Services.DTOs;

public class TimeRangeDto
{
    public long Min { get; set; }

    public long Max { get; set; }

    public static TimeRangeDto Create(long min, long max)
    {
        return new TimeRangeDto
        {
            Min = min,
            Max = max
        };
    }
}
