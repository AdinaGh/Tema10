using System;

namespace Ex1
{
    interface IOrder
    {
        IPerson Name { get; set; }
        IVehicle Vehicle { get; set; }
        DateTime DateOfDelivery { get; set; }
    }
}
