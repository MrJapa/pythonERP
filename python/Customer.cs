using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace python
{
    class Customer:Person
    {
        public int CustomerID { get; set; }
        public int LatestOrderID { get; set; }
        public DateTime LastOrderDate { get; set; }
    }
}
