namespace SampleWebApp.Models {
    public abstract class Shape {
        public abstract double CalculateArea();
    }

    public class Circle : Shape {
        public double Radius { get; set; }
        public override double CalculateArea() {
            return Math.PI * Radius * Radius;
        } 
    }

    public class Rectangle : Shape {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double CalculateArea() {
            return Length * Width;
        } 
    }
}
