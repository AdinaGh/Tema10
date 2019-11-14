using System;
using System.Collections.Generic;

namespace Ex1
{
    class Store : IStore
    {
        private List<IOrder> Orders;
        public Store(string name, int weeksToDelivery)
        {
            this.Name = name;
            Orders = new List<IOrder>();
            this.weeksToDelivery = weeksToDelivery;
        }

        public string Name { get; set; }

        int weeksToDelivery  = 1;
        public void CancelOrder(IOrder order)
        {
            Console.WriteLine($"{order.Name.Name} cancel {order.Vehicle.VehicleName}");
            Orders.Remove(order);
        }
        public IOrder EnterAndMakeOrder(IPerson person, IVehicle vehicle)
        {
            Console.WriteLine($"{person.Name} enter to {this.Name}");

            Console.WriteLine($"{person.Name} order {vehicle.VehicleName}");

            var order = new Order
            {
                Name = person,
                Vehicle = vehicle,
                DateOfDelivery = DateTime.Now.AddDays(weeksToDelivery * 7)
            };

            Orders.Add(order);

            return order;

        }

    }
}
