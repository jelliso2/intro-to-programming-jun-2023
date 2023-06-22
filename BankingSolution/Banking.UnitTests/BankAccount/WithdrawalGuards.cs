

using Banking.Domain;
using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests.BankAccount;

public class WithdrawalGuards
{
    [Fact]
    public void OverdraftNotAllowed()
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        try
        {
            account.Withdrawal(openingBalance + .01M);
        }
        catch (OverdraftException)
        {

            //throw;
        }

        Assert.Equal(openingBalance, account.GetBalance());
    }

    [Fact]
    public void OverdraftThrowsException()
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        //account.Withdrawal(openingBalance + .01M);

        Assert.Throws<OverdraftException>(
             () => account.Withdrawal(openingBalance + .01M));
    }

}
