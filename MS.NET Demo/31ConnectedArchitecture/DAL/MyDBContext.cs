using _31ConnectedArchitecture.Model;
using Microsoft.Data.SqlClient;

namespace _31ConnectedArchitecture.DAL
{
    //Business Logic
    public class MyDBContext
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=My_AllCodesDB;Integrated Security=True;";
        List<Emp> emps = new List<Emp>();
        public List<Emp> SelectRecords()
        {
            SqlConnection con = new SqlConnection(conStr);
            string selectQuery = "select * from emp";
            SqlCommand cmd = new SqlCommand(selectQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                emps.Add(new Emp()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"].ToString()
                });
            }
            con.Close();
            return emps;
        }   
        public int InsertRecord(Emp emp)
        {
            SqlConnection conn = new SqlConnection(conStr);
            string insertQuery = "insert into emp values('{emp.Name}',  '{emp.Address}')";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowAffected;
        }

    }
}
