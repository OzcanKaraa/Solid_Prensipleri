internal class Program
{
    private static void Main(string[] args)
    {
        // LaserJet görevleri
        HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
        hPLaserJetPrinter.Print("Laser bPrinting");
        hPLaserJetPrinter.Scan("Laser Scanning");
        hPLaserJetPrinter.Fax("Laser Faxing");
        hPLaserJetPrinter.PrintDuplex("Laser Çift yön baskı");

        // Inkjet görevleri
        LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
        liquidInkjetPrinter.Print("Inkjet printing");
        liquidInkjetPrinter.Scan("Inkjet scanning");

        Console.ReadKey();
    }


    #region without Segregation

    //public interface IPrinterTasks // büyük yapıda bir interface
    //{
    //    void Print(string PrintContent);
    //    void Scan(string ScanContent);
    //    void Fax(string FaxContent);
    //    void PrintDuplex(string PrintDuplexContent);
    //}

    public class HPLaserJetPrinter : IPrinterTasks,IFaxTaks,IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }

        public void Fax(string FaxContent)
        {
            Console.WriteLine(FaxContent);
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine(PrintDuplexContent);
        }
    }

    public class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }

    }

    #endregion

    #region with Segregation
    public interface IPrinterTasks // büyük yapıda bir interface
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);

    }

    interface IFaxTaks
    {
        void Fax(string content);
    }

    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }

    #endregion
}