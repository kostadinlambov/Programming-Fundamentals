using System;

namespace _08.Personal_Exception
{
    public class Personal_Exception
    {
        public static void Main()
        {
            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        throw new PersonalException();
                    }
                    Console.WriteLine(number);

                }
            }
            catch (PersonalException pe)
            {
                Console.WriteLine(pe.Message);
            }
        }
    }
}
