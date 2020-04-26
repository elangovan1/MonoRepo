using FileData.Helper;

namespace FileData.Client
{
    public class FileClient
    {
        private readonly IProperty _property;
        private readonly IEnsure _ensure;

        public FileClient(IProperty property, IEnsure ensure)
        {
            _property = property;
            _ensure = ensure;
        }
         
        public T Get<T>(string type, string path)
        {
            if(_ensure.IsValidType(type))
                return _property.Get<T>(path);

            return default(T);
        }
    }
}