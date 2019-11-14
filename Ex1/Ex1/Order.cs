using System;

namespace Ex1
{
    class Order : IOrder
    {
        public IPerson Name { get; set; }
        public IVehicle Vehicle { get; set; }
        public DateTime DateOfDelivery { get; set; }

    }
}
