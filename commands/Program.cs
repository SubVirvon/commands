using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            bool isblocked = false;
            bool key = true;
            string password = null;
            int passwordAttempts = 3;

            while (isOpen == true)
            {
                if (isblocked == true)
                {
                    for (int i = 0; i < passwordAttempts; i++)
                    {
                        Console.Write("Введите пароль: ");

                        if (password == Console.ReadLine())
                        {
                            Console.Clear();
                            key = true;
                            break;
                        }
                        else
                        {
                            key = false;
                        }
                    }
                }
                if(key == true)
                {
                    const string CommandCreatePassword = "1";
                    const string CommandGenerateNumber = "2";
                    const string CommandConsoleColor = "3";
                    const string CommandTextColor = "4";
                    const string CommandMathematicalOperation = "5";
                    const string CommandExit = "6";

                    Console.Write(CommandCreatePassword + ".Создать пароль\n" + CommandGenerateNumber + ".Сгенерировать случайное число\n" + CommandConsoleColor + ".Поменять цвет консоли\n" + CommandTextColor + ".Поменять цвет текста\n" + CommandMathematicalOperation + ".Сложить два числа\n" + CommandExit + ".Выйти\n\nВведите номер команды: ");
                    
                    switch (Console.ReadLine())
                    {
                        case CommandCreatePassword:
                            Console.Clear();
                            Console.Write("Придумайте пароль: ");
                            password = Console.ReadLine();
                            isblocked = true;
                            Console.ReadKey();
                            break;
                        case CommandGenerateNumber:
                            Console.Clear();
                            Console.Write("Введи нижнюю границу числа: ");
                            int minValue = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введи верхнюю границу числа: ");
                            int maxValue = Convert.ToInt32(Console.ReadLine());

                            Random random = new Random();
                            int randomNumber = random.Next(minValue, maxValue);

                            Console.WriteLine("Ваше случайное число: " + randomNumber);
                            Console.ReadKey();
                            break;
                        case CommandConsoleColor:
                            const string CommandConsoleRed = "1";
                            const string CommandConsoleGreen = "2";
                            const string CommandConsoleBlue = "3";
                            const string CommandConsoleWhite = "4";
                            const string CommandConsoleBlack = "5";

                            Console.Clear();
                            Console.Write("Выберите цвет консоли\n" + CommandConsoleRed + ".Красный\n" + CommandConsoleGreen + ".Зеленый\n" + CommandConsoleBlue + ".Синий\n" + CommandConsoleWhite + ".Белый\n" + CommandConsoleBlack + ".Черный\n\nВВедите номер команды: ");

                            switch (Console.ReadLine())
                            {
                                case CommandConsoleRed:
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    break;
                                case CommandConsoleGreen:
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    break;
                                case CommandConsoleBlue:
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    break;
                                case CommandConsoleWhite:
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case CommandConsoleBlack:
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                default:
                                    Console.WriteLine("Такой команды нет");
                                    Console.ReadKey();
                                    break;
                            }
                            break;
                        case CommandTextColor:
                            const string CommandTextRed = "1";
                            const string CommandTextGreen = "2";
                            const string CommandTextBlue = "3";
                            const string CommandTextWhite = "4";
                            const string CommandTextBlack = "5";

                            Console.Clear();
                            Console.Write("Выберите цвет текста\n" + CommandConsoleRed + ".Красный\n" + CommandConsoleGreen + ".Зеленый\n" + CommandConsoleBlue + ".Синий\n" + CommandConsoleWhite + ".Белый\n" + CommandConsoleBlack + ".Черный\n\nВВедите номер команды: ");

                            switch (Console.ReadLine())
                            {
                                case CommandTextRed:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                case CommandTextGreen:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                                case CommandTextBlue:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                case CommandTextWhite:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case CommandTextBlack:
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    break;
                                default:
                                    Console.WriteLine("Такой команды нет");
                                    Console.ReadKey();
                                    break;
                            }
                            break;
                        case CommandMathematicalOperation:
                            int firstNumber;
                            int secondNumber;
                            int result;

                            Console.Write("Введите первое число: ");
                            firstNumber = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            secondNumber = Convert.ToInt32(Console.ReadLine());

                            result = firstNumber + secondNumber;

                            Console.WriteLine("Результат сложения: " + result);
                            Console.ReadKey();
                            break;
                        case CommandExit:
                            isOpen = false;
                            break;
                        default:
                            Console.WriteLine("Такой команды нет");
                            Console.ReadKey();
                                break;
                    }
                }
                else
                {
                    isOpen = false;
                }

                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Программа завершена.");
            Console.ReadKey();
        }
    }
}
