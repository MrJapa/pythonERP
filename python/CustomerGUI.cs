using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace python
{
    class CustomerGUI
    {
        public static void SeedCustomer()
        {
            Customer customer = new Customer();
            customer.FirstName = "Tom";
            customer.LastName = "Jensen";
            customer.Address = "Vesterbro 23";
            customer.CustomerID = 1;
            customer.PersonID = 1;
            customer.LatestOrderID = 1;
            customer.LastOrderDate = DateTime.Now;
            Database.Customer.Add(customer);
        }
        public static void CreateCustomer()
        {
            Console.Clear();
            Console.WriteLine("Create Customer");
            Customer customer = new Customer();
            int CustomerIDToken = GUI.GetInt("Customer ID");
            var itemToFind = Database.Customer.Find(r => r.CustomerID == CustomerIDToken);
            if (itemToFind != null)
            {
                Console.WriteLine("Customer ID is already taken!");
                var LastID = Database.Customer.Last().CustomerID;
                customer.CustomerID = LastID + 1;
                Console.WriteLine("Assigned Customer ID to: {0}", LastID + 1);
            }
            customer.FirstName = GUI.GetString("First Name");
            customer.LastName = GUI.GetString("Last Name");
            customer.Address = GUI.GetString("Address");
            Database.Customer.Add(customer);
        }
        public static void CustomerPrint(IReadOnlyList<Customer> list)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Customer ID");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("First Name");
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("Last Name");
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("Latest Order Date");
            Console.SetCursorPosition(80, 2);
            Console.WriteLine();
            Console.SetCursorPosition(100, 2);
            int i = 4;
            foreach (var customer in list)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(customer.CustomerID);
                Console.SetCursorPosition(20, i);
                Console.WriteLine(customer.FirstName);
                Console.SetCursorPosition(40, i);
                Console.WriteLine(customer.LastName);
                Console.SetCursorPosition(60, i);
                Console.WriteLine(customer.LastOrderDate);
                Console.SetCursorPosition(80, i);
                Console.WriteLine();
                Console.SetCursorPosition(100, i);
                i++;
            }

        }
        public static void KundeList()
        {
            ConsoleKeyInfo cki;
            Console.Clear();
            Console.WriteLine("Customer list");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            CustomerPrint(Database.Customer.AsReadOnly());
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.WriteLine("1. Create Customer: \n2. Edit Customer: \n3. Search Customer: \n4. Delete Customer: ");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1)
            {
                CreateCustomer();
            }
            else if (cki.Key == ConsoleKey.D2)
            {
                Console.Clear();
            }
            else if (cki.Key == ConsoleKey.D3)
            {

            }
            KundeList();
        }

    }

}
