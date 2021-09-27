using System;

namespace python
{
    class Program
    {
        static void Main(string[] args)
        {
            Product.ProductItems();
            CustomerGUI.SeedCustomer();
            GUI gui = new GUI();
            gui.Menu();
        }
    }
}
