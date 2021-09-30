using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace python
{
    public class SQL
    {
        public static void ReadStockData()
        {
            string queryString = "SELECT * FROM dbo.Varer";
            using (SqlConnection connection = new SqlConnection(ConnectionString.conn))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 3;
                    while (reader.Read())
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(string.Format("{0}", reader["ID"]));
                        Console.SetCursorPosition(20, i);
                        Console.Write(string.Format("{0}", reader["ProductName"]));
                        Console.SetCursorPosition(40, i);
                        Console.Write(string.Format("{0}", reader["BuyPrice"]));
                        Console.SetCursorPosition(60, i);
                        Console.Write(string.Format("{0}", reader["SalesPrice"]));
                        Console.SetCursorPosition(80, i);
                        Console.Write(string.Format("{0}", reader["Count"]));
                        Console.SetCursorPosition(100, i);
                        Console.Write(string.Format("{0}", reader["StorageCapacity"]));
                        i++;
                    }
                }
            }
        }
        public static void CreateProduct(item dbitems)
        {
            string queryString = $"INSERT INTO dbo.Varer (ProductName, BuyPrice, SalesPrice, Count, StorageCapacity) VALUES ('{dbitems.ProductName}',{dbitems.BuyPrice},{dbitems.SalesPrice},{dbitems.Count},{dbitems.StorageCapacity})";
            using (SqlConnection connection = new SqlConnection(ConnectionString.conn))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void DeleteProduct()
        {
            int getItemtoDelete = GUI.GetInt("Write Product ID To Delete");
            string queryString = "DELETE FROM dbo.Varer WHERE ID = "+getItemtoDelete+"";
            using (SqlConnection connection = new SqlConnection(ConnectionString.conn))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Item Deleted");

            }
        }

        public static void SearchProduct()
        {
            string getItemToSearch = GUI.GetString("Enter Product ID");
            string queryString = $"SELECT * FROM dbo.Varer WHERE ID ='{getItemToSearch}'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.conn))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 4;
                    Console.WriteLine("Found Products");
                    Console.WriteLine("____________________________________________________________________________________________________________________");
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("Product ID");
                    Console.SetCursorPosition(20, 3);
                    Console.WriteLine("Name");
                    Console.SetCursorPosition(40, 3);
                    Console.WriteLine("Buy Price");
                    Console.SetCursorPosition(60, 3);
                    Console.WriteLine("Sales Price");
                    Console.SetCursorPosition(80, 3);
                    Console.WriteLine("Stock");
                    Console.SetCursorPosition(100, 3);
                    Console.WriteLine("Storage Capacity");
                    while (reader.Read())
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(string.Format("{0}", reader["ID"]));
                        Console.SetCursorPosition(20, i);
                        Console.Write(string.Format("{0}", reader["ProductName"]));
                        Console.SetCursorPosition(40, i);
                        Console.Write(string.Format("{0}", reader["BuyPrice"]));
                        Console.SetCursorPosition(60, i);
                        Console.Write(string.Format("{0}", reader["SalesPrice"]));
                        Console.SetCursorPosition(80, i);
                        Console.Write(string.Format("{0}", reader["Count"]));
                        Console.SetCursorPosition(100, i);
                        Console.Write(string.Format("{0}", reader["StorageCapacity"]));
                        i++;
                    }
                    Console.WriteLine("\n____________________________________________________________________________________________________________________");
                }
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }

        }
        public static void EditProduct(item dbitems, int getItemtoEdit)
        {
            string queryString = $"UPDATE dbo.Varer set ProductName ='{dbitems.ProductName}', BuyPrice ='{dbitems.BuyPrice}', SalesPrice ='{dbitems.SalesPrice}', Count ='{dbitems.Count}', StorageCapacity ='{dbitems.StorageCapacity}' WHERE ID = '{getItemtoEdit}'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.conn))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Item Updates");
            }
        }
    }
}
