using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForUnitTest {
    internal class Program {
        static void Main() {
            Calculator calculator = new Calculator();
            int firstNumber;
            int secondNumber;
            int buf;

            Console.WriteLine("Добро пожаловать в калькулятор.");

            EnterNumsAnchor:
            do {
                Console.Write("Введите первое число: ");
            }  while (!int.TryParse(Console.ReadLine(), out firstNumber));
            
            do {
                Console.Write("Введите второе число: ");
            } while (!int.TryParse(Console.ReadLine(), out secondNumber));

            ChooseActionAnchor:
            // Вырвиглазно но пардон))
            Console.WriteLine("Выберете действие:");
            Console.WriteLine($"1 - Сложить ({firstNumber} + {secondNumber})");
            Console.WriteLine($"2 - Вычесть ({firstNumber} - {secondNumber})");
            Console.WriteLine($"3 - Умножить ({firstNumber} x {secondNumber})");
            Console.WriteLine($"4 - Делить ({firstNumber} / {secondNumber})");
            Console.WriteLine($"5 - Найти остаток от деления ({firstNumber} / {secondNumber})");
            Console.WriteLine($"6 - Поменять числа местами ({secondNumber} и {firstNumber})");
            Console.WriteLine($"7 - Ввести новые числа");
            switch (Console.ReadLine()) {
                case "1":
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    Console.WriteLine($"Результат вычислений = {calculator.Remainder(firstNumber, secondNumber)}");
                    break;

                case "6":
                    buf = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = buf;
                    goto ChooseActionAnchor;

                case "7":
                    goto EnterNumsAnchor;

                default:
                    goto ChooseActionAnchor;
            }
        }
    }
}
