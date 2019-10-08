using System;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new string('_', 70);
            Console.WriteLine("Название №1");
            string kin = Console.ReadLine();
            Console.WriteLine("Режиссёр №1");
            string reg = Console.ReadLine();
            Console.WriteLine("Год №1");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Тип №1");
            string type = Console.ReadLine();
            Console.WriteLine("Название №2");
            string kin2 = Console.ReadLine();
            Console.WriteLine("Режиссёр №2");
            string reg2 = Console.ReadLine();
            Console.WriteLine("Год №2");
            int year2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Тип №2");
            string type2 = Console.ReadLine();
            Console.WriteLine("Название №3");
            string kin3 = Console.ReadLine();
            Console.WriteLine("Режиссёр №3");
            string reg3 = Console.ReadLine();
            Console.WriteLine("Год №3");
            int year3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Тип №3");
            string type3 = Console.ReadLine();
            Console.WriteLine(a + "\n" + "Кинопродукция\n" + a + "\n" + "Фильм" + " | " + "Режиссёр" + " | " + " Год " + " | " + "Тип" + "|\n" + a + "\n");
            Console.WriteLine(kin + " | " + reg + " | " + year + " | " + type + "|\n" + a);
            Console.WriteLine(kin2 + " | " + reg2 + " | " + year2 + " | " + type2 + "|\n" + a);
            Console.WriteLine(kin3 + " | " + reg3 + " | " + year3 + " | " + type3 + "|\n" + a);
            Console.WriteLine(a + "\n" + "Перечисляемый тип: Д-драма, К-комедия, М-мелодрама, Б-боевик, А-Мульт\n" + a + "\n");
        }
    }
}
