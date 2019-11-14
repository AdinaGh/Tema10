namespace Ex1
{
    interface IStore 
    {
        string Name { get; set; }
        IOrder EnterAndMakeOrder(IPerson person, IVehicle vehicle);
        void CancelOrder(IOrder order);
    }
}
