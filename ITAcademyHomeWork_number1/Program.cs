using System;

namespace ITAcademyHomeWork_number1
{
    class Program
    {
        static void Main(string[] args)
        {
            double CostMilk = 1.25;
            double CostChocolate = 2.05;
            double CostTea = 4.15;
            double CostCoffee = 11.25;
            double CostIceCream = 2.35;
            double SumProducts = CostMilk + CostChocolate + CostTea + CostCoffee + CostIceCream;
            Console.WriteLine("Общая стоимость покупок: " + SumProducts + " бел. руб.");



            int a = 11;
            int b = 3 * a;
            int c = a + b;
            Console.WriteLine($"Значение переменной а - {a}. Значение переменной а - {b}. Значение переменной а - {c}.");



            string x;
            string y;
            string z;
            Console.WriteLine("Введите пожалуйста три целых числа.");
            Console.WriteLine("Введите значение первой переменной.");
            x = Console.ReadLine();
            Console.WriteLine("Введите значение второй переменной.");
            y = Console.ReadLine();
            Console.WriteLine("Введите значение второй переменной.");
            z = Console.ReadLine();
            double result1 = Convert.ToDouble(x) / Convert.ToDouble(y);
            double result2 = Convert.ToDouble(x) * Convert.ToDouble(y) * Convert.ToDouble(z);
            Console.WriteLine("Результат деления x/y = {0}. Результат проихведения x*y*z = {1}.", result1, result2);

            Console.ReadLine();
        }
    }
}
