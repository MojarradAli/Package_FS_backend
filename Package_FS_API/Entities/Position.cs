namespace Package_FS_API.Entities;

public class Position
{
    public string Id { get; set; }

    public int HumanId { get; set; }

    public double X { get; set; }

    public double Y { get; set; }

    public long UnixTime { get; set; }

    public Human Human { get; set; }
}
