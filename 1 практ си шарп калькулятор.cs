using System;

class Calculator
{
    static void Main()
    {
        bool exitProgram = false;

        while (!exitProgram)
        {
            int choice;
            double num1, num2, result;

            do
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Возведение в степень");
                Console.WriteLine("6. Квадратный корень");
                Console.WriteLine("7. 1 процент от числа");
                Console.WriteLine("8. Факториал");
                Console.WriteLine("9. Выйти из программы");

                Console.Write("Введите номер операции: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 + num2;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case 2:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case 3:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case 4:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Результат: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль!");
                        }
                        break;
                    case 5:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        int power = int.Parse(Console.ReadLine());
                        result = Math.Pow(num1, power);
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case 6:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        if (num1 >= 0)
                        {
                            result = Math.Sqrt(num1);
                            Console.WriteLine($"Результат: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: невозможно извлечь квадратный корень из отрицательного числа!");
                        }
                        break;
                    case 7:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        result = num1 * 0.01;
                        Console.WriteLine($"1 процент от числа: {result}");
                        break;
                    case 8:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());
                        result = Factorial((int)num1);
                        Console.WriteLine($"Факториал числа: {result}");
                        break;
                    case 9:
                        Console.WriteLine("Программа завершена.");
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

            } while (choice != 9);
        }
    }

    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}
