using System.Reflection;

namespace Vehicle
{
    public class Vehicle
    {
        private string make;
        private string model;
        private int year;

        public Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;


        }

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }

        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }


        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }


        }
        public override string ToString()
        {
            return $"vehicle: Model:{model},Year:{year}, Make:{make}";


        }







    }
    public class Car : Vehicle
    {
        private int numberOfDoors;

        public int NumberOfDoors
        {
            get { return this.numberOfDoors; }
            set { this.numberOfDoors = value; }

        }
        public Car(string make, string model, int year, int numberOfDoors)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;



        }


        public override string ToString()
        {
            return $"Car: Model:{Model},Year:{Year}, Make:{Make},The car has {NumberOfDoors} doors";
        }


    }
    public class MotorCycle : Vehicle
    {
        private bool hasSideCar;

        public bool HasSideCar
        {
            get { return this.hasSideCar; }
            set { this.hasSideCar = value; }
        }

        public MotorCycle(string make, string model, int year, bool hasSideCar)
            : base(make, model, year)
        {
            HasSideCar = hasSideCar;


        }
        public override string ToString()
        {

            return $"Motorcycle:  Model:{Model},Year:{Year}, Make:{Make},Does the it have a side car:{HasSideCar}";

        }
    }
    public class program
    {
        public static void Main(string[] args)
        {
            Vehicle myvehicle = new Vehicle("Honda", "Bug", 1940);

            Car mycar = new Car("Honda", "Bug", 1940, 5);

            MotorCycle mymotorcycle = new MotorCycle("Honda", "Bug", 1930, true);

            Console.WriteLine(mymotorcycle.ToString());

            Console.WriteLine( mycar.ToString());

            Console.WriteLine(myvehicle.ToString());



        }
    }
}















