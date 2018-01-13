using System;
using System.Linq;

namespace _01.Reverse_String
{
    public class Reverse_String
    {
        public static void Main()
        {
            var inputStríng = Console.ReadLine();

            var reversedString = new string(inputStríng.Reverse().ToArray());

            Console.WriteLine(reversedString);
        }
    }
}
