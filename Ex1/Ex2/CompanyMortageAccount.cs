namespace Ex2
{
    class CompanyMortageAccount : Account, ILoanAccount
    {
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
