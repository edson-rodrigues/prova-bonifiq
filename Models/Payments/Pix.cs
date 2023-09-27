using ProvaPub.Interfaces;

namespace ProvaPub.Models.Payments
{
    public class Pix : IPaymentMethod
    {
        public Task<bool> ProcessPayment(decimal paymentValue)
        {
            throw new NotImplementedException();
        }
    }
}
