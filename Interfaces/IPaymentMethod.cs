namespace ProvaPub.Interfaces
{
    public interface IPaymentMethod
    {
        Task<bool> ProcessPayment(decimal paymentValue);
    }
}
