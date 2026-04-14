namespace LegacyRenewalApp;

public class DefaultTaxCalc:ITaxCalc
{
    public decimal CalculateTaxAmount(string country, decimal taxBaseAmount)
    {
        decimal taxRate = 0.20m;
        if (country == "Poland")
            taxRate = 0.23m;
        else if (country == "Germany")
            taxRate = 0.19m;
        else if (country == "Czech Republic")
            taxRate = 0.21m;
        else if (country == "Norway")
            taxRate = 0.25m;
        
        return taxRate * taxBaseAmount;
        
    }
}