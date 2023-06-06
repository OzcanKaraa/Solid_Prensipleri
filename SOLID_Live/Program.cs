internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    class Customer
    {
        public string Name { get; set; }

        //public bool ValidateName(string name)
        //{
        //    return !string.IsNullOrEmpty(name);
        //}

        //public void Greeting(string name)
        //{
        //    Console.WriteLine("Hello " + name);
        //}

        // Bu yukardaki yapı SOLID prensiplerinin S sine uymuyor

        class CustomerValidator
        {
            // Görevi gelendeğişgenin boş olup olmadığını görmek
            public bool ValidateName(string name)
            {
                return !string.IsNullOrEmpty(name);
            }
        }

        class CustormerManager
        {
            // Karşılama mesajı..
            public void Greeting(string name)
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
}