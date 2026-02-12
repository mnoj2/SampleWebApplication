namespace SampleWebApp.Models {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }
        public Employee(int id, string name, decimal salary) {
            Id = id;
            Name = name;
            BasicSalary = salary;
        }
        public decimal CalculateSalary() => BasicSalary + (BasicSalary * 0.10m);
    }
}
