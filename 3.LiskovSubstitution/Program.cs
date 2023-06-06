internal class Program
{
    private static void Main(string[] args)
    {
        //Apple apple = new Orange();

        //Console.WriteLine(apple.GetColor());

        IFruit fruit = new Orange();

        Console.WriteLine($"Portakalın rengi : {fruit.GetColor()}");

        fruit = new Apple();
        Console.WriteLine($"Elmanın rengi : {fruit.GetColor()}");


        Console.ReadKey();
    }

    //public class Apple
    //{
    //    public virtual string GetColor()
    //    {
    //        return "Kırmızı";
    //    }

    //}

    //// bu sınıf Apple sınıfından türemiş olsun
    //public class Orange : Apple
    //{
    //    public virtual string GetColor()
    //    {
    //        return "Turuncu";
    //    }
    //}

    // bu tür durumda kurtarıcımız yine Interface

    public interface IFruit
    {
        string GetColor();
    }

    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Kırmızı";
        }
    }

    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Turuncu";
        }
    }




}