namespace Car.Model
{
    public abstract class VehicleModel
    {
        public abstract void Move();

        public static int MovingDistance(int destination, int location)
        {
            return destination - location;
        }
    }
}