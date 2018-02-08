using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestabilityInterfaces
{
    //interface
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    //passing the interface
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}
//Microsoft Test Runner - do uruchamiania testów / unit testów stworzonych przy uzyciu visuala