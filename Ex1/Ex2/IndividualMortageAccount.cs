namespace Ex2
{
    class IndividualMortageAccount : Account, IMortageAccount
    {
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
