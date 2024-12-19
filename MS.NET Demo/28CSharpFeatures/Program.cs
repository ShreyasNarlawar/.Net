using System;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace _28CSharpFeatures
{
    public delegate bool MyDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Partial Classes 
            //CMath obj = new CMath();
            //Console.WriteLine($"Add ={obj.Add(10, 20)} ");
            //Console.WriteLine($"Sub ={obj.Sub(10, 20)} ");
            //obj.SayHi();
            #endregion
            #region Nullable Types
            //int? i = null;
            //Nullable<int> i = 10;
            //if (i.HasValue)
            //{
            //    Console.WriteLine($"Value of i = {i}");
            //}
            //else
            //{
            //    Console.WriteLine("value of i = null");
            //}
            //if (i == null)
            //{
            //Console.WriteLine("Value of i = null");
            //}
            //Employee emp = new Employee();
            //emp.id = 420;
            //emp.name = "Don";
            //emp.sal = 4646445741.12;
            //emp.dep = "UnderCover Agent";
            #endregion
            #region Anonymous Methods
            //Normal call to a Method
            //Console.WriteLine("Enter a Value :");
            //int input = Convert.ToInt32(Console.ReadLine());
            //bool res = Check(input);
            //Console.WriteLine($"{input} is greater than 10 = {res}");

            //Delegate call to a Method
            //Console.WriteLine("Enter a Value :");
            //int input1 = Convert.ToInt32(Console.ReadLine());
            //MyDelegate del = new MyDelegate(Check);
            //bool res1 = Check(input1);
            //Console.WriteLine($"{input1}is greater than 10 = {res1}");

            // again Delegate call to a Method
            //Console.WriteLine("Enter a value :");
            //int input = Convert.ToInt32(Console.ReadLine());

            //The method which don't have method name-Anonymous Method
            //    MyDelegate del = delegate(int i)
            //    {
            //        return i > 10;
            //    };
            //bool res = del(input);
            //Console.WriteLine($"{input}is greater than 10 = {res}");
            #endregion
            #region Lambda Expression
            //Console.WriteLine("Enter the Value :");
            //int input = Convert.ToInt32(Console.ReadLine());
            ////MyDelegate del = (i) =>
            ////{
            ////    return i > 10;
            ////};
            ////MyDelegate del = (i) => { return i > 10; };
            //MyDelegate del = i => i > 10;

            //bool res = del(input);
            //Console.WriteLine($"{input}is greater than 10 = {res} from lambda");
            #endregion
            #region Predicate Delegate
            //in build delegate
            //public delegate bool MyDelegate(int x);
            //public delegate bool Predicate<in T>(T obj);
            //Console.WriteLine("Enter a Value : ");
            //int input = Convert.ToInt32(Console.ReadLine);
            //Predicate<int> pointer = i => i > 10;
            //bool res = Pointer(input);
            //Console.WriteLine($"{input} is greater than 10  = {res}");
            #endregion
            #region Iterator
            //int[] arr = new int[5];
            ////ArrayList arr = new ArrayList();
            //foreach (var item in arr)
            //{

            //}
            //Weeks ws = new Weeks();
            //foreach (string day in ws)
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Implicit Type
            //int i = 10;
            ////var i = 10;//defination of var
            //Employee emp = new Employee();
            //var e1 = emp;
            //var e2 = new Object();
            //var e3 = 342.41;

            //Console.WriteLine("Enter a number :");
            //var choice = Convert.ToInt32(Console.ReadLine());
            //var res = GetMeSomething(choice);
            //if (res is int)
            //    Console.WriteLine("result is of type{0}", res.GetType().ToString());

            //if (res is Employee)
            //    Console.WriteLine("result is of type{0}", res.GetType().ToString());
            #endregion
            #region Object Initializer
            #region Constructor Overriding
            //Customer c1 = new Customer();
            //Console.WriteLine($"{c1.cid}");
            //Console.WriteLine($"{c1.name}");

            //Customer c2 = new Customer("shree", "Pune");
            //Console.WriteLine($"{c2.name}");
            //Console.WriteLine($"{c2.address}");
            #endregion
            //Customer cust = new Customer() { name="Akshit",address="shimla"};
            //Console.WriteLine($"{cust.name},{cust.address}");

            //Customer cust2 = new Customer() { name = "Akshay", address = "Mysore",cid=45 };
            //Console.WriteLine($"{cust2.name},{cust2.address},{cust2.cid}");
            #endregion
            #region Auto-Properties
            //Student s1 = new Student();
            //s1.sname = "yash";
            //s1.saddress = "Pune";
            //Console.WriteLine($"{s1.sid},{s1.sname},{s1.saddress}");
            //Student s2 = new Student() { sid = 1, sname = "abc", saddress = "mumbai" };
            #endregion
            #region Anonymous Type
            ////Employee v = new Employee();
            //var v = new Employee(){ id=41,name="salsaa",sal=6545.41,dep="dance"};
            //Console.WriteLine(v.GetType().ToString());

            //var v1 = new Student() { sid = 11, sname = "shreyas", saddress = "Nanded" };
            //Console.WriteLine(v1.GetType().ToString());

            //var v2 = new { sid = 10, Sname = "Pravin", saddress = "Pune" };
            //Console.WriteLine(v2.GetType().ToString());

            //object v3 = new { sname = "Rohit", saddress = "Mumbai" };
            //Console.WriteLine(v3.GetType().ToString());

            //DoSomething(v2);
            #endregion
            #region Extension Methods
            //int[] arr = { 1, 2, 65463, 4, 5 };
            //Console.WriteLine(arr.Max());

            //List<int> lst = arr.MyArrayToList();
            //foreach (int x in lst)
            //{
            //    Console.WriteLine(x);
            //}
            //string emailstr = "hello@gmail.com";
            //bool res = MyClass.checkforValidEmail(emailstr);
            //if (res)
            //    Console.WriteLine("Login SucessFully");
            //else
            //    Console.WriteLine("Invalid Gmail");
            #endregion
        }

        private static void DoSomething(object v3)
        {
            Console.WriteLine(v3.GetType().ToString());
        }

        public static Object GetMeSomething(int choice)
        {
            if (choice > 10)
                return choice * 10;
            else
                return new Employee();
        }
        private static bool Check(int input)
        {
            return input > 10;
        }
    }

    internal class Employee
    {
        private int _id;
        private string _name;
        //private double?  _sal;
        private Nullable<double> _sal;
        private string _dep;

        public string dep
        {
            get { return _dep; }
            set { _dep = value; }
        }

        public double? sal
        {
            get { return _sal; }
            set { _sal = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
    public class Customer
    {
        private int _cid;
        private string _name;
        private string _address;

        public Customer()
        {
            this.cid = 10;
            this.name = "Billa";
            this.address = "Pune";
        }

        public Customer(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int cid
        {
            get { return _cid; }
            set { _cid = value; }
        }
    }

    internal class Student
    {
        internal string sname { get; set; }
        internal string saddress { get; set; }
        internal int sid { get; set; }


    }
    public class Weeks : IEnumerable
        {
            private String[] days = new String[]
            {"Monday","Tuesday","Wednesday","Thursday","Friday","Funday"};
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < days.Length; i++)
                {
                    string day = days[i];
                    yield return day;
                }
        }
    }
    public static class MyClass
    {
        public static List<int> MyArrayToList(this int[] param)
        {
            List<int> lst = new List<int>();
            foreach (int x in param)
            {
                lst.Add(x);
            }
            return lst;
        }
        public static bool checkforValidEmail(this string str)
        {
            return str.Contains("@")? true: false;
        }
    }
}

