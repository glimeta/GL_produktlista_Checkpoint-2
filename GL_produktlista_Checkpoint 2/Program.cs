
using GL_produktlista_Checkpoint_2;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


Console.WriteLine("GL_mini project_checkpoint 2");
Console.WriteLine("Follow instuctions to enter new product. Press 'Q' to quit.");
List<Item> items = new List<Item> ();

while (true) 

{
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter a Category");
        string dataCat = Console.ReadLine();
        if (dataCat.Trim().ToLower() == "q")
         {
            break;
         }
        
        if (String.IsNullOrEmpty(dataCat))
         {
            Console.WriteLine("Incorrect Entry. Data missing");
            continue;
         }

        string dataProd;    
        while (true)                          //while loop needed to make program continue if conditions are not met, to next step user price 
          {
            Console.WriteLine("Enter a Product Name");
            dataProd = Console.ReadLine();
            if (dataProd.Trim().ToLower() == "q")
             {
                break;
             }

            if (String.IsNullOrEmpty(dataProd))
               {
                Console.WriteLine("Incorrect Entry. Data missing");
               }

            else                               //break commnand to make program continue if conditions are not met, to next step user price 
            {
                break;
               }
          }
        
        
        string dataPrice;       // this should be declared outside the loop for break command in the end for dataPrice 
        int value = 0;
        while (true)
          {
            Console.WriteLine("Enter a Price");      //This should be in the loop until correct entry is done.
            dataPrice = Console.ReadLine();

            if (dataPrice.Trim().ToLower() == "q")
              {                                     
                 break;
              }

            if (String.IsNullOrEmpty(dataPrice))
              {
               Console.WriteLine("Incorrect Entry. Data missing");
               continue;

              }

            bool Number = int.TryParse(dataPrice, out value);
            if (!Number)
              {                                                                 ////brackets should be indented
                Console.WriteLine("Incorrect price! Input must be a number");
              }
            else
              {
                break;
              }
          }

        if (dataProd.Trim().ToLower() == "q")   
        {
            break;
        }

        if (dataPrice.Trim().ToLower() == "q")
           {
          break;
           }

      Console.WriteLine("Correct Entry!");
      Item item = new Item(dataCat, dataProd, value);
      items.Add(item);
    }

  Console.WriteLine("-----------");
  Console.WriteLine("you have entered following products ");      

  List<Item> sortedItems = items.OrderBy(item => item.Price).ToList();

  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.WriteLine("Category".PadRight(30) + "Product Name".PadRight(30) + "Price");

     foreach (Item item in sortedItems)
        {
            //This command lays out user data in gategory and columns
            Console.WriteLine(item.Category.CategoryName.PadRight(30) + item.Product.PadRight(30) + item.Price);
        }

  int sum = items.Sum(item => item.Price);     //Command that gives a sum of product prices
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine("Sum: ".PadRight(50) + sum);

  Console.WriteLine("");
  Console.ForegroundColor = ConsoleColor.White;

  Console.WriteLine("Press enter to continue or 'q' to exit");

  string answer = Console.ReadLine();
   if (answer.ToLower().Trim() == "q")
      {
         break;
      }

}  

Console.ReadLine();




