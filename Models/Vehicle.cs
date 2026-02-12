namespace SampleWebApp.Models {
    public class Vehicle {
        public string Brand { get; set; }
        public int Speed { get; set; }
        public virtual string Start() => "Vehicle is starting...";
    }

    public class Car : Vehicle {
        public override string Start() => $"{Brand} Car engine roars!";
    }

    public class Bike : Vehicle {
        public override string Start() => $"{Brand} Bike kickstarts!";
    }
}
