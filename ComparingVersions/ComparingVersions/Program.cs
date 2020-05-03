using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingVersions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter version 1: ");
            string version1 = Console.ReadLine();
            char[] v1 = version1.ToCharArray();
            while(v1[0] == '.' || v1[v1.Length-1] == '.')
            {
              Console.Write("Enter version 1 again, cannot start or end in a .: ");
              version1 = Console.ReadLine();
              v1 = version1.ToCharArray();
            }
            Console.Write("Enter version 2: ");
            string version2 = Console.ReadLine();
            char[] v2 = version2.ToCharArray();
            while(v2[0] == '.' || v2[v2.Length-1] == '.')
            {
              Console.Write("Enter version 2 again, cannot start or end in a .: ");
              version2 = Console.ReadLine();
              v2 = version2.ToCharArray();
            }
            Console.WriteLine(ComparingVersions(version1, version2));
        }

        public static int ComparingVersions(string version1, string version2)
        {
          string[] ver1 = version1.Split(".");
          string[] ver2 = version2.Split(".");

          if(ver1.Length != ver2.Length)
          {
            return 0;
          }

          IEnumerable<int> range = Enumerable.Range(0, ver1.Length);

          foreach (int i in range)
          {
            if(Int32.Parse(ver1[i]) > Int32.Parse(ver2[i]))
            {
              return 1;
            }
            else if(Int32.Parse(ver1[i]) < Int32.Parse(ver2[i]))
            {
              return -1;
            } 
          }
          return 0;
        }
    }
}
