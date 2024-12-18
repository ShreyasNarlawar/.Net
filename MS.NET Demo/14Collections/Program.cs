using System.Collections;

namespace _14Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collections

            //1) Arrays :
            #region int []
            int[] arr = new int[5];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion

            #region string []
            string[] arr2 = new string[2];
            arr2[0] = "any";
            arr2[1] = "thing";

            foreach (string str in arr2)
            {
                Console.WriteLine(str);
            }
            #endregion

            #region Employee Object []
            Emp emp1 = new Emp();
            emp1.eid = 1;
            emp1.ename = "hello";
            emp1.eaddress = "pune";

            Emp emp2 = new Emp();
            emp2.eid = 2;
            emp2.ename = "everyone";
            emp2.eaddress = "mumbai";

            Emp[] empArr = new Emp[2];
            empArr[0] = emp1;
            empArr[1] = emp2;

            foreach (Emp emp in empArr)
            {
                string result = string.Format("Id = {0} , Name = {1}, Address = {2}", emp.eid, emp.ename, emp.eaddress);
                Console.WriteLine(result);
            }
        }
        #endregion

            // 2) ArrayList :

            //ArrayList arr = new ArrayList();
            //    arr.Add(100);
            //    arr.Add(230);
            //    arr.Add("hello");
            //    arr.Add(432.453);

            //    foreach (Object item in arr)
            //    {
            //        if(item is int)
            //        {
            //            int i = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
        public class Emp
        {
            private int _eid;
            private string _ename;
            private string _eaddress;

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
                    return _ename;
                }
            }
            public string eaddress
            {
                set
                {
                    _eaddress = value;
                }
                get
                {
                    return _eaddress;
                }
            }
        }
    }
}
