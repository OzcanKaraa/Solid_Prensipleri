internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer();

        customer.Name = "Test";

        CustomerValidator customerValidator = new CustomerValidator(); 

        customerValidator.ValidateName(customer.Name);

        CustomerManager customerManager = new CustomerManager();

        customerManager.Greeting(customer.Name);

        Console.ReadKey();   

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


    }
    
    public class CustomerValidator
    {
        // Görevi gelendeğişgenin boş olup olmadığını görmek
        public bool ValidateName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }
    }

    public class CustomerManager
    {
        // Karşılama mesajı..
        public void Greeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}