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
                    GUI gui = new GUI();
                    gui.Vareliste();
                    break;
                }
                else if (cki.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Pressed 2");
                    Console.Clear();
                    break;
                }
                else if (cki.Key == ConsoleKey.D3)
                {

                }

            }
            while (true);
        }

        public static void VarePrint(IReadOnlyList<item> list)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Item Code");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("Name");
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("Count");
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("Sales Price");
            Console.SetCursorPosition(80, 2);
            Console.WriteLine("Buy Price");
            Console.SetCursorPosition(100, 2);
            Console.WriteLine("Stock");
            int i = 4;
            foreach (var item in list)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(item.ItemCode);
                Console.SetCursorPosition(20, i);
                Console.WriteLine(item.Name);
                Console.SetCursorPosition(40, i);
                Console.WriteLine(item.Count);
                Console.SetCursorPosition(60, i);
                Console.WriteLine(item.SalesPrice);
                Console.SetCursorPosition(80, i);
                Console.WriteLine(item.CostPrice);
                Console.SetCursorPosition(100, i);
                Console.WriteLine(item.StorageCapacity);
                i++;
            }
        }

        public void Vareliste()
        {
            ConsoleKeyInfo cki;
            Console.Clear();
            Console.WriteLine("Product list");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            VarePrint(Database.items.AsReadOnly());
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.WriteLine("1. Create Product: \n2. Edit Product: \n3. Search Product: \n4. Delete Product: ");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1)
            {
                OpretVare();
            }
            else if (cki.Key == ConsoleKey.D2)
            {
                Console.Clear();
            }
            else if (cki.Key == ConsoleKey.D3)
            {
                
            }
            Vareliste();
        }
        public void OpretVare()
        {
            Console.Clear();
            Console.WriteLine("Create product");
            item item = new item();
            item.ItemCode = GetInt("Item Code");
            item.Name = GetString("Name");
            item.Count = GetInt("Count");
            item.SalesPrice = GetDouble("Sales Price");
            item.CostPrice = GetDouble("Cost Price");
            item.StorageCapacity = GetInt("Storage Capacity");
            Database.items.Add(item);
            
        }
        public string GetString(string instruction)
        {
            Console.Write($"{instruction}:");
            return Console.ReadLine();
        }
        public int GetInt(string instruction)
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
        public double GetDouble(string instruction)
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
