namespace Car.Model
{
    public class CarModel : VehicleModel
    {
        private string licensePlate;
        private string brand;
        private string color;
        private bool engineRunning;

        public CarModel(string licensePlate, string brand, string color)
        {
            this.licensePlate = licensePlate;
            this.brand = brand;
            this.color = color;
            this.engineRunning = false;
        }

        public CarModel()
        {
        }

        public override void Move()
        {
            Console.WriteLine("Car is moving...");
        }

        public void StartEngine()
        {
            if (!engineRunning)
            {
                engineRunning = true;
                Console.WriteLine("Engine started.");
            }
        }

        public void StopEngine()
        {
            if (engineRunning)
            {
                engineRunning = false;
                Console.WriteLine("Engine stopped.");
            }
        }

        public void ChangeColor(string newColor)
        {
            color = newColor;
            Console.WriteLine($"Car color changed to {newColor}.");
        }
    }
}