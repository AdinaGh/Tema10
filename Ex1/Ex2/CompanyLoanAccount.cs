namespace Ex2
{
    class CompanyLoanAccount : Account, ILoanAccount
    {
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override decimal InterestByPeriod(int months)
        {
            return months < 3 ? 0 : base.InterestByPeriod(months);
        }
    }
}
