namespace Ex1
{
    class Vehicle : IVehicle
    {
        public IProducer Producer { get; set; }
        public string VehicleName { get; set; }
        public decimal Price { get; set; }
    }
}
