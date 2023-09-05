namespace Car.Model
{
    public abstract class CarInfomationModel : VehicleModel
    {
        public string Oil { get; set; }
        public string Rate { get; set; }
        public string Supplier { get; set; }
        public string Color { get; set; }

        public override void Move()
        {
            Console.WriteLine("Car is moving...");
        }
    }
}