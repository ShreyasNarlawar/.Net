namespace _16GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List<>
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            foreach(int item in lst)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

            Customer c1 = new Customer();
            c1.Id = 414;
            c1.Name = "Hemas slove";
            c1.Address = "New Delhi";
            Customer c2 = new Customer();
            c2.Id = 412;
            c2.Name = "Mishti flore";
            c2.Address = "Kota";
            Customer c3 = new Customer();
            c3.Id = 417;
            c3.Name = "ashaaa vaatva";
            c3.Address = "New York";

            #region List<Customer>
            List<Customer> lstCust = new List<Customer>();
            lstCust.Add(c1);
            lstCust.Add(c2);
            lstCust.Add(c3);
            foreach(Customer c in lstCust)
            {
                Console.WriteLine($"Id:{c.Id},Name:{c.Name},Address:{c.Address}");
            }
            #endregion

            Dictionary<int, Customer> dt = new Dictionary<int, Customer>();
            dt.Add(1, c1);
            dt.Add(2, c2);
            dt.Add(3, c3);
            foreach(var key in dt.Keys)
            {
                Customer c = dt[key];
                Console.WriteLine($"Id:{dt[key].Id},Name:{dt[key].Name},Address:{dt[key].Address}");
            }
        }
    }

    public class Customer
    {
        private int _Id;
        private string _Name;
        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
    }
}
