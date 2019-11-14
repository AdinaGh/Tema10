namespace Ex2
{
    class IndividualLoanAccount : Account, ILoanAccount
    {
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override decimal InterestByPeriod(int months)
        {
            return months < 4 ? 0 : base.InterestByPeriod(months);
        }
    }
}
