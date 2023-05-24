using System;
using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System.Globalization;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Email: ");
            String email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name,email,date);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now,status,client);

            Console.Write("How many items to this order?: ");
            int quant = int.Parse(Console.ReadLine());

            for(int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data: ");
                Console.Write("Product name: ");
                String productName = Console.ReadLine();
                Console.Write("Product price: ");
                Double productPrice = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName,productPrice);
                OrderItem item = new OrderItem(quantity,productPrice,product);
                order.addItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order.ToString());

        }
    }
}




