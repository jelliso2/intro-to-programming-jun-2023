namespace Banking.Domain
{
    public class Account
    {
        private decimal _balance = 5000;
        public void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdrawal(decimal amountToWithdrawal)
        {
            if(amountToWithdrawal >= _balance)
            {
                return;
            }
            _balance -= amountToWithdrawal;
        }
    }
}