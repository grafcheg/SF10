﻿namespace SF10;

class Program
{
    static void Main(string[] args)
    {
        SimpleCalculator simpleCalculator = new();

        while (true)
        {
            Console.WriteLine("Введите первое слогаемое: ");
            var firstInput = Console.ReadLine();

            if (!long.TryParse(firstInput, out long firstNumber))
            {
                 continue;   
            }
            
            Console.WriteLine("Введите второе слогаемое: ");
            var secondInput = Console.ReadLine();
            
            if (!long.TryParse(secondInput, out long secondNumber))
            {
                continue;   
            }

            try
            {
                Console.WriteLine($"Сумма сложения чисел равна: {simpleCalculator.Add(firstNumber, secondNumber)}");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;
        }
    }
}