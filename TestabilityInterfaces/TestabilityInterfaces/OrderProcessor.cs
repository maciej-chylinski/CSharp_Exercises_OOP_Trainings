using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestabilityInterfaces
{
    public class OrderProcessor
    {
        //private readonly ShippingCalculator _shippingCalculator;
        //interface:
        private readonly IShippingCalculator _shippingCalculator;


        //public OrderProcessor()
        //{
        //    _shippingCalculator = new ShippingCalculator();
        //}
        //changing  constructor by an interface results in loose-coupling -> no dependency to ShippingCalculator, only referencing to the interface
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("this order is alreaqdy processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };

            //shift + ctrl + alt + b = go to definition
        }

    }
}
