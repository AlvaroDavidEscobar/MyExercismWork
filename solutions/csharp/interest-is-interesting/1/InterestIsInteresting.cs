static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) return 3.213F;
        else if (balance < 1000) return 0.5F;
        else if (balance < 5000) return 1.621F;
        else return 2.475F;
    }

    public static decimal Interest(decimal balance) => balance * (0.01M * Convert.ToDecimal(InterestRate(balance)));

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance) {
            years++;
            balance = AnnualBalanceUpdate(balance);
        }
        return years;
    }
}
