namespace Package_FS_API.Entities;

public class Human
{
    public int Id { get; set; }

    public ICollection<Position> Positions { get; set; }
}
