namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cMath cmath = new cMath();
            //Console.WriteLine("Enter num1");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter num2");
            //int y = Convert.ToInt32(Console.ReadLine());
            //int result = cmath.Multi(x, y);
            //Console.WriteLine("Multiplication is " + result.ToString());

            AdvMath adv = new AdvMath(12,14);
            Console.WriteLine(adv.Formula_1(2, 4, 6));


        }

        public class Demo1
        {
            public virtual void Hello()
            {
                Console.WriteLine("Hello");
            }
            public virtual void bye()
            {
                Console.WriteLine("Bye");
            }
        }

        public class Demo2 : Demo1
        {
            public override void Hello()
            {
                Console.WriteLine("Hi, .NET");
            }
            //Shadowing

            public new void bye()
            {
                Console.WriteLine("Good Bye");
            }
        }

        public class cMath
        {
            private int _num1;

            // default constructor
            public cMath()
            {

            }
            //Parameterized constructor
            public cMath(int num1)
            {
                _num1 = num1;
            }
            //Methods
            public int Multi(int x,int y)
            {
                return x * y;
            }
            public int div(int a, int b)
            {
                return a / b;
            }
        }
        //Inheritance
        public class AdvMath : cMath
        {
            private int num2;
            public AdvMath(int num2, int para) : base(para)
            {
                this.num2 = num2;
            }
            public int Formula_1(int a, int b, int p)
            {
                return (a + b) - p;
            }
            public virtual void hello()
            {
                Console.WriteLine("Hello");
            }
        }
        public class ThisClass : AdvMath
        {
            public ThisClass(int num2, int para) : base(num2, para)
            {
            }

            public override void hello()
            {
                Console.WriteLine("Hi");
            }
        }
    }
}
