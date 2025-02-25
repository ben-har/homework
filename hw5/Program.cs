namespace vehicles_cars
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
            return $"Model:{model},Year:{year}, Make:{make}";


        }







    }
    public class Car : Vehicle
    {
        private bool numberOfDoors;

        public bool NumberOfDoors
        {
            get { return this.numberOfDoors; }
            set { this.numberOfDoors = value; }

        }
        public Car(string make, string model, int year, bool NumberOfDoors)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;



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

        public MotorCycle(string make, string model, int year, bool HasSideCar)
            : base(make, model , year)
        {
            HasSideCar = hasSideCar;


        }
    }
    public class program
    {
        public static void Main(string[] args)
        {
            Vehicle myvehicle = new Vehicle("Honda", "Bug", 1940);

            Car mycar = new Car("Honda", "Bug", 1940, true);

            MotorCycle mymotorcycle = new MotorCycle("Honda", "Bug", 1940, false  );

            Console.WriteLine(mymotorcycle.HasSideCar);

            Console.WriteLine(mycar.NumberOfDoors);
            
            Console.WriteLine(myvehicle.ToString());



        }
    }
}


















