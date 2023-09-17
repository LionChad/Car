namespace Car.Model
{
    public class MoveModel
    {
        //載具，假定汽車
        public void Move(int Gasoline)
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

        //人力載具，假定腳踏車
        public void Move(int humanity, double cal)
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

        //單純以人力移動，假定走路
        public void Move(double cal)
        {
            #region 流程
            if (cal >= 1)
            {
                Console.WriteLine("Human is moving.");
                cal -= 1;
            }
            else
            {
                Console.WriteLine("Human does not have enough energy to move.");
            }
            #endregion 流程
        }
    }
}