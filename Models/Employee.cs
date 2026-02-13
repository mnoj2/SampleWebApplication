namespace SampleWebApp.Models {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Bonus { get; set; } = 0.10m;
        public Employee(int id, string name, decimal salary) {
            Id = id;
            Name = name;
            BasicSalary = salary;
        }
        public decimal CalculateSalary() {
            return BasicSalary + (BasicSalary * Bonus);
        }
    }
}
