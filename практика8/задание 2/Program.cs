using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "ЗДРАВСТВУЙТЕ";
            string name = Console.ReadLine();

            hello = String.Concat(hello.ToLower(), ", ", name.ToUpper());
            Console.WriteLine(hello);

            Console.WriteLine($"Первое вхождение в строку буквы В: {hello.IndexOf('в')}");
            Console.WriteLine();

            int countB = 0;
            int countA = 0;
            for (int i = 0; i < hello.Length; i++)
            {
                if (hello[i] == 'в' || hello[i] == 'В') countB++;
                if (hello[i] == 'а' || hello[i] == 'А') countA++;
            }
            Console.WriteLine($"Строка содержит {countB} букв В \nСтрока содержит {countA} букв А");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
