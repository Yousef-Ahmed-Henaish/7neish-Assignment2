using System;

namespace Calculaor
{ 
    class Program
    {
        static void Main(string[] args)
        {
            double first_Number;
            double second_Number;
            char operation;
            double result;

            Console.WriteLine("This is Calculator");

            Console.WriteLine ("Enter First Number");
            if (!double.TryParse(Console.ReadLine(), out first_Number))
                throw new InvalidOperationException();

            Console.WriteLine("Enter Second Number");
            if (!double.TryParse(Console.ReadLine(), out second_Number))
                throw new InvalidOperationException();

            Console.WriteLine("Enter The Operation ( -, +, *, / )");
            operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
   

            switch (operation)
            {
                case '+':
                    result = first_Number + second_Number;
                    break;

                case '-':
                    result = first_Number - second_Number;
                    break;

                case '*':
                    result = first_Number * second_Number;
                    break;
                     
                case '/':
                    if (second_Number == 0)
                        throw new DivideByZeroException();

                    result = first_Number / second_Number;
                    break;

                default: throw new InvalidOperationException();
            }

            Console.WriteLine($"{first_Number} {operation} {second_Number} = {result}");
        }
    }
}

