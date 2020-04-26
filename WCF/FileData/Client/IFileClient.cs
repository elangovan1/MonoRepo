using FileData.Helper;

namespace FileData.Client
{
    public interface IFileClient
    {
        T Get<T>(PropertyType type, string path);
    }
}