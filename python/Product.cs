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
            Console.WriteLine("Product ID");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("Name");
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("Buy Price");
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("Sales Price");
            Console.SetCursorPosition(80, 2);
            Console.WriteLine("Stock");
            Console.SetCursorPosition(100, 2);
            Console.WriteLine("Stock Capacity");

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
            Console.WriteLine("1. Create Product: \n2. Edit Product: \n3. Search Product: \n4. Delete Product: \n5. Order Product: \n6. Back:");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1)
            {
                OpretVare();
            }
            else if (cki.Key == ConsoleKey.D2)
            {
                Console.Clear();
                int getItemtoEdit = GUI.GetInt("Enter Product ID to edit");
                RedigerVare(getItemtoEdit);
            }
            else if (cki.Key == ConsoleKey.D3)
            {
                Console.Clear();
                SQL.SearchProduct();

            }
            else if (cki.Key == ConsoleKey.D4)
            {
                Console.Clear();
                SQL.DeleteProduct();
            }
            else if (cki.Key == ConsoleKey.D5)
            {
                Console.Clear();
                BestilVare();
            }
            else if (cki.Key == ConsoleKey.D6)
            {
                Console.Clear();
                GUI gui = new GUI();
                gui.Menu();
            }
            Vareliste();
        }
        public static void OpretVare()
        {
            Console.Clear();
            Console.WriteLine("Create Product");
            item item = new item();
            item.ProductName = GUI.GetString("Product Name");
            item.BuyPrice = GUI.GetInt("Buy Price");
            item.SalesPrice = GUI.GetInt("Sales Price");
            item.Count = GUI.GetInt("Count");
            item.StorageCapacity = GUI.GetInt("Storage Capacity");
            Database.items.Add(item);
            SQL.CreateProduct(item);
        }

        public static void RedigerVare(int input)
        {
            Console.Clear();
            Console.WriteLine("Edit Product");
            item item = new item();
            item.ProductName = GUI.GetString("Product Name");
            item.BuyPrice = GUI.GetInt("Buy Price");
            item.SalesPrice = GUI.GetInt("Sales Price");
            item.Count = GUI.GetInt("Count");
            item.StorageCapacity = GUI.GetInt("Storage Capacity");
            Database.items.Add(item);
            SQL.EditProduct(item,input);
        }
        public static void BestilVare()
        {
            Console.Clear();
            Console.WriteLine("____________________________________________________________________________________________________________________");
            VarePrint();
            SQL.ReadStockData();
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.WriteLine("Order Product");
            Order order = new Order();
            order.KundeID = GUI.GetInt("Enter Customer ID");
            order.Lokation = GUI.GetString("Enter location");
            Database.Order.Add(order);
            Orderline orderline = new Orderline();
            orderline.VareID = GUI.GetInt("Enter the Product ID you wish to order");
            orderline.getCount = GUI.GetInt("How many do you want to order?");
            Database.Orderline.Add(orderline);
            SQL.AddOrder(orderline, order);
        }
        public static void OrdreListe()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("____________________________________________________________________________________________________________________");
            VarePrint();
            SQL.ReadStockData();
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________________________________________________________________");

        }
    }
}
