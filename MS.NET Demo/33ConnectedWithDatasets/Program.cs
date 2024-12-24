using Microsoft.Data.SqlClient;
using System.Data;

namespace _33ConnectedWithDatasets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=MYAllCodesDB;Integrated Security=True;";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("Id",typeof(int));
            DataColumn col2 = new DataColumn("Name",typeof(string));
            DataColumn col3 = new DataColumn("Address",typeof(string));
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.PrimaryKey = new DataColumn[]{col1};

            //Using COnnected Architecture  - fetch the records
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("select * from Emp",con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                DataRow dr = dt.NewRow();
                dr["Id"]=Convert.ToInt32(reader["Id"]);
                dr["Name"] = reader["Name"].ToString();
                dr["Address"] = reader["Address"].ToString();
                dt.Rows.Add(dr);
            }
            con.Close();
            ds.Tables.Add(dt);
            ds.WriteXml(@"D:\Shreyas\MS.NET\MS.NET Demo\33ConnectedWithDatasets\Data\EmpData.xml");


        }

    }
}
