namespace abstract_interface;

interface ICar
{
    void startEngine();
    void drive();
}

interface ISportCar : ICar
{
    int speed { get; set; }
}

interface IFlyingCar : ICar
{
    void flying();
}


class People : ISportCar
{
    public void startEngine()
    {
        throw new NotImplementedException();
    }

    public void drive()
    {
        throw new NotImplementedException();
    }

    public int speed { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
           
    }
}