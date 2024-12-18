namespace _12Delegate
{
    internal class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate1(String str);
        public delegate string MyDelegate3();
        static void Main(string[] args)
        {
            //MyDelegate dell = new MyDelegate(SayHi);
            //sayHi();
            //dell.Invoke();

            //MyDelegate dell1 = new MyDelegate(SayHi);
            //dell1.Invoke("dotnet");

            AnnualFunc func = new AnnualFunc();
            MyDelegate del = new MyDelegate(func.Func1);
            del += func.Func2;
            del += func.Func3;

            Console.WriteLine("Should we proceed for party");
            bool isProceed = Convert.ToBoolean(Console.ReadLine());
            if (isProceed)
            {
                del -= func.Func3;
            }
            del();
            Console.WriteLine("10 days later ");
            MyDelegate delq = new MyDelegate(func.Func4);
            delq();

            MyDelegate3 delObj = new MyDelegate3(func.Func5);
            string msg = delObj();
            Console.WriteLine(msg);
        }
        public void sayHi()
        {
            Console.WriteLine("Hello !");
        }

        //Overloading
        public void sayHi(String str)
        {
            Console.WriteLine("hello  {0}",str);
        }

        public class AnnualFunc
        {
            public void Func1()
            {
                Console.WriteLine("wELCOME Speech");        
            }
            public void Func2()
            {
                Console.WriteLine("guest speech");
            }
            public void Func3()
            {
                Console.WriteLine("party time");
            }
            public void Func4()
            {
                Console.WriteLine("pack up");
            }
            public string Func5()
            {
               return "THE END";
            }
        }
    }
}
