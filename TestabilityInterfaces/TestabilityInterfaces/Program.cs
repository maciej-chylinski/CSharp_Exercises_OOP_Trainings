using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestabilityInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //var orderProcessor = new OrdedProcessor();
            //after changes this method needs a ShippingCalculator
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);

        }
}
}
