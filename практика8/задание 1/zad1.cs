using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,5} {1,8} {2,15}");
            for (ushort i = 0; i < 255; i++)
            {
                char a = (char)i;
                Console.Write("\n{0,5} {1,8}", i, a);
                if (char.IsLetter(a)) Console.Write("{0,20}", "Буква");
                if (char.IsUpper(a)) Console.Write("{0,20}", "Верхний регистр");
                if (char.IsLower(a)) Console.Write("{0,20}", "Нижний регистр");
                if (char.IsControl(a)) Console.Write("{0,20}", "Управляющий символ");
                if (char.IsNumber(a)) Console.Write("{0,20}", "Число");
                if (char.IsPunctuation(a)) Console.Write("{0,20}", "Знак препинания");
                if (char.IsDigit(a)) Console.Write("{0,20}", "Цифра");
                if (char.IsSeparator(a)) Console.Write("{0,20}", "Разделитель");
                if (char.IsWhiteSpace(a)) Console.Write("{0,20}", "Пробельный символ");
            }
        }
    }
}
