using ProvaPub.Interfaces;

namespace ProvaPub.Models.Payments
{
    public class CreditCard : IPaymentMethod
    {
        public Task<bool> ProcessPayment(decimal paymentValue)
        {
            throw new NotImplementedException();
        }
    }
}
