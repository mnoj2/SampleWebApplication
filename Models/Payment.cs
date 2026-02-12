namespace SampleWebApp.Models {
    public interface IPayment {
        string ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPayment {
        public string ProcessPayment(decimal amount) => $"Processed ${amount} via Credit Card.";
    }

    public class UPIPayment : IPayment {
        public string ProcessPayment(decimal amount) => $"Processed ${amount} via UPI.";
    }

    public class CashPayment : IPayment {
        public string ProcessPayment(decimal amount) => $"Processed ${amount} via Cash.";
    }
}
