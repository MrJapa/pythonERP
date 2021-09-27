using System;
using System.Collections.Generic;
using System.Text;

namespace python
{
    class Product
    {
        public static void ProductItems()
        {
            item item = new item();
            item.ItemCode = 1;
            item.ItemName = "Headphones";
            item.Count = 1000;
            item.SalesPrice = 1499;
            item.CostPrice = 350;
            item.StorageCapacity = 1000;
            Database.items.Add(item);
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
                Console.WriteLine(item.ItemName);
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
        public static void Vareliste()
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
        public static void OpretVare()
        {
            Console.Clear();
            Console.WriteLine("Create product");
            item item = new item();
            item.ItemCode = GUI.GetInt("Item Code ");
            item.ItemName = GUI.GetString("Name");
            item.Count = GUI.GetInt("Count ");
            item.SalesPrice = GUI.GetDouble("Sales Price ");
            item.CostPrice = GUI.GetDouble("Cost Price ");
            item.StorageCapacity = GUI.GetInt("Storage Capacity ");
            Database.items.Add(item);

        }
    }
}
