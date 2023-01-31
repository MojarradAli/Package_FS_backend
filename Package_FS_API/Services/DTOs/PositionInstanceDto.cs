namespace Package_FS_API.Services.DTOs;

public class PositionInstanceDto
{
    public long TimeStamp { get; set; }

    public IEnumerable<PositionInstance> Instances { get; set; }
}

public class PositionInstance
{
    public int HumanId { get; set; }

    public double X { get; set; }
}
