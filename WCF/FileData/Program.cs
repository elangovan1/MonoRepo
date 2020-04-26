using System;
using System.Collections.Generic;
using FileData.Client;
using FileData.Helper;
using Version = FileData.Helper.Version;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var ensure = new Ensure();
            if (ensure.IsValidType(args[0]))
            {
                var findType = ensure.GetType(args[0]);
                var strategies = new Dictionary<PropertyType, IProperty>();
                strategies.Add(PropertyType.Size, new Size());
                strategies.Add(PropertyType.Version, new Version());

                Console.WriteLine(new FileClient(strategies[findType], ensure).Get<string>(args[0], args[1]));
            }

            /* if (ensure.IsValidType(args[0]))
             {
                 var findType = ensure.GetType(args[0]);
                 switch (findType)
                 {
                     case PropertyType.Size:
                         var Size = new Size();
                         Console.WriteLine("The Size is : " + new FileClient(Size, ensure).Get<string>(args[0], args[1]));
                         break;
                     case PropertyType.Version:
                         var Version = new Version();
                         Console.WriteLine("The Version is : " + new FileClient(Version, ensure).Get<string>(args[0], args[1]));
                         break;
                 }
             }*/
                Console.ReadKey();
        }
    }
}
