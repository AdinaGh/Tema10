namespace Ex2
{
    class IndividualDepositAccount : Account, IDepositAccount
    {
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override decimal InterestByPeriod(int months)
        {
            return HasSmallBalance ? 0 : base.InterestByPeriod(months);
        }
    }
}
