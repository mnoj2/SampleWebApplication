namespace SampleWebApp.Models {
    public class Vehicle {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public virtual string Start() {
            return "Vehicle is starting...";
        } 
    }

    public class Car : Vehicle {
        public override string Start() {
            return $"{Brand} Car is starting...";
        }
    }

    public class Bike : Vehicle {
        public override string Start() {
            return $"{Brand} Bike is starting...";
        }
    }
}
