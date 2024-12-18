
namespace _08OOPLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public abstract class Database
    {
        public Logger _logger;
        public Database()
        {
            _logger = Logger.GetLogger();
        }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract void GetDatabaseName();

        string logmsg = null;
        public void Insert()
        {
            DoInsert();
            logmsg = string.Format("insertion done in {0} successfully", GetDatabaseName());
            _logger.Log(logmsg);
        }
        public void Update()
        {
            DoUpdate();
            _logger.Log("Update happened in "+ GetDatabaseName()+ " successfully")
        }
        public void Delete()
        {
            DoDelete();
            _logger.Log("Update happened in "+ GetDatabaseName()+ " successfully")
        }
    }

    public class DatabaseFactory
    {
        public Database GetDatabase(int ch)
        {
            Database somedatabase = null;
            switch(ch)
                case 1:
                somedatabase = new SQLServer();
                break;
            case 2:
                somedatabase = new MySQL();
                break;
            case 3:
                somedatabase = new Oracle();
                break;
             default
        }
    }
    public class SQLServer :Database
    {
        protected override string GetDatabaseName()
        {
            return "SQLServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Insert done in SQL Server");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Update done in SQL Server");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Delete done in SQL Server");
        }
    }
    public class MySQL : Database
    {
        protected override string GetDatabaseName()
        {
            return "SQLServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Insert done in SQL Server");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Update done in SQL Server");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Delete done in SQL Server");
        }
    }
    public class Oracle : Database
    {
        protected override string GetDatabaseName()
        {
            return "SQLServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Insert done in SQL Server");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Update done in SQL Server");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Delete done in SQL Server");
        }
    }
    public class Logger
    {
        private static Logger logger = new Logger();
       private Logger()
        {
            Console.WriteLine("Logger object created for first time");
        }

        public static Logger GetLogger()
        {
            return logger;
        }

        public void Log(String message)
        {
            Console.WriteLine("Logged :" + message + " " + DateTime.Now.ToString());
        }
        
    }
}
