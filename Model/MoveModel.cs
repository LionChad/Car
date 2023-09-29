namespace Car.Model
{
    // 定義移動介面
    public interface IMovable
    {
        void Move();
    }

    // 汽車類別實現IMovable介面
    public class Car : IMovable
    {
        private int Gasoline;

        public Car(int initialGasoline)
        {
            Gasoline = initialGasoline;
        }

        public void Move()
        {
            #region 流程

            if (Gasoline >= 1)
            {
                Console.WriteLine("Car is moving.");
                Gasoline--;
            }
            else
            {
                Console.WriteLine("Car is out of fuel.");
            }
            #endregion 流程
        }
    }

    // 腳踏車類別實現IMovable介面
    public class Bicycle : IMovable
    {
        private int humanity;
        private double cal;

        public Bicycle(int initialHumanity, double initialCal)
        {
            humanity = initialHumanity;
            cal = initialCal;
        }

        public void Move()
        {
            #region 流程

            if (humanity >= 1 && cal >= 1)
            {
                Console.WriteLine("Bicycle is moving.");
                humanity--;
                cal -= 1;
            }
            else
            {
                Console.WriteLine("Bicycle cannot move.");
            }
            #endregion 流程
        }
    }

    // 人類類別實現IMovable介面
    public class Human : IMovable
    {
        private double cal;

        public Human(double initialCal)
        {
            cal = initialCal;
        }

        public void Move()
        {
            if (cal >= 1)
            {
                Console.WriteLine("Human is moving.");
                cal -= 1;
            }
            else
            {
                Console.WriteLine("Human does not have enough energy to move.");
            }
        }
    }
}