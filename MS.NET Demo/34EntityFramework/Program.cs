using _34EntityFramework.DAL;
using _34EntityFramework.Model;

namespace _34EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpDbContext db = new EmpDbContext();
            while (true)
            {
                Console.WriteLine("\t\tMenu\n1.Show  Employees\n2.Insert\n3.Update\n4.Delete\n" +
                         "5.Search Emp by Id\n6.Find By Address (Enter start letter)\n\n\tEnter");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var allEmps = db.employees.ToList();
                        foreach (var emp in allEmps)
                        {
                            Console.WriteLine($"Id:{emp.Id},Name:{emp.Name},Address:{emp.Address}");
                        }
                        break;

                    case 2:
                        Employee empDataToBeInserted = new Employee();
                        Console.WriteLine("Enter Name :");
                        empDataToBeInserted.Name = Console.ReadLine();

                        Console.WriteLine("Enter Address :");
                        empDataToBeInserted.Address = Console.ReadLine();

                        db.employees.Add(empDataToBeInserted);
                        db.SaveChanges();
                        break;

                    case 3:
                        Console.WriteLine("Enter Id :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee empDataToBeUpdated = db.employees.Find(id);
                        Console.WriteLine("Enter New Name :");
                        empDataToBeUpdated.Name = Console.ReadLine();
                        Console.WriteLine("Enter New Address :");
                        empDataToBeUpdated.Address = Console.ReadLine();
                        db.SaveChanges();
                        break;

                    case 4:
                        Console.WriteLine("Enter Id :");
                        id = Convert.ToInt32(Console.ReadLine());
                        Employee deleteById = db.employees.Find(id);
                        db.employees.Remove(deleteById);
                        db.SaveChanges();
                        break;

                    case 5:
                        Console.WriteLine("Enter Employee Id to Search :");
                        int idToSearch = Convert.ToInt32(Console.ReadLine());
                        Employee searchById = db.GetEmployeesById(idToSearch);
                        Console.WriteLine($"Id: {searchById.Id},Name: {searchById.Name},Address: {searchById.Address}");
                        break;

                    case 6:
                        Console.WriteLine("Enter Address first letter to search :");
                        string? addfind = Console.ReadLine().ToUpper();
                        db.GetEmployeesByAddressStartsWith(addfind);
                        foreach (Employee emp in db.employees)
                            Console.WriteLine($"Id :{emp.Id},Name :{emp.Name},Address :{emp.Address}");
                        break;

                    default:
                        Console.WriteLine("Invalid Credentials..");
                        break;
                }
                Console.WriteLine("Do you want to Continue (y/n)");
                string yorn = Console.ReadLine();
                if (yorn == "n")
                    break;
            }
        }
    }
}
