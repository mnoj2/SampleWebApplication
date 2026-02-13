namespace SampleWebApp.Models {
    public interface IPayment {
        string ProcessPayment(decimal amount);
    }

    public class CreditCardPayment : IPayment {
        public string ProcessPayment(decimal amount) {
            return $"Processed Rs. {amount} - CreditCard";
        }
    }

    public class UPIPayment : IPayment {
        public string ProcessPayment(decimal amount) {
            return $"Processed Rs. {amount} - UPI";
        }
    }

    public class CashPayment : IPayment {
        public string ProcessPayment(decimal amount) {
            return $"Processed Rs. {amount} - Cash";
        }
    }
}
