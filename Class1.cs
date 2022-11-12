using System;

public class Product
{
    public Category Category { get; set; }
    public string Article    { get; set; }
    public int    Price      { get; set; }

    public Product (string category, string article, int price)
    {
        Category = category;
        Article  = article;
        Price    = price;
    }
}