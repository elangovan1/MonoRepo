namespace FileData.Helper
{
    public interface IEnsure
    {
        bool IsValidType(string type);
        PropertyType GetType(string type);
    }
}
