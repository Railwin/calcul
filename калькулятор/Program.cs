        

int input = 1;
while (input != 9)

{
    Console.WriteLine("1.Сложите 2 числа");
    Console.WriteLine("2.Вычесть первое из второго");
    Console.WriteLine("3.Перемножить два числа");
    Console.WriteLine("4.Разделить первое на втроре");
    Console.WriteLine("5.Возвести в степень N певрое число");
    Console.WriteLine("6.Найти квадратный корень из числа");
    Console.WriteLine("7.Найти 1 процент от числа");
    Console.WriteLine("8.Найти факториал из числа");
    Console.WriteLine("9.Выйти из программы");

    input = Convert.ToInt32(Console.ReadLine());
    if (input == 1)
    {
        Console.WriteLine("Введите 2 числа");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 + number2);
        Console.WriteLine("Выберите следующую операцию: ");
    }


    if (input == 2)
    {
        Console.WriteLine("Введите 2 числа");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 - number2);
        Console.WriteLine("Выберите следующую операцию: ");

    }
    if (input == 3)
    {
        Console.WriteLine("Введите 2 числа");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 * number2);
        Console.WriteLine("Выберите следующую операцию: ");
    }

    if (input == 4)
    {
        Console.WriteLine("Введите 2 числа");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 / number2);
        Console.WriteLine("Выберите следующую операцию: ");
    }

    if (input == 5)
    {
        Console.WriteLine("Введите число");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень, в которую надо возвести");
        int N = Convert.ToInt32(Console.ReadLine());

        Math.Pow(number1, N);
        Console.WriteLine(Math.Pow(number1, N));
        Console.WriteLine("Выберите следующую операцию:");
    }

    if (input == 6) {

        Console.WriteLine("Введите число");
        int number3 = Convert.ToInt32(Console.ReadLine());
        Math.Sqrt(number3);
        Console.WriteLine(Math.Sqrt(number3));
        Console.WriteLine("Выберите следующую операцию:");
    }

    if (input == 7)
    {
        Console.WriteLine("Введите число");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 * 0.01);
        Console.WriteLine("Выберите следующую операцию:");
    }

    if (input == 8)
    {
        Console.WriteLine("Введите число");
        int number4 = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= number4; i++)
        {
            factorial = i * factorial;
        }
        Console.WriteLine(factorial);
        Console.WriteLine("Выберите следующую операцию:");
    }

    if (input > 9)
    {
        Console.WriteLine("Error");
    }
    
}