using System;
using System.Collections.Generic;
using System.Text;

namespace python
{
    class Product
    {
        public void ProductItems()
        {
            item item = new item();
            item.ItemCode = 1;
            item.Name = "Headphones";
            item.Count = 1000;
            item.SalesPrice = 1499;
            item.CostPrice = 350;
            item.StorageCapacity = 1000;
            Database.items.Add(item);
            Database.items.Add(item.ItemCode = 1, item.Name = "Mouse", item.Count = 1000, item.SalesPrice = 899, item.CostPrice = 250, item.StorageCapacity = 1000);
        }
    }
}
