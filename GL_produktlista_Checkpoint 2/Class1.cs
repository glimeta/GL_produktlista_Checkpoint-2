using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GL_produktlista_Checkpoint_2
{
    class Item
    {
        public Item (string category, string product, int price)
        {
            //Category = category;
            Category = new Category(category);
            Product = product;
            Price = price;
        }

        //public string Category { get; set; }
        public Category Category { get; set; }
        public string Product { get; set; }
        public int Price { get; set; }
    }
}
