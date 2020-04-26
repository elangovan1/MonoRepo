using System;
using System.Collections.Generic;
using System.Linq;

namespace FileData.Helper
{
    internal sealed class Ensure : IEnsure
    {
        private static readonly List<KeyValuePair<PropertyType, string>> etypes;

        static Ensure()
        {
            etypes = new List<KeyValuePair<PropertyType, string>>
            {
                new KeyValuePair<PropertyType, string>(PropertyType.Size, "-s"),
                new KeyValuePair<PropertyType, string>(PropertyType.Size, "--s"),
                new KeyValuePair<PropertyType, string>(PropertyType.Size, "/s"),
                new KeyValuePair<PropertyType, string>(PropertyType.Size, "--Size"),
                new KeyValuePair<PropertyType, string>(PropertyType.Version, "-v"),
                new KeyValuePair<PropertyType, string>(PropertyType.Version, "--v"),
                new KeyValuePair<PropertyType, string>(PropertyType.Version, "/v"),
                new KeyValuePair<PropertyType, string>(PropertyType.Version, "--Version")
            };
        }
        
        public bool IsValidType(string type)
        {
            if(!etypes.Any(types => types.Value == type))
                throw new ArgumentException($"Invalid input {type}");

            return true;
        }
        
        public PropertyType GetType(string type)
        {
            return etypes.Single(types => types.Value == type).Key;
        }
    }
}