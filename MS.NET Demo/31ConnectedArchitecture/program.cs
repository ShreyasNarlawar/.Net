using Microsoft.Data.SqlClient;
using _31ConnectedArchitecture.DAL;
namespace _31ConnectedArchitecture
{
    internal class program
    {
        static void Main(string[] args)
        {
            #region CRUD with COnsole.WriteLine
            #region select Records
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=My_AllCodesDB;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conStr);
            string query = "select * from Emp";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader[0]);
                string? name = reader[1].ToString();
                string? address = reader[2].ToString();
                Console.WriteLine($"Id: {id}, Name:{name}, Address: {address}");
            }
            con.Close();
            #endregion
            #endregion
        }
    }
}
