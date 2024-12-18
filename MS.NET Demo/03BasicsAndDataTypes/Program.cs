namespace BasicsAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region boxing ,unboxing and typecasting
            int a = 87;
            bool istrue = false;

            //reference type
            string str = "abc";
            //String str1 = new String();
            str = a.ToString();

            int y = Convert.ToInt32(str);

            int n = a;

            double d = 132.435;

            a = Convert.ToInt32(d);

            Object ob = new Object();
            ob = a;
            ob = str;
            ob = d;

            double d1 = Convert.ToDouble(ob);

            #endregion


            #region if else

            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 10)
                Console.WriteLine("number is greater than 10");
            else if (num < 50)
                Console.WriteLine("number is less than 50");
            else
                Console.WriteLine("wrong choice");
            #endregion

            //for loop
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }

            //Exception Handling
            try
            {
                Console.WriteLine("Enter the num1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if(num1 > 20)
                {
                    Console.WriteLine("number is greater than 20");
                }
                Console.WriteLine("Enter another num");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int res = num1 * num2;

                Console.WriteLine("the multiplication is" + res);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("IN Finally block");
            }

        }
    }
}