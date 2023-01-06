



class Switch
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
            Console.WriteLine("2.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
            Console.WriteLine("3.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");


            Console.Write("Выбери номер задания:");
            if (TryGetUserInput(out int value))
            {
                switch (value)
                {
                    case 1: Task64.Task64Main(); break;
                    case 2: Task66.Task66Main(); break;
                    case 3: Akkermaaaaaaaaaaaaan.AkkermaaaaaaaaaaaaanMain(); break;
                    default: Console.WriteLine("Извини, такой задачи нет :(. Попробуй еще раз!"); break;
                }
            }
        }

    }

    private static bool IsString(string input)
    {
        return !int.TryParse(input, out _);
    }

    private static bool TryGetUserInput(out int value)
    {
        string input = Console.ReadLine();
        if (IsString(input))
        {
            value = 0;
            Console.WriteLine("Введи число, а не букву!");
            return false;
        }

        else
        {
            value = int.Parse(input);
            return true;
        }
    }
}



class Task64
{
    public static void Task64Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        RecursivePrivet(number);
        Console.Read();
    }
    public static void RecursivePrivet(int value)
    {
        if (value != 0)
        {
            Console.WriteLine($"Value is {value}");
            RecursivePrivet(value - Math.Sign(value));
        }
        else
        {
            Console.WriteLine($"Final value is {value}");
        }
    }
}

class Task66
{

    public static void Task66Main()
    {
        Console.Write("Введи M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введи N: ");
        int N = int.Parse(Console.ReadLine());


        if (M > N)
        {
            int temp = N;
            N = M;
            M = temp;
        }
        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum is {sum}");
        Console.Read();
    }
}


class Akkermaaaaaaaaaaaaan
{
    public static void AkkermaaaaaaaaaaaaanMain()
    {
        Console.WriteLine("Input M number: ");
        int M = ReadInt();

        Console.WriteLine("Input N number: ");
        int N = ReadInt();
        AckermannFunction(M, N);
        Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}");
    }

    private static int AckermannFunction(int M, int N)
    {
        if (M == 0) return N + 1;
        if (M > 0 && N == 0) return AckermannFunction(M - 1, 1);
        if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
        return AckermannFunction(M, N);
    }

    private static int ReadInt()
    {
        return int.Parse(Console.ReadLine());
    }
}