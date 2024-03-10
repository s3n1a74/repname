using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Queues
    {
        public string Name { get; set; }
        public string OrderCount { get; set; }
        public Queues(string name, string orderCount )
        {
            Name = name;
            OrderCount = orderCount;
        }
        public static void Queuee(Queue<Queues> list)
        {
            while ( list.Count > 0 )
            {
                var order = list.Dequeue();
                Console.WriteLine($"Выполняем заказ {order.Name}:{order.OrderCount} ");
            }
            Console.WriteLine("Все заказы выполнены");
        }
    }
}
