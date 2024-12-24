using Microsoft.Data.SqlClient;
using System.Data;

namespace _32DisconnectedArch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MYAllCodesDB;Integrated Security=True;";
            #region Select Query using Disconnected Architecture
            //SqlConnection con = new SqlConnection(conStr);
            //string selectQuery = "select * from Emp";
            //SqlDataAdapter da = new SqlDataAdapter(selectQuery, con);
            //da.MissingSchemaAction = MissingSchemaAction.Add;
            //SqlCommandBuilder builder = new SqlCommandBuilder(da);

            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //foreach (DataRow drow in dt.Rows)
            //{
            //    Console.WriteLine($"Id{drow["Id"]},  Name :{drow["Name"]},  Address :{drow["Address"]}");
            //}
            #endregion
            #region Insert Query using Disconnected Architecture
            //Console.WriteLine("Enter Name :");
            //string nm = Console.ReadLine();
            //Console.WriteLine("Enter Address :");
            //string add = Console.ReadLine();
            //DataRow dr = dt.NewRow();
            //dr["Name"] = nm;
            //dr["Address"] = add;
            //dt.Rows.Add(dr);
            //da.Update(dt);
            #endregion
            #region Update Query using Disconnected Architecture
            //Console.WriteLine("Enter ID: ");
            //int Id = Convert.ToInt32(Console.ReadLine());
            //DataRow emptoBeEdited = dt.Rows.Find(Id);
            //Console.WriteLine("Enter Name: ");
            //emptoBeEdited["Name"] = Console.ReadLine();
            //Console.WriteLine("Enter Address: ");
            //emptoBeEdited["Address"] = Console.ReadLine();
            //da.Update(dt);
            #endregion
            #region Delete Query using Disconnected Architecture
            //Console.WriteLine("Enter ID :");
            //int id = Convert.ToInt32(Console.ReadLine());
            //DataRow? empToBeDeleted = dt.Rows.Find(id);
            ////dt.Rows.Remove(empToBeDeleted);
            //empToBeDeleted.Delete();
            //da.Update(dt);
            #endregion
        }
    }
}
