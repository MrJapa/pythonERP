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
            string queryString = "SELECT * FROM dbo.Items";
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
                        Console.WriteLine(string.Format("{0}", reader["ItemCode"]));
                        Console.SetCursorPosition(20, i);
                        Console.Write(string.Format("{0}", reader["ItemName"]));
                        Console.SetCursorPosition(40, i);
                        Console.Write(string.Format("{0}", reader["Count"]));
                        Console.SetCursorPosition(60, i);
                        Console.Write(string.Format("{0}", reader["SalesPrice"]));
                        Console.SetCursorPosition(80, i);
                        Console.Write(string.Format("{0}", reader["BuyPrice"]));
                        Console.SetCursorPosition(100, i);
                        Console.Write(string.Format("{0}", reader["StorageCapacity"]));
                        i++;
                    }
                }
            }
        }
        public static void CreateProduct(item dbitems)
        {
            string queryString = "INSERT INTO dbo.Items (ItemCode, ItemName, Count, SalesPrice, BuyPrice, StorageCapacity) VALUES ("+dbitems.ItemCode+",'"+dbitems.ItemName+"',"+dbitems.Count+","+dbitems.SalesPrice.ToString().Replace(',','.')+","+dbitems.CostPrice.ToString().Replace(',', '.')+","+dbitems.StorageCapacity+")";
            using (SqlConnection connection = new SqlConnection(ConnectionString.conn))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void DeleteProduct()
        {
            int getItemtoDelete = GUI.GetInt("Write Item Code To Delete");
            string queryString = "DELETE FROM dbo.Items WHERE ItemCode = '+getItemtoDelete+";
            using (SqlConnection connection = new SqlConnection(ConnectionString.conn))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Item Deleted");

            }
        }
    }
}
