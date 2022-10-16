// Lab_04_3.cs
// Якубовський Владислав
// Лабораторна робота № 4.3
// Табуляція функції, заданої формулою: функція з параметрами.
// Варіант 24
using System;

namespace AP_Lab_04_3
{
    internal class Lab_04_3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть змінні \"xp\", \"xk\", \"dx\", \"a\", \"b\", \"c\" по черзі через крапку з комою: ");

            string[] varArray = Console.ReadLine().Split(';');

            double xp = Double.Parse(varArray[0].Replace('.', ',')),
                xk = Double.Parse(varArray[1].Replace('.', ',')), 
                dx = Double.Parse(varArray[2].Replace('.', ',')),
                a = Double.Parse(varArray[3].Replace('.', ',')),
                b = Double.Parse(varArray[4].Replace('.', ',')),
                c = Double.Parse(varArray[5].Replace('.', ',')),
                F;

            // Виведення "шапки" таблиці
            Console.WriteLine("+---------------+---------------+\n" +
                "|\tx\t|\tF\t|\n" +
                "+---------------+---------------+");

            // Розрахунок значень та виведення основної частини таблиці
            for (double x = xp; x <= xk; x += dx)
            {
                if (c < 0 && x != 0)
                    F = -a * x - c;

                else if (c > 0 && x == 0)
                    F = (x - a) / -c;

                else F = (b * x) / (c - a);

                Console.WriteLine($"|\t{String.Format("{0:0.##}", x)}\t|\t{String.Format("{0:0.##}", F)}\t|\n" +
                    $"+---------------+---------------+");
            }

            Console.ReadLine();
        }
    }
}