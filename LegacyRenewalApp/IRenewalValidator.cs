namespace LegacyRenewalApp;

public interface IRenewalValidator
{
    void Validate(int customerId, string planCode, int seatCount, string paymentMethod);
}