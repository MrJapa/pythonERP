using System;
using System.Collections.Generic;
using System.Text;

namespace python
{
    class Product
    {
        public static void VarePrint()
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

        }
        public static void Vareliste()
        {
            ConsoleKeyInfo cki;
            Console.Clear();
            Console.WriteLine("Product list");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            VarePrint();
            SQL.ReadStockData();
            Console.WriteLine();
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
                Console.Clear();
                SQL.ReadStockData();
            }
            else if (cki.Key == ConsoleKey.D4)
            {
                Console.Clear();
                SQL.DeleteProduct();
            }
            Vareliste();
        }
        public static void OpretVare()
        {
            Console.Clear();
            Console.WriteLine("Create product");
            item item = new item();
            item.ItemCode = GUI.GetInt("Item Code");
            item.ItemName = GUI.GetString("Item Name");
            item.Count = GUI.GetInt("Item Count");
            item.SalesPrice = GUI.GetInt("Item Sales Price");
            item.CostPrice = GUI.GetInt("Item Buy Price");
            item.StorageCapacity = GUI.GetInt("Storage Capacity");
            Database.items.Add(item);
            SQL.CreateProduct(item);
        }

    }
}
