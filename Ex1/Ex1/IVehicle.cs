namespace Ex1
{
    interface IVehicle
    {
        IProducer Producer { get; set; }
        string VehicleName { get; set; }
        decimal Price { get; set; }
    }
}
