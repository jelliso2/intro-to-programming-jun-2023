

namespace Banking.UnitTests.BankAccount;

public class GoldCustomerGetsABonusOnDeposits
{
    [Fact]
    public void BonusIsApplied()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        account.AccountType = LoyaltyLevel.Gold;
        var amountToDeposits = 100M;

        var expectedNewBalance = openingBalance + amountToDeposits + 10M;


        account.Deposit(amountToDeposits);

        Assert.Equal(expectedNewBalance, account.GetBalance());
    }
        
}
