using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string address { get; set; }
        public int ID { get; set; }

    }

    public class Order {

        public int O_ID { get; set; }
        public int C_ID { get; set; }
        public String P_Name { get; set; }
        public int Quantity { get; set; }
        public string CAddress { get; set; }

    
    }

    public class Product
    {
        public string P_Name { get; set; }
        public int Quantity  { get; set; }
        public String Model { get; set; }
    }
}
