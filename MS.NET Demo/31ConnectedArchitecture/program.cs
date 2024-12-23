using Microsoft.Data.SqlClient;
using _31ConnectedArchitecture.Model;
using _31ConnectedArchitecture.DAL;
namespace _31ConnectedArchitecture
{
    internal class program
    {
        static void Main(string[] args)
        {
            #region CRUD with COnsole.WriteLine
            #region select Records
            //string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=MYAllCodesDB;Integrated Security=True;";
            //SqlConnection con = new SqlConnection(conStr);
            //string query = "select * from Emp";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int id = Convert.ToInt32(reader[0]);
            //    string? name = reader[1].ToString();
            //    string? address = reader[2].ToString();
            //    Console.WriteLine($"Id: {id}, Name:{name}, Address: {address}");
            //}
            //con.Close();
            #endregion
            #region Insert Records
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter Name: ");
            //string? nm = Console.ReadLine();
            //Console.WriteLine("Enter Address: ");
            //string? add = Console.ReadLine();
            //string query = $"insert into Emp values('{nm}','{add}')";
            //SqlCommand cmd = new SqlCommand(query,con);
            //con.Open();
            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //con.Close();
            //if (noOfRowsAffected > 0)
            //    Console.WriteLine("Record Inserted successfully.");
            //else
            //    Console.WriteLine("error");
            #endregion
            #region Update Records
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter Id to Update :");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter new Name :");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Enter new Address");
            //string? add = Console.ReadLine();
            //string query = $"update Emp set Name = '{name}',Address = '{add}' where Id = '{id}' ";
            //SqlCommand cmd = new SqlCommand(query,con);
            //con.Open();
            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //con.Close();
            //if (noOfRowsAffected > 0)
            //    Console.WriteLine(noOfRowsAffected + " Record updated successfully");
            //else
            //    Console.WriteLine("Error occured");
            #endregion
            #region Delete Records
            //SqlConnection con = new SqlConnection(conStr);
            //Console.WriteLine("Enter Id to Delete :");
            //int id=Convert.ToInt32(Console.ReadLine());
            //string query = $" Delete from emp where id={id}";
            //SqlCommand cmd = new SqlCommand(query, con);
            //con.Open();
            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //con.Close();
            //if (noOfRowsAffected > 0)
            //    Console.WriteLine(noOfRowsAffected + " Rows Deleted Successfully");
            //else
            //    Console.WriteLine("Errror no id found.");
            #endregion
            #endregion
            //Business Presentation UI
            while (true)
            {
                MyDBContext db = new MyDBContext();
                int noOfRowsAffected = 0;
                Console.WriteLine("\t\tOperations\n1.Display All Employees\n2.Add new Employee \n3.Update Employee Data\n4.Delete Employee\n\tEnter Choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        List<Emp> allEmp = db.SelectRecords();
                        foreach (var emp in allEmp)
                            Console.WriteLine($"Id = {emp.Id},Name = {emp.Name},Address = {emp.Address}");
                        break;
                    
                    case 2:
                        Emp empToBeInserted = new Emp();
                        Console.WriteLine("Enter Emp Name :");
                        empToBeInserted.Name = Console.ReadLine();
                        Console.WriteLine("Enter Emp Address :");
                        empToBeInserted.Address = Console.ReadLine();
                        noOfRowsAffected = db.InsertRecord(empToBeInserted);
                        if (noOfRowsAffected > 0)
                            Console.WriteLine("Employee Added Successfully.");
                        else
                            Console.WriteLine("Emp not Added");
                        break;
                    
                    case 3:
                        Emp empToBeUpdated = new Emp();
                        Console.WriteLine("Enter Id to Update: ");
                        empToBeUpdated.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Emp new Name: ");
                        empToBeUpdated.Name = Console.ReadLine();
                        Console.WriteLine("Enter Emp new Address: ");
                        empToBeUpdated.Address = Console.ReadLine();
                        noOfRowsAffected = db.UpdateRecord(empToBeUpdated);
                        if (noOfRowsAffected > 0)
                            Console.WriteLine("Employee Details Updated Successfully.");
                        else
                            Console.WriteLine("Emp not found..");
                        break;
                    
                    case 4:
                        Emp empToBeDeleted = new Emp();
                        Console.WriteLine("Enter Id to Delete: ");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        noOfRowsAffected = db.DeleteRecord(Id);
                        if (noOfRowsAffected > 0)
                            Console.WriteLine("Employee Deleted Successfully.");
                        else
                            Console.WriteLine("Employee not found.");
                        break;
             
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
                Console.WriteLine("Do you wannna Continue (y/n):");
                string yorn = Console.ReadLine();
                if (yorn == "n")
                    break;
            }
        }
    }
}
