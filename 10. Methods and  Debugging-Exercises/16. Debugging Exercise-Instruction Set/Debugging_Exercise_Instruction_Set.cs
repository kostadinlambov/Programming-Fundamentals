using System;

public class Debugging_Exercise_Instruction_Set
{
    public static void Main()
    {
        {
            string opCode = Console.ReadLine().ToLower();

            while (opCode != "end")
            {
                string[] codeArgs = opCode.Split(' ');

                decimal result = 0;
                switch (codeArgs[0])
                {
                    case "inc":
                    {
                        decimal operandOne = decimal.Parse(codeArgs[1]);
                        result = ++operandOne;
                        break;
                    }
                    case "dec":
                    {
                        decimal operandOne = decimal.Parse(codeArgs[1]);
                        result = --operandOne;
                        break;
                    }
                    case "add":
                    {
                        decimal operandOne = decimal.Parse(codeArgs[1]);
                        decimal operandTwo = decimal.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                    case "mla":
                    {
                        decimal operandOne = decimal.Parse(codeArgs[1]);
                        decimal operandTwo = decimal.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
                }

                Console.WriteLine(result);
                opCode = Console.ReadLine().ToLower();                
            }          
        }
    }
}

