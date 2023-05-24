using Heranca_Polimorfismo.Entities;
using System.Globalization;

namespace Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();

            Console.Write("Enter de number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i+1} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(type == "u")
                {
                    
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct p = new UsedProduct(name,price,date);
                    produtos.Add(p);
                }
                else if(type == "i")
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct p = new ImportedProduct(name,price,fee);
                    produtos.Add(p);
                }
                else
                {
                    Product p = new Product(name, price);
                    produtos.Add(p);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product p in produtos)
            {
                Console.WriteLine(p.PriceTag());
            }


        }
    }
}



