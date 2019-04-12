using System;
using Enum1.Entities;
using Enum1.Entities.Enums;

namespace Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
             
            Console.WriteLine(order);

            string texto = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(texto);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
