using System;

namespace LegacyRenewalApp;

public interface IFeeCalc
{
    (decimal Amount,string Note) CalculateSuppFee(bool includePremiumSupport,string planCode);
    (decimal Amount,string Note) CalculatePaymentFee(string paymentMethod,decimal amountBaseForFree);
}