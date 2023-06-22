

using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests.BankAccount;
public class AccountBonusCalculations
{
    [Fact]
    public void DepositsUsesTheBonusCalculator()
    {
        var account = new Account(new StubbedBonusCalculator());
        var openingBalance = account.GetBalance();

        account.Deposit(142);

        Assert.Equal(openingBalance + 100M + 42M, account.GetBalance());
    }
}
