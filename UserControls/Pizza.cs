using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls
{
    public class Pizza : IPizza
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        public bool IsInStock { get; set; }

        public string Comments { get; set; }

        public Pizza(string name, double price = 4.99, string image = "http://placekitten.com/200/200", bool isInStock = true, string comments= "")
        {
            Name = name;
            Image = image;
            Price = price;
            IsInStock = isInStock;
            Comments = comments;
        }
    }
}
