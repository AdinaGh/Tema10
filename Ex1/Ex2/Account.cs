namespace Ex2
{
    public abstract class Account
    {
        protected Account()
        {

        }
        protected Account(decimal rate)
        {
            InterestRate = rate;
        }
        protected decimal Balance { get; set; }
        protected decimal InterestRate { get; set; }
        public virtual decimal InterestByPeriod(int months)
        {
            return months * InterestRate;
        }

        protected bool HasSmallBalance => (Balance > 0 && Balance < 1000);
    }
}
