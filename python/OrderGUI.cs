using System;
using System.Collections.Generic;
using System.Text;

namespace python
{
    class OrderGUI
    {
        public static void OrdreListe()
        {
            ConsoleKeyInfo cki;
            Console.Clear();
            Console.WriteLine("Order list");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            OrdrePrint();
            SQL.ReadOrderData();
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.WriteLine("1. Change order status");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1)
            {
                int getItemtoEdit = GUI.GetInt("Enter order to edit");
                RedigerOrdre(getItemtoEdit);
            }
            OrdreListe();
        }
        public static void OrdrePrint()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Order ID");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("Customer ID");
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("Date");
            Console.SetCursorPosition(60, 2);
            Console.WriteLine();
            Console.SetCursorPosition(80, 2);
            Console.WriteLine("Location");
            Console.SetCursorPosition(100, 2);
            Console.WriteLine("Status");
        }
        public static void RedigerOrdre(int input)
        {
            Console.WriteLine();
            Order order = new Order();
            order.Status = GUI.GetString("Enter order status");
            Database.Order.Add(order);
            SQL.EditOrder(order, input);
        }
    }
}
