using System;

namespace python
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomerGUI.SeedCustomer();
            GUI gui = new GUI();
            gui.Menu();
        }
    }
}
