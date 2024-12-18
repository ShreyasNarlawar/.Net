namespace _13Events
{
    public delegate void ResultDelegate(int i);
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            ResultDelegate resultpass = new ResultDelegate(s.OnSucess);
            s.Pass += resultpass;
            ResultDelegate resultfail = new ResultDelegate(s.OnFail);
            s.Fail += resultfail;
            Console.WriteLine("Enter marks of student");
            s.marks = Convert.ToInt32(Console.ReadLine());
        }
    }
    public class Student
    {
        public event ResultDelegate Pass;
         public event ResultDelegate Fail;
         
        private int _marks;

         public int marks
         {
            set 
            {
               _marks = value;
               if(_marks > 20)
               {
                  Pass(_marks);
               }
               else
               {
                  Fail(_marks);
               }
            }
            get
            {
               return _marks;
            }
         }
         public void OnSucess(int marks)
         {
            Console.WriteLine("cONgratulations you passed successfully with {0} marks",marks);
         }
         public void OnFail(int marks)
         {
            Console.WriteLine("SADLY you failed successfully with {0} marks",marks);
         }
    }
}
