using _22CompanyInfoLib;
using System.Reflection;

namespace _24CompanyInfoLib

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblypath = @"D:\Shreyas\MS.NET\MS.NET Demo\23DemoLibr\bin\Debug\net6.0\22CompanyInfoLib.dll";
            Assembly asm = Assembly.LoadFrom(assemblypath);
            Type[] types = asm.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];

                Attribute [] allAttribute = type.GetCustomAttributes().ToArray();

                for (int j = 0; j < allAttribute.Length; j++)
                {
                    Attribute attr = allAttribute[j];

                    if(attr is Company)
                    {
                        Company compref = attr as Company;
                        Console.WriteLine("Type {0} belongs to {1} company is developed by {2} developer",
                            type.FullName, compref.CompanyName, compref.DeveloperName);
                    }
                }
            }
        }
    }
}
