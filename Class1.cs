using System;
class Product
{
    public Category Category { get; set; }
    public string Item { get; set; }
    public int Price { get; set; }

    public Product(string category, string item, int price)
    {
        Category = category;
        Item = item;
        Price = price;
    }