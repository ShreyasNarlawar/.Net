namespace _10OOPProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine("Enter id ");
            int id = Convert.ToInt32(Console.ReadLine());
            e.eid = id;
            Console.WriteLine("The id is {0}", e.eid);
            Console.WriteLine("Enter name of emp");
            e.ename = Console.ReadLine();
            Console.WriteLine("The name is {0}", e.ename);

            e.logger = new Logger();
            e.logger.Log();
            string deptnm = e.dept;
            Console.WriteLine("the dept of emp is " + deptnm);

        }

        public class Employee
        {
            private int _eid;
            private string _ename;
            private string _dept;
            private Logger _logger;


            //PROPERTIES SYNTAX
            public int eid
            {
                set
                {
                    _eid = value;
                }
                get
                {
                    return _eid;
                }
            }
            public string ename
            {
                set
                {
                    _ename = value;
                }
                get
                {
                    _ename = "Mr." + _ename     ;
                    return _ename;
                }
            }
            public string dept
            {
                get
                {
                    _dept = "Hr";
                    return _dept;
                }
            }
            public Logger logger
            {
                set
                {
                    _logger = value;
                }
                get
                {
                    return _logger;
                }
            }

        }

        public class Logger
        {
            public void Log()
            {
                Console.WriteLine("logger method output");
            }
        }
    }

  
}
