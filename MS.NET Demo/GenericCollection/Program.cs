
using System.Reflection.Metadata.Ecma335;

namespace _15GenericCollection
{
    public delegate R MyDelegate<T1, R>(T1 para1);
    public delegate R MyDelegate<T1, T2, R>(T1 para1, T2 para2);
    public class Program
    {
        static void Main(string[] args)
        {
            #region Pass by ref , pass by value and out parameter 
            CMath obj = new CMath();
            //int p = 20;
            //int q = 10;
            //Console.WriteLine("Before Swap : p={0},Q={1}", p, q);
            //obj.swap(p, q);
            ////obj.swap(ref p, ref q);
            //Console.WriteLine("After Swap  : p={0},Q={1}", p, q);

            //int sum, prod;
            //obj.Calculate(p, q, out sum, out prod);
            //Console.WriteLine($"Sum :{sum},Product :{prod}");
            #endregion

            #region Generic Class , Dynamic Type
            //CMath<int> obj = new CMath<int>();
            //int p = 20, q = 30;

            //Console.WriteLine("Before Swap p ={0},q={1}", p, q);
            //obj.Swap(ref p, ref q);
            //Console.WriteLine("After Swap p={0},q={1}", p, q);
            //Console.WriteLine("-----------------------------------");
            //string s1 = "abc", s2 = "pqr";
            //Console.WriteLine("Before Swap : s1={0} , s2={1}", s1, s2);
            //obj.Swap(ref s1, ref s2);
            //Console.WriteLine("After Swap  : s1={0} , s2={1}", s1, s2);
            #endregion
            #region generic methods <>
            //Console.WriteLine("Before Swap P={0} , q={1}", p, q);
            //obj.Swap<int>(ref p, ref q);
            //Console.WriteLine("After  Swap P={0} , q={1}", p, q);
            //Console.WriteLine("-------------------------------------");
            //string s1 = "Hello", s2 = "world";
            //Console.WriteLine("Before Swap : s1={0} , s2={1}", s1, s2);
            //obj.Swap<String>(ref s1, ref s2);
            //Console.WriteLine("After Swap : s1={0} , s2={1}", s1, s2);
            #endregion

            #region
            //int sum, prod;
            //obj.Calculate(2, 3, out sum, out prod);
            //Console.WriteLine($"Sum:{sum},Product:{prod}");
            #endregion

            #region Generic Multiple Parameters
            //Demo<int, String, double, bool> demoObj = new Demo<int, String, double, bool>();
            //double d = demoObj.Display(100, "Some nonsense Parameter", 23.333, true);
            //Console.WriteLine("R is Holding value :{0}", d);
            #endregion
        }
    }
}
public class CMath
{
    public void Calculate(int v1, int v2, out int sum, out int prod)
    {
        dynamic para1 = v1;
        dynamic para2 = v2;

        sum = para1 + para2;
        prod = para2 * para1;
    }

    public void swap(int p, int q)
    {
        int temp = p;
        p = q;
        q = temp;
    }

    public class Demo<P, Q, R, T>
    {
        public R Display(P p1, Q p2, R p3, T p4)
        {
            return p3;
        }
    }
    public class Test<T1, T2, T3, T4>
    {
        public T3 Display(T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return p3;
        }
    }
}
public class CMath<T> {
    public void Swap(ref T p, ref T q)
    {
        T temp = p;
        p = q;
        q = temp;
    }
    public void swap(ref String p, ref String q)
    {
        String temp = p;
        p = q;
        q = temp;
    }
    public void Calculate(T v1, T v2, out T sum, out T prod)
    {
        dynamic para1 = v1;
        dynamic para2 = v2;

        sum = para1 + para2;
        prod = para2 * para1;
    }
}