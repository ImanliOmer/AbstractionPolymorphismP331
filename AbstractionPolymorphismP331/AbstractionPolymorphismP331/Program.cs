using System.Collections.Generic;

namespace AbstractionPolymorphismP331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            Substraction substraction= new Substraction();
            Multiplication multiplication = new Multiplication();
            Division division = new Division();

            Console.WriteLine("addition");
            Console.WriteLine(addition.Operate(10, 5));
            Console.WriteLine("substraction");
            Console.WriteLine(substraction.Operate(10,5));
            Console.WriteLine("multiplication");
            Console.WriteLine(multiplication.Operate(10,5));
            Console.WriteLine("division");
            Console.WriteLine(division.Operate(10,5));
        }
    }
}