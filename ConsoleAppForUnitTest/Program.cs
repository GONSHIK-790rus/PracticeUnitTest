#region Библиотеки
using System;
#endregion

namespace ConsoleAppForUnitTest {
    internal class Program {
        static void Main() {
            #region Поля
            Calculator calculator = new Calculator();
            int firstNumber;
            int secondNumber;
            int buf;
            #endregion

            EnterNumsAnchor:
            Console.WriteLine("Добро пожаловать в калькулятор.");

            do {
                Console.Write("Введите первое число: ");
            }  while (!int.TryParse(Console.ReadLine(), out firstNumber));
            
            do {
                Console.Write("Введите второе число: ");
            } while (!int.TryParse(Console.ReadLine(), out secondNumber));

            ChooseActionAnchor:
            #region "Выберете действие"
            // Вырвиглазно но пардон))
            Console.WriteLine("Выберете действие:");
            Console.WriteLine($"1 - Сложить ({firstNumber} + {secondNumber})");
            Console.WriteLine($"2 - Вычесть ({firstNumber} - {secondNumber})");
            Console.WriteLine($"3 - Умножить ({firstNumber} x {secondNumber})");
            Console.WriteLine($"4 - Делить ({firstNumber} / {secondNumber})");
            Console.WriteLine($"5 - Найти остаток от деления ({firstNumber} / {secondNumber})");
            Console.WriteLine($"6 - Поменять числа местами ({secondNumber} и {firstNumber})");
            Console.WriteLine($"7 - Ввести новые числа");
            #endregion
            switch (Console.ReadKey().Key) {
                case ConsoleKey.D1:
                    Console.WriteLine();
                    Console.WriteLine($"Результат вычислений = {calculator.Sum(firstNumber, secondNumber)}");
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine();
                    Console.WriteLine($"Результат вычислений = {calculator.Subtract(firstNumber, secondNumber)}");
                    break;

                case ConsoleKey.D3:
                    Console.WriteLine();
                    Console.WriteLine($"Результат вычислений = {calculator.Multiply(firstNumber, secondNumber)}");
                    break;

                case ConsoleKey.D4:
                    Console.WriteLine();
                    Console.WriteLine($"Результат вычислений = {calculator.Divide(firstNumber, secondNumber)}");
                    break;

                case ConsoleKey.D5:
                    Console.WriteLine();
                    Console.WriteLine($"Результат вычислений = {calculator.Remainder(firstNumber, secondNumber)}");
                    break;

                case ConsoleKey.D6:
                    // Будем откровенны: я вообще не заморачивался :D
                    buf = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = buf;
                    Console.Clear();
                    Console.WriteLine("Добро пожаловать в калькулятор.");
                    goto ChooseActionAnchor;

                case ConsoleKey.D7:
                    Console.Clear();
                    goto EnterNumsAnchor;

                default:
                    goto ChooseActionAnchor;
            }

            Console.WriteLine("Нажмите клавишу \"Enter\", чтобы выйти");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
