using System;

namespace python
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductItems();
            GUI gui = new GUI();
            gui.Menu();
        }
    }
}
