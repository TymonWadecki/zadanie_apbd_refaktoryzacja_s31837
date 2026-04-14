namespace LegacyRenewalApp;

public interface ITaxCalc
{
    decimal CalculateTaxAmount(string country,decimal taxBaseAmount);
}