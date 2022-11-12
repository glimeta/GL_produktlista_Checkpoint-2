using System;

class PriceDataCheck 

{
    public int Price { get; set; };

    public Price(int price)
    {
        Price = price;
    }

    bool isValue = int.TryParse(priceInput, out value);
    if (!isValue)
          {
            Console.WriteLine("Incorrect price!");
          }
      else

          {
             break;
          }


}
