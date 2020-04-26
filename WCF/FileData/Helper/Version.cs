using System;
using ThirdPartyTools;

namespace FileData.Helper
{
    internal sealed class Version : IProperty
    {
        private readonly FileDetails _fileDetails;
       
        public Version()
        {
            _fileDetails = new FileDetails();
        }

        public T Get<T>(string path)
        {
            return (T)Convert.ChangeType(_fileDetails.Version(path), typeof(T));
        }
    }
}