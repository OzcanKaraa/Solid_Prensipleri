internal class Program
{
    private static void Main(string[] args)
    {
        // 3
        HomeIndex();

        CategoryIndex();

        CategoryIndex2();

        CategoryIndex3();

        Console.ReadKey();

        // sanki MVC gibi
        // 2
        static void HomeIndex()
        {
            //CategoryRepositoryEF categoryRepositoryEF = new CategoryRepositoryEF();
            //categoryRepositoryEF.GetCategories();

            //7
            Container container = new Container();
            container.GetInstance().GetCategories();

        }
        static void CategoryIndex()
        {
            //CategoryRepositoryEF categoryRepositoryEF = new CategoryRepositoryEF();
            //categoryRepositoryEF.GetCategories();

            //7
            Container container = new Container();
            container.GetInstance().GetCategories();

        }
        static void CategoryIndex2()
        {
            //CategoryRepositoryEF categoryRepositoryEF = new CategoryRepositoryEF();
            //categoryRepositoryEF.GetCategories();

            //7
            Container container = new Container();
            container.GetInstance().GetCategories();

        }
        static void CategoryIndex3()
        {
            //CategoryRepositoryEF categoryRepositoryEF = new CategoryRepositoryEF();
            //categoryRepositoryEF.GetCategories();

            //7
            Container container = new Container();
            container.GetInstance().GetCategories();

        }
    }

    // 6
    class Container
    {
        // ICategoryRepository diye birşey görürsen eğer gel bunu CategoryRepositorEF olarak algıla
        public ICategoryRepository GetInstance()
        {
            return new CategoryRepositoryEF();
            //
            //return new CategoryRepositoryDapper();
            //

        }
    }


    // 5
    interface ICategoryRepository
    {
        void GetCategories();
    }


    #region without DIP
    // 1
    class CategoryRepositoryEF : ICategoryRepository
    {
        public void GetCategories()
        {
            // ....
            Console.WriteLine("Veriler EF ile getirildi....");
        }
    }
    // yeni bir veriye erişim gerekti ama baska bir library ile
    // 4...bunu yaptıktan sonraki 2. nuraları adımdaki değişiklikler çok zahmetli..bütün class içeriklerini değiştirmek gerekecek.(sıkı sıkıya bağımlılık olduğundan dolayı - new keyword kullanıldığından dolayı)

    class CategoryRepositoryDapper : ICategoryRepository
    {
        public void GetCategories()
        {
            // ....
            Console.WriteLine("Veriler Dapper ile getirildi....");
        }
    }


    #endregion


}