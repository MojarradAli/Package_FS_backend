namespace Package_FS_API.Services;

public interface IWriteDbService
{
    Task Write(string json);
}
