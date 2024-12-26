using System.Diagnostics;

namespace _36Threading_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Normal Method Call -->Time Taken : 45 ms.
            Stopwatch sw = new Stopwatch();
            //     sw.Start();
            //     for (int i = 0; i < 100; i++)
            //         DoSomethingWork();
            //sw.Stop();
            //     Console.WriteLine("Time Taken : {0} ms.",sw.ElapsedMilliseconds);
            #endregion
            #region Thread -->Time Taken : 272 ms.
            //sw.Start();
            //for(int i = 0; i < 100; i++)
            //{
            //    Thread t1 = new Thread(new ThreadStart(DoSomethingWork));
            //    t1.Start();
            //    Console.WriteLine("Currrent Thread ID :{0}",Thread.CurrentThread.ManagedThreadId);
            //    sw.Stop();
            //}
            //    Console.WriteLine("Time Taken : {0} ms.",sw.ElapsedMilliseconds);
            #endregion
            #region Explicit Parallel Programming - Multiple Tasks --> Time Taken : 9 ms.
            //sw.Start();
            //for (int i = 0; i < 100; i++)
            //{
            //    Task t1 = new Task(new Action(DoSomethingWork));
            //    t1.Start();
            //    Console.WriteLine("Current Task Id :{0}",t1.Id.ToString());
            //    sw.Stop();
            //}
            //Console.WriteLine("Time Taken : {0} ms.",sw.ElapsedMilliseconds);
            #endregion
            #region Parallel.foreach  -  Implicit Parallel Programming --> Time Taken : 322 ms.
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //sw.Start();
            //Parallel.ForEach(arr, (number) =>
            //{
            //    Console.WriteLine($"Number:{number},Task ID :{Task.CurrentId},Thread ID :{Thread.CurrentThread.ManagedThreadId}");
            //    sw.Stop();
            //});
            #endregion
            #region MaxDegree of Parallelism --> Time Taken : 38 ms.
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var options  = new ParallelOptions { MaxDegreeOfParallelism = 2 };               
            //sw.Start();
            //Parallel.ForEach(arr,options, (number) =>
            //{
            //    Console.WriteLine($"Number:{number},Task ID :{Task.CurrentId},Thread ID :{Thread.CurrentThread.ManagedThreadId}");
            //    sw.Stop();
            //});
            //Console.WriteLine("Time Taken : {0} ms.",sw.ElapsedMilliseconds);
            #endregion
            #region Exception Handling using Parallel Foreach
            //var numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            //try
            //{
            //    Parallel.ForEach(numbers, number =>
            //    {
            //        Console.WriteLine($"Number = {number},Task Id = {Task.CurrentId}");
            //        if (number == 5)
            //            throw new Exception("Simulated Exception");
            //    });
            //}
            //catch (AggregateException e)
            //{
            //    foreach(var innerExp in e.InnerExceptions)
            //        Console.WriteLine(innerExp.Message);
            //}
            //    Console.WriteLine("parallel for each with exception handling is completed.");
            #endregion
            #region Parallel LinQ

            List<Emp> allEmployees = new List<Emp>()
            {
                 new Emp(){ ID = 1,Name = "Ganesha",Address="pune" },
                 new Emp(){ ID =12,Name ="Prathamesh", Address ="Nashik"},
                 new Emp(){ ID =13,Name ="Devendra", Address ="Nagpur"},
                 new Emp(){ ID =14,Name ="Kalpesh", Address ="Kerla"},
                 new Emp(){ ID =15,Name ="kushendra", Address ="Indore"}
            };
            var result = (from emp in allEmployees.AsParallel() where emp.Address.StartsWith("N")select emp).ToList();
            foreach (var emp in result)
                Console.WriteLine($"Name={emp.Name},Address={emp.Address}");
            #endregion
            #region Task , Async , Await
            Console.WriteLine("Fetching........");
            var res = FetchDataAsync().GetAwaiter().GetResult();
            Console.WriteLine($"Data Fetched : {res}");
            #endregion
        }

        static async Task<string> FetchDataAsync()
        {
            await Task.Delay(2000);
            return "Hello ! Sab log";
        }

        private static void DoSomethingWork()
        {
            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < 100; j++)
                { //nothing here
                } 
                    
        }
    }
    internal class Emp
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public string Address { get; internal set; }
    }
}
