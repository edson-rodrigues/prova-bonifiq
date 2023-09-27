using ProvaPub.Interfaces;
using ProvaPub.Models.Payments;

namespace ProvaPub.Auxiliares
{
    public class PaymentMethodFactory
    {
        public IPaymentMethod CreatePaymentMethod(string paymentMethod)
        {
            switch (paymentMethod.ToLower())
            {
                case "pix":
                    return new Pix();
                case "creditcard":
                    return new CreditCard();
                case "paypal":
                    return new Paypal();
                default:
                    throw new InvalidOperationException("Invalid payment method");
            }
        }
    }
}
