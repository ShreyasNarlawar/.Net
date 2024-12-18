namespace _22_CompanyInfoLib
{
    internal class Program
    {
        [Serializable]
        [Company(CompayName ="FISPL" , DeveloperName = "")]
       public class Demo
        {
            public void sayHi()
            {
                Console.WriteLine("in Hi method Hello");
            }
        }
    }
}
