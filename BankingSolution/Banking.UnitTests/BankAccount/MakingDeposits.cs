

using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests.BankAccount;

public class MakingDeposits
{
    [Fact]
    public void DepositsIncreaseBalance()
    {
        //Given
        //If account exists and deposit 100
        Account account = new Account(new DummyBonusCalculator());
        decimal openingBalance = account.GetBalance();
        decimal amountToDeposit = 100M;

        //When - I do the deposit
        account.Deposit(amountToDeposit);

        //Then - I can verify if it worked
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());

    }
}
