using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{

    interface IStore 
    {
        string Name { get; set; }
        IOrder EnterAndMakeOrder(IPerson person, IVehicle vehicle);
        void CancelOrder(IOrder order);
    }
    interface IPerson
    {
      string Name { get; set; }
    }
    interface IOrder
    {
        IPerson Name { get; set; }
        IVehicle Vehicle { get; set; }
        DateTime DateOfDelivery { get; set; }
    }
    interface IProducer
    {
        string ProducerName { get; set; }
    }
    interface IVehicle
    {
        IProducer Producer { get; set; }
        string VehicleName { get; set; }
        decimal Price { get; set; }
    }

    class Client : IPerson
    {
        public string Name { get; set; }
    }
    class Order : IOrder
    {
        public IPerson Name { get; set; }
        public IVehicle Vehicle { get; set; }
        public DateTime DateOfDelivery { get; set; }

    }
    class Producer : IProducer
    {
        public string ProducerName { get; set; }
    }
    class Vehicle : IVehicle
    {
        public IProducer Producer { get; set; }
        public string VehicleName { get; set; }
        public decimal Price { get; set; }
    }

    class Store : IStore
    {
        private List<IOrder> Orders;
        public Store(string name)
        {
            this.Name = name;
            Orders = new List<IOrder>();
        }

        public string Name { get; set; }
        public void CancelOrder(IOrder order)
        {
            Console.WriteLine($"{order.Name} cancel {order.Vehicle}");
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
                DateOfDelivery = DateTime.Now
            };

            Orders.Add(order);

            return order;

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            IPerson alex = new Client { Name = "Alex" };

            IStore ford = new Store("Ford");
            IVehicle focus = new Vehicle
            {
                VehicleName = "Focus",
                Price = 15000,
                Producer = new Producer { ProducerName = "Ford" }
            };

            IStore skoda = new Store("Skoda");
            IVehicle fabia = new Vehicle
            {
                VehicleName = "Fabia",
                Price = 14000,
                Producer = new Producer { ProducerName = "Skoda" }
            };

            IOrder focusOrder = ford.EnterAndMakeOrder(alex, focus);

            IOrder skodaOrder = skoda.EnterAndMakeOrder(alex, fabia);

            if (focusOrder.DateOfDelivery < skodaOrder.DateOfDelivery)
            {
                skoda.CancelOrder(skodaOrder);
            }
            else
            {
                ford.CancelOrder(focusOrder);
            }
        }
    }
}
