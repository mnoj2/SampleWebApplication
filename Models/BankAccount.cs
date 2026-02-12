namespace SampleWebApp.Models {
    public class BankAccount {
        private decimal _balance; 

        public BankAccount(decimal initialBalance) {
            _balance = initialBalance;
        }

        public decimal GetBalance() {
            return _balance;
        }
            
        public void Deposit(decimal amount) {
            if(amount > 0)
                _balance += amount;
        }

        public bool Withdraw(decimal amount) {
            if(amount > 0 && _balance >= amount) {
                _balance -= amount;
                return true;
            }
            return false;
        }
    }
}
