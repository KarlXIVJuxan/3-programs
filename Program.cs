namespace _3_программы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                int position = 1;
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("->");

                ConsoleKeyInfo clavisha = Console.ReadKey();
                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                        position--; //position = positiom -1
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }
                    Console.Clear();
                    Console.WriteLine("Выберите действие");
                    Console.WriteLine(" 1. игра числа");
                    Console.WriteLine(" 2. таблица умножения");
                    Console.WriteLine(" 3. вывод делителей числа");
                    Console.WriteLine(" 4. выход");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    clavisha = Console.ReadKey();
                }
                if (position == 4)
                {
                    return;
                }
                if (position == 1)
                {
                    Console.WriteLine("Начало");
                    int Count = 0;
                    Random rn = new Random();
                    int a = rn.Next(0, 100);
                    int b = 0;
                    while (a != b)
                    {
                        Console.Write("Введите число от 1 до 100: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Count++;

                        if (a == b)
                        {
                            Console.WriteLine("Вы угадали");
                            Console.Beep();
                        }
                        else if (a > b)
                            Console.WriteLine("Введённое число больше");
                        else if (a < b)
                            Console.WriteLine("Введённое число меньше");
                    }

                }
                if (position == 2)
                {
                    var table = new int[10, 10];
                    for (int i = 0; i < 10; ++i)
                    {
                        for (int j = 0; j < 10; ++j)
                        {
                            table[i, j] = i * j;
                        }
                    }
                    for (int i = 0; i < 10; ++i)
                    {
                        for (int j = 0; j < 10; ++j)
                        {
                            Console.Write("{0, 3}", table[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
                if (position == 3)
                {
                    Console.Write("Введите число ");
                    int i = int.Parse(Console.ReadLine());
                    for (int a = 1; a <= i; a++)
                    {
                        if (i % a == 0)
                            Console.Write("{0} ", a);
                    }
                }

            }
        }
    }
}