using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string: ");
            string str = Console.ReadLine();
            Console.WriteLine(BalancedBrackets(str));
        }

        public static int BalancedBrackets(string str)
        {
          int rightBrackets = 0, leftBrackets = 0, balancedBrackets = 0;

          for (int i = 0; i < str.Length ; i++)
          {
              if(str[i] == '(')
              {
                leftBrackets++;
                balancedBrackets++;
              }
              else
              {
                if(leftBrackets > 0)
                {
                  leftBrackets--;
                  balancedBrackets--;
                }
                else
                {
                  rightBrackets++;
                }
              }
          }
          return balancedBrackets + rightBrackets;
        }
    }
}
