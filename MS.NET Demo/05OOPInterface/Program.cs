namespace OOPInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.SQL Server 2.Oracle Server 3.MySQL");
            int ch = Convert.ToInt32(Console.ReadLine());

            DatabaseFactory db = new DatabaseFactory();
            IDatabase onedb = db.getOneDatabase(ch);

            Console.WriteLine("1.Insert 2.Update 3.Delete");
            int ch1 = Convert.ToInt32(Console.ReadLine());
            switch(ch1){
                case 1:
                    onedb.Insert();
                    break;
                case 2:
                    onedb.Update();
                    break;
                case 3:
                    onedb.Delete();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    public class DatabaseFactory
    {
        public IDatabase getOneDatabase(int ch)
        {
            IDatabase db1 = null;
            switch (ch)
            {
                case 1:
                    db1 = new SQLServer();
                    break;
                case 2:
                    db1 = new Oracle();
                    break;
                case 3:
                    db1 = new MySQL();
                    break;
                default:
                    db1 = null;
                    break;
            }
            return db1;
        }
    }
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class SQLServer :IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Insert into SQLServer database");
        }
        public void Update()
        {
            Console.WriteLine("Update into SQLServer database");
        }
        public void Delete()
        {
            Console.WriteLine("Delete from SQLServer ");
        }
    }
    public class Oracle : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Insert into Oracle database");
        }
        public void Update()
        {
            Console.WriteLine("Update into Oracle database");
        }
        public void Delete()
        {
            Console.WriteLine("Delete from Oracle ");
        }
    }

    public class MySQL : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Insert into MySQL database");
        }
        public void Update()
        {
            Console.WriteLine("Update into MySQL database");
        }
        public void Delete()
        {
            Console.WriteLine("Delete from MySQL ");
        }
    }
}
