using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please select operation to perform");
            Console.WriteLine("Enter 1 for Printing values from Text file");
            Console.WriteLine("Enter 2 for Sum of multiple numbers");
            int.TryParse(Console.ReadLine(), out int input);
            if (input == 1)
            {
                ReadTextFile();
            }
            else if (input == 2)
            {
                Sum();
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }

        private static void ReadTextFile()
        {
            // learnt something new - set copy to output directory for a file to copy always, otherwise FileNotFound error
            string text = System.IO.File.ReadAllText("Sample.txt");

            Console.WriteLine(text);
            Console.ReadLine();
        }

        private static void Sum()
        {
            int sum = 0;
            bool multiple = true;
            while (multiple)
            {
                Console.WriteLine("Please enter a number: ");
                var num = int.TryParse(Console.ReadLine(), out int input);
                if (num)
                {
                    sum += input;
                }
                Console.WriteLine("To add another number enter 'Y', for result enter 'N'");
                var yesno = Console.ReadLine();
                if (yesno.ToUpper().Trim() == "N")
                {
                    multiple = false;
                }
            }


            Console.WriteLine("Sum : " + sum.ToString());
            Console.ReadLine();
        }
    }
}
