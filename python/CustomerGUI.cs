using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace python
{
    class CustomerGUI
    {
        public static void OpretKunde()
        {
            Console.Clear();
            Console.WriteLine("Create Customer");
            Customer customer = new Customer();
            customer.FirstName = GUI.GetString("First Name");
            customer.LastName = GUI.GetString("Last Name");
            customer.Address = GUI.GetString("Address");
            customer.City = GUI.GetString("City");
            customer.PostalCode = GUI.GetInt("Postal Code");
            customer.PhoneNum = GUI.GetInt("Phone Number");
            customer.Email = GUI.GetString("Email");
            Database.Customer.Add(customer);
            SQL.CreateCustomer(customer);
        }
        public static void RedigerKunde(int input)
        {
            Customer customer = new Customer();
            customer.FirstName = GUI.GetString("First Name");
            customer.LastName = GUI.GetString("Last Name");
            customer.Address = GUI.GetString("Address");
            customer.City = GUI.GetString("City");
            customer.PostalCode = GUI.GetInt("Postal Code");
            customer.PhoneNum = GUI.GetInt("Phone Number");
            customer.Email = GUI.GetString("Email");
            Database.Customer.Add(customer);
            SQL.EditCustomer(customer, input);
        }
        public static void CustomerPrint()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Customer ID");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("First Name");
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("Last Name");
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("City");
            Console.SetCursorPosition(80, 2);
            Console.WriteLine();
            Console.SetCursorPosition(100, 2);
        }
        public static void KundeList()
        {
            ConsoleKeyInfo cki;
            Console.Clear();
            Console.WriteLine("Customer list");
            Console.WriteLine("____________________________________________________________________________________________________________________");
            CustomerPrint();
            SQL.ReadCustomerData();
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.WriteLine("1. Create Customer: \n2. Edit Customer: \n3. Search Customer: \n4. Delete Customer: \n5. Back:");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1)
            {
                OpretKunde();
            }
            else if (cki.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Customer list");
                Console.WriteLine("____________________________________________________________________________________________________________________");
                CustomerPrint();
                SQL.ReadCustomerData();
                Console.WriteLine();
                Console.WriteLine("____________________________________________________________________________________________________________________");
                int getItemtoEdit = GUI.GetInt("Enter Customer ID to edit");
                RedigerKunde(getItemtoEdit);
            }
            else if (cki.Key == ConsoleKey.D3)
            {
                
            }
            else if (cki.Key == ConsoleKey.D4)
            {
                Console.Clear();
                Console.WriteLine("Customer list");
                Console.WriteLine("____________________________________________________________________________________________________________________");
                CustomerPrint();
                SQL.ReadCustomerData();
                Console.WriteLine();
                Console.WriteLine("____________________________________________________________________________________________________________________");
                SQL.DeleteCustomer();
            }
            else if (cki.Key == ConsoleKey.D5)
            {
                Console.Clear();
                GUI gui = new GUI();
                gui.Menu();
            }
            KundeList();
        }

    }

}
