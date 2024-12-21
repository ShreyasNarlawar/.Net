namespace _29LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> employees = new List<Emp>()
            {
                 new Emp(){Id=11,Name="Chintu",Address="Hydrabad"},
                 new Emp(){Id=12,Name="Mintu",Address="Telangana"},
                 new Emp(){Id=13,Name="Pintu",Address="Singapore"},
                 new Emp(){Id=14,Name="Tittu",Address="Malesia"},
                 new Emp(){Id=15,Name="Ganajan",Address="Meghalaya"},
                 new Emp(){Id=16,Name="Appa",Address="Amritsar"},
                 new Emp(){Id=17,Name="Mahesh",Address="Goa"},
                 new Emp(){Id=18,Name="Siddhant",Address="Bangaluru"},
                 new Emp(){Id=19,Name="Yogesh",Address="Mysore"},
                 new Emp(){Id=20,Name="Pratik",Address="Pune"},
                 new Emp(){Id=21,Name="Yash",Address="Kashmir"},
                 new Emp(){Id=22,Name="Aliaa",Address="Kanyakumari"},
            };
            #region Normal Condition Based on filteration and loops from a collection
            //Console.WriteLine("Enter name of city :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = new List<Emp>();
            //foreach (Emp emp in employees)
            //{
            //    if(emp.Address.ToLower()==city.ToLower())
            //        FilteredCollection.Add(emp);
            //}
            //foreach (Emp emp in FilteredCollection)
            //    Console.WriteLine($"Id={emp.Id},Name={emp.Name},Address={emp.Address}");          
            #endregion
            #region LinQ Query
            //Console.WriteLine("Enter name of City :");
            //string city = Console.ReadLine();
            ////IEnumerable<Emp>FilteredCollection = (from emp in employees
            ////                                      where emp.Address.ToLower()==city.ToLower()
            ////                                      select emp);
            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp);
            //foreach( Emp emp in FilteredCollection)
            //{
            //    Console.WriteLine($"Id={emp.Id},Name={emp.Name},Address={emp.Address}");
            //}
            #endregion
            #region LinQ Filteration
            //Console.WriteLine("Enter Name of the City :");
            //string? city = Console.ReadLine();
            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp).ToList();
            ////Toshow All the Employees which have same city then donot use ToList()
            ////var FilteredCollection = (from emp in employees
            ////                          where emp.Address.ToLower() == city.ToLower()
            ////                          select emp);

            //employees.Add(new Emp() { Id = 101, Name = "Amit", Address = "pune" });
            //employees.Add(new Emp() { Id = 102, Name = "Sanju", Address = "pune" });
            //Console.WriteLine("_____________________________________________");
            //Console.WriteLine("Filtered Collection Based on the {0} city \n", city);
            //foreach (Emp emp in FilteredCollection)
            //    Console.WriteLine($"Id={emp.Id},Name={emp.Name},Address={emp.Address}");

            #endregion
            #region LinQ Filteration Based on city and name of Emp
            //Console.WriteLine("Enter the Name of City :");
            //string? city = Console.ReadLine();
            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select emp.Name).ToList();
            //Console.WriteLine("______________________________________________________");
            //Console.WriteLine("Filtered Collection based on the {0} city:\n", city);
            //foreach (var name in FilteredCollection)
            //{
            //    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //    Console.WriteLine($"Name = {name}");
            //}
            //foreach (Emp emp in FilteredCollection)
            //{
            //    //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");
            //    Console.WriteLine($"Name = {emp.Name}, Address = {emp.Address}");
            //}

            #endregion
            #region LinQ Filteration Based on the multiple return values using the Holder Class
            //Console.WriteLine("Enter the name of city :");
            //string? city = Console.ReadLine();
            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select new Holder() { HName = emp.Name, HAddress = emp.Address }).ToList();
            ////Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("Filtered Collection based on the {0} city:\n",city);

            //foreach (var emp in employees)
            //{
            //    List<Holder> objlist = new List<Holder>();
            //    objlist.Add(new Holder() { HName = emp.Name, HAddress = emp.Address });
            //}
            //foreach(Holder obj in FilteredCollection) {
            //    //Console.WriteLine($"Id={emp.Id},Name={emp.Name},Address={emp.Address}");
            //    Console.WriteLine($"Name={obj.HName},Address={obj.HAddress}");

            //}
            #endregion
            #region LinQ Filteration Based on the Anonymous Type
            //Console.WriteLine("Enter Name of the City :");
            //string? city = Console.ReadLine();

            //var FilteredCollection = (from emp in employees
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select new {nm = emp.Name , add=emp.Address }).ToList();
            //foreach(var obj in FilteredCollection)
            //{
            //    //Console.WriteLine($"Id={emp.Id},Name={emp.Name},Address={emp.Address}");
            //    Console.WriteLine($"Name={obj.nm},Address={obj.add}");
            //}
            #endregion
        }
        public class Emp
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
    }

    internal class Holder
    {
        public int HId { get; set; }
        public string HName { get; set; }
        public string HAddress { get; set; }
    }
}
