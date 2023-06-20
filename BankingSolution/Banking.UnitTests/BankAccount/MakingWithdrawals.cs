

namespace Banking.UnitTests.BankAccount;

public class MakingWithdrawals
{
    [Fact]
    public void WithdrawalsDecreaseBalance()
    {
        //Given
        //If account exists and deposit 100
        Account account = new Account();
        decimal openingBalance = account.GetBalance();
        decimal amountToWithdrawal = 50M;

        //When - I do the deposit
        account.Withdrawal(amountToWithdrawal);

        //Then - I can verify if it worked
        Assert.Equal(openingBalance - amountToWithdrawal, account.GetBalance());

    }
}
