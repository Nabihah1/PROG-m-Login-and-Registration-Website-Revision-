namespace PROG_m_Register_LoginRevisionWebsite.Services
{
    public interface IPaymentProcessor
    { //the product interface       
        string Process(decimal amount);
    }

    //concrete products 
    public class PayPalProcessor : IPaymentProcessor
    {
        public string Process(decimal amount) => $"Paid {amount:C} via PayPal";
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public string Process(decimal amount) => $"Charged {amount:C} to Credit Card";
    }

    public class CryptoProcessor : IPaymentProcessor
    {
        public string Process(decimal amount) => $"Charged {amount:C} to Crypto Payment";
    }




}

