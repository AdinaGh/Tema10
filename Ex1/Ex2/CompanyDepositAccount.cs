namespace Ex2
{
    class CompanyDepositAccount : Account, IDepositAccount
    {
        public CompanyDepositAccount(decimal rate) : base(rate)
        {

        }
        public override decimal InterestByPeriod(int months)
        {
            return HasSmallBalance ? 0 : base.InterestByPeriod(months);
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
