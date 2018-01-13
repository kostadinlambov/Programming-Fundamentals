namespace _5.Word_in_Plural
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var noun = Console.ReadLine();
            var nounInPlural = string.Empty;

            if (noun.EndsWith("y"))
            {
                nounInPlural = noun.Remove(noun.Length - 1, 1) + "ies";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch")
                     || noun.EndsWith("s") || noun.EndsWith("sh")
                     || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                nounInPlural = noun + "es";
            }
            else
            {
                nounInPlural = noun + "s";
            }

            Console.WriteLine(nounInPlural);
        }
    }
}
