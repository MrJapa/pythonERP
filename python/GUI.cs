using System;
using System.Collections.Generic;
using System.Text;

namespace python
{
    class GUI
    {
        public void Menu()
        {
            //int chooseFunction;
            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Lager: ");
                Console.WriteLine("2. Kunde: ");
                Console.WriteLine("3. Salgsordre: ");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1)
                {
                    Product.Vareliste();
                    break;
                }
                else if (cki.Key == ConsoleKey.D2)
                {
                    CustomerGUI.KundeList();
                    break;
                }
                else if (cki.Key == ConsoleKey.D3)
                {

                }

            }
            while (true);
        }

        public static string GetString(string instruction)
        {
            Console.Write($"{instruction}:");
            return Console.ReadLine();
        }
        public static int GetInt(string instruction)
        {
            Console.Write($"{instruction}:");
            int intNumber;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out intNumber))
                {
                    Console.WriteLine("Not a number");
                }
                else
                {
                    return intNumber;
                }
            }
            while (true);
        }
        public static double GetDouble(string instruction)
        {
            Console.Write($"{instruction}:");
            double doubleNumber;
            do
            {
                if (!double.TryParse(Console.ReadLine(), out doubleNumber))
                {
                    Console.WriteLine("Not a number");
                }
                else
                {
                    return doubleNumber;
                }
            }
            while (true);
        }
        
    }
}
