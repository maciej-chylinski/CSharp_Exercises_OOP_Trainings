using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestabilityInterfaces.Tests
{
    [TestClass]    
    public class OrderProcessorTests
    {
        //MOTHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderdProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                //Initialisation so that IsShipped returns True
                Shipment = new Shipment()
            };
            orderdProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropfertyOfTheOrder()
        {
            var orderdProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order(); //Shipment not initialized, so IsShipped returns False

            orderdProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);

        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {        
        public float CalculateShipping(Order order)
        {
            //throw new NotImplementedException();
            return 1;
        }
    }


}
