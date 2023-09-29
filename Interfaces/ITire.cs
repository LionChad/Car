
#region 抽象產品
public interface ITire
{
    void Produce();
}
#endregion

#region 具體產品
#region 具體產品-摩托車輪胎
public class MotorbikeTire : ITire
{
    public void Produce()
    {
        Console.WriteLine("生產摩托車輪胎");
    }
}
#endregion

#region 具體產品-飛機輪胎
public class PlaneTire : ITire
{
    public void Produce()
    {
        Console.WriteLine("生產飛機輪胎");
    }
}
#endregion

#region 具體產品-汽車輪胎
// 具體產品
public class CarTire : ITire
{
    public void Produce()
    {
        Console.WriteLine("生產汽車輪胎");
    }
}

public class ReinforcedCarTire : CarTire
{
    public new void Produce()
    {
        Console.WriteLine("生產加強汽車輪胎");
    }
}

public class WearResistantCarTire : CarTire
{
    public new void Produce()
    {
        Console.WriteLine("生產耐磨汽車輪胎");
    }
}
#endregion
#endregion

#region 抽象工廠
public interface IAbstractFactory
{
    ITire CreateTire();
}
#endregion

#region 具體工廠
#region 具體工廠-汽車輪胎
public class CarFactory : IAbstractFactory
{
    public ITire CreateTire()
    {
        return new CarTire();
    }
}

public class ReinforcedCarFactory : IAbstractFactory
{
    public ITire CreateTire()
    {
        return new ReinforcedCarTire();
    }
}

public class WearResistantCarFactory : IAbstractFactory
{
    public ITire CreateTire()
    {
        return new WearResistantCarTire();
    }
}

#endregion

#region 具體工廠-摩托車輪胎
public class MotorbikeFactory : IAbstractFactory
{
    public ITire CreateTire()
    {
        return new MotorbikeTire();
    }
}
#endregion

#region 具體工廠-飛機輪胎
public class PlaneFactory : IAbstractFactory
{
    public ITire CreateTire()
    {
        return new PlaneTire();
    }
}
#endregion
#endregion

//class Program
//{
//    static void Main(string[] args)
//    {
//        // 生產汽車輪胎
//        Client(new CarFactory());
//        // 生產加強汽車輪胎
//        Client(new ReinforcedCarFactory());
//        // 生產耐磨汽車輪胎
//        Client(new WearResistantCarFactory());
//        // 生產摩托車輪胎
//        Client(new MotorbikeFactory());
//        // 生產飛機輪胎
//        Client(new PlaneFactory());
//    }

//    static void Client(IAbstractFactory factory)
//    {
//        var tire = factory.CreateTire();
//        tire.Produce();
//    }
//}