using ProvaPub.Auxiliares;
using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService
	{
		private readonly PaymentMethodFactory paymentMethodFactory;

        public OrderService(PaymentMethodFactory paymentMethodFactory)
        {
            this.paymentMethodFactory = paymentMethodFactory;
        }

        public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
        {
            var paymentProcessor = paymentMethodFactory.CreatePaymentMethod(paymentMethod);

            bool paymentSuccess = await paymentProcessor.ProcessPayment(paymentValue);

            if (paymentSuccess)
            {
                return new Order()
                {
                    Value = paymentValue
                };
            }
            else
            {
                throw new InvalidOperationException("Payment failed");
            }
        }
    }
}
