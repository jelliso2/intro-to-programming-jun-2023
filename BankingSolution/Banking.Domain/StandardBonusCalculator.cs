namespace Banking.Domain;

public class StandardBonusCalculator : ICanCalculateBonuses
{
    public StandardBonusCalculator()
    {
    }

    public decimal CalculateBonusForDepositOn(decimal balance, decimal amountOfDeposit)
    {
        if (balance > 5000) 
        { return amountOfDeposit * .10M; }
        else
        {
            return 0;
        }
        
    }
}