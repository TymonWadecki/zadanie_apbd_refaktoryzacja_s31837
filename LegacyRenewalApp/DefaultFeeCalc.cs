using System;

namespace LegacyRenewalApp;

public class DefaultFeeCalc : IFeeCalc
{
    public (decimal Amount, string Note) CalculateSuppFee(bool includePremiumSupport, string planCode)
    {
        if (!includePremiumSupport) return (0m, string.Empty);
        decimal supportFee =0;    
        if(planCode == "START")
            supportFee = 250m;
        else if (planCode == "PRO")
            supportFee = 400m;
        else if (planCode == "ENTERPRISE")
            supportFee = 700m;
        
        return (supportFee, "premium support icluded; ");
    }

    public (decimal Amount, string Note) CalculatePaymentFee(string paymentMethod, decimal amountBaseForFree)
    {
        switch (paymentMethod)
        {
            case "CARD":
                return (amountBaseForFree * 0.02m, "card payment fee; ");
            case "BANK_TRANSFER":
                return (amountBaseForFree * 0.01m, "bank transfer fee; ");
            case "PAYPAL":
                return (amountBaseForFree * 0.035m, "paypal fee; ");
            case "INVOICE":
                return (0m , "invoice payment fee; ");
            default:
                throw new ArgumentException(" Unsupported payment method; ");
        }
    }
}