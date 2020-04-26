using System;
using ThirdPartyTools;

namespace FileData.Helper
{
    internal sealed class Size : IProperty
    {
        private readonly FileDetails _fileDetails;
        
        public Size()
        {
            _fileDetails = new FileDetails();            
        }      

        public T Get<T>(string path)
        {
            return (T)Convert.ChangeType(_fileDetails.Size(path), typeof(T));
        }
    }
}