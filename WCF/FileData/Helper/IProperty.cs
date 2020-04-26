namespace FileData.Helper
{
    public interface IProperty
    {
        T Get<T>(string path);
    }
}