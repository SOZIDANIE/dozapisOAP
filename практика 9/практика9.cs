using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        { 
            //задание 1
            string a = "кол около колокола";
            Console.WriteLine("дана строка: {0}", a);
            char b = 'а';
            int k = 0;
            for(int x=0; x<a.Length; x++)
            {
                if(a[x]==b)
                {
                    k++;
                }
            }
            Console.WriteLine("символ {0} содержиться в ней {1} раз", b, k);

            //задание 2 (Вариант4)
            Console.WriteLine("Задание 2");
            string array = Console.ReadLine();
            Console.WriteLine("дана строка: {0}", a);
            char c = 'x';
            char d = 'y';
            int kk = 0;
            for (int x = 0; x < a.Length; x++)
            {
                if (array[x] == c||array[x]==d)
                {
                    kk++;
                }
            }
            Console.WriteLine("символ {0} и {1} содержатся в ней {2} раз", c,d, kk);
        }
    }
}
