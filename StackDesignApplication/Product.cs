using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDesignApplication
{
    public class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public Product(string brand, string model, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
        }

    }
}
