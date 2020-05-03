using System;
using System.Text.RegularExpressions;

namespace SortGiftCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your code: ");
            string code = Console.ReadLine();
            while(!Regex.IsMatch(code, @"^[a-zA-Z]+$") && code.Length > 26)
            {
              Console.Write("Enter your code again, it must contain only letters and have less than 26 characters: ");
              code = Console.ReadLine();
            }
            Console.WriteLine(SortGiftCode(code));
        }

        public static string SortGiftCode(string code)
        {
          char[] charArr = code.ToLower().ToCharArray();
          Array.Sort(charArr);
          return new string(charArr);
        } 
    }
}
