namespace SampleWebApp.Models {
    public abstract class Emp {
        public string Name { get; set; }
        public abstract decimal CalculateSalary();
    }

    public class PermanentEmp : Emp {
        public decimal MonthlyPay { get; set; }
        public override decimal CalculateSalary() => MonthlyPay;
    }

    public class ContractEmp : Emp {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public override decimal CalculateSalary() => HourlyRate * HoursWorked;
    }
}
