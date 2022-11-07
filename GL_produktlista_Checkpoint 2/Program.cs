

class Category
{ 
    public string Category Name {get; set;}

    public Category(string name);
    {
        Category Name = name; 
    }
}

class Product
{
    public Category Category {get; set;}
    public string Item {get; set;}
    public int Price {get; set;}

    public Product(string category, string item, int price)
    {
        Category = category;
        Item     = item;
        Price    = price;
    }    
}

class Price
{
    public int Price {get; set;};

    public Price(int price)
    {
        Price = price;    
    }

    

}




{ 
static void Main(string[] args)

{  bool hasError = false;
   int index = 0;
s  tring[] info = new string[0];
   

    While (True)
      {
        Console.WriteLine("GL_mini project_checkpoint 2");
        Console.WriteLine("Follow instuctions to enter new product. Press "Q" to quit.");
        Console.ForegroundColor = ConsoleColor.White;
        
        Console.WriteLine("Enter a Category");
        string data1 = Console.ReadLine(Category);
        
        Console.WriteLine("Enter a Name");
        string data2 = Console.ReadLine(Product);
       
        Console.WriteLine("Enter a Price");
        string data3 = Console.ReadLine(Price);

    if (data1.Trim().ToLower() == "q")  (data2.Trim().ToLower() == "q") || (data3.Trim().ToLower() == "q")
        {
            break;
        }

        if (String.IsNullOrEmpty(data1) && (String.IsNullOrEmpty(data2) && (String.IsNullOrEmpty(data3)
        {
            Console.WriteLine("Incorrect Entry. Data missing");
            hasError = true;
        }                            

        
            foreach (char c in data1) || (char c in data2)

            // here we declared and set req. for char c
            {
                if (!char.IsLetter(c))  // if char c is not a letter
                {
                    hasError = true;
                }
            }

                if (hasError)
                   {
                    Console.WriteLine("Incorrect Entry. Data must not be a number."); 
                   }

                if (!hasError)
                   {
                    Array.Resize(ref info, index + 1);
                    info[index] = data.ToUpper();
                    index++;
                    Console.WriteLine("Correct Entry!");
                   }
        }
 



Console.WriteLine("-----------");
Console.WriteLine("you have entered following products ");
Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price");
  for (int i = 0; i < info.Length; i++)
   {
    Console.WriteLine(info[i]);
   }

Array.Sort(Product);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-----------");
Console.WriteLine("sorterade produkter");
for (int i = 0; i < info.Length; i++)
{
  Console.WriteLine(info[i]);
}

int sum = items.Sum(item => item.Price);
Console.WriteLine("Sum: ".PadRight(40) + sum);

Console.ForegroundColor = ConsoleColor.White;
     Console.WriteLine("Press enter to continue...");
     Console.ReadLine();

    }
}




    