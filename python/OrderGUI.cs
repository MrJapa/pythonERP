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
            Console.WriteLine("Customer list");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.WriteLine("1. Create Customer: \n2. Edit Customer: \n3. Search Customer: \n4. Delete Customer: \n5. Back:");
            cki = Console.ReadKey();
        }
    }
}
