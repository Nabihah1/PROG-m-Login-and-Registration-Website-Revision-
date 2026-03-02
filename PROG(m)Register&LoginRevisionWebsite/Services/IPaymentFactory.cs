namespace PROG_m_Register_LoginRevisionWebsite.Services
{
    public interface IPaymentFactory
    {
        IPaymentProcessor Create(string type);
    }

    public class PaymentFactory : IPaymentFactory
    {
        public IPaymentProcessor Create(string type)
        {
            return type.ToLower() switch
            {
                "paypal" => new PayPalProcessor(),
                "card" => new CreditCardProcessor(),
                "crypto" => new CryptoProcessor(),
                _ => throw new ArgumentException("Invalid Payment Type")
            };



        }
    }
}
