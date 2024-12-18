
using _27DBAttributeLib;
namespace _26EmpLib
{
    [Table(TableName = "Employee")]
    public class Emp
    {
        private int _id;
        private string _name;
        private string _address;

        [Column(ColumnName = "EId", ColumnType = "int")]
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Column(ColumnName = "Ename", ColumnType = "varchar(30)")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }


        [Column(ColumnName = "Eaddress", ColumnType = "varchar(40)")]
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

    }
}
