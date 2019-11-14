using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson alex = new Client { Name = "Alex" };

            IStore ford = new Store("Ford", 4);
            IVehicle focus = new Vehicle
            {
                VehicleName = "Focus",
                Price = 15000,
                Producer = new Producer { ProducerName = "Ford" }
            };

            IStore skoda = new Store("Skoda", 3);
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
