internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    // Bir işyerinde hem fulltime çalışan ek olarak da part time çalışan personellerin olduğu düşünürsek...

    //class FulltimeEmployee
    //{

    //    public void CalculateSalary()
    //    {
    //        // ......
    //        //.....

    //        Console.WriteLine("Fulltime Employee salary =...");
    //    }
    //}

    //class ParttimeEmployee
    //{
    //    public void CalculateSalary()
    //    {
    //        // ......
    //        //.....

    //        Console.WriteLine("Parttime Employee salary =...");
    //    }
    //}

    //class SupportEmployee
    //{
    //    public void CalculateSalary()
    //    {
    //        // ......
    //        //.....

    //        Console.WriteLine("Support Employee salary =...");
    //    }
    //}

    //class SalaryCalculator
    //{
    //    public void CalculateSalary(string employeeType)
    //    {

    //        if (employeeType == "Full") 
    //        {
    //            new FulltimeEmployee().CalculateSalary();
    //        }
    //        else if (employeeType == "Support")
    //        {
    //            new SupportEmployee().CalculateSalary();
    //        }
    //        else
    //        {
    //            new ParttimeEmployee().CalculateSalary();
    //        }
            
    //    }
    //}

    // Senaryo değiştiğinde...Mesela fulltime ve parttime çalışma şeklinin yanına bir destek çalışması personeli geldiğini düşünmüş olsak..

    // Bu durumda SalaryCalculator metoduna bir ekleme yaptık.Yani değiştirdir. Ama O prensibine göre değişime kapalı olsun deniyordu. Kuralı ezdik...

    // Çözümü : bir Interface tanımlayarak bu durumun önüne geçebiliriz..

    interface IEmployee 
    { 
        void CalculateSalary();
    }

    class FulltimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            //...

            Console.WriteLine( "Fulltime Employee Salary = 999999..");
        }
    }

    class ParttimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            //...

            Console.WriteLine("Parttime Employee Salary = 777777..");
        }
    }

    class SupportEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            //...

            Console.WriteLine("Support Employee Salary = 666666..");
        }
    }

    class SalaryCalculator
    {
        private readonly IEmployee _employee;

        public SalaryCalculator(IEmployee employee)
        {
            _employee = employee;   
        }
        public void CalculateSalary()
        {
            _employee.CalculateSalary();
        }


    }
}