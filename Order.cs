using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_example
{

    // Northwind DB , Orders Table
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }

        public List<Order> GetOrders()
        {
            List<Order> lisT = new List<Order>();
            string SqlQr1 = @"select d.CustomerID,d.EmployeeID,d.OrderID,d.OrderDate,
                            (Select ContactName from Customers
                            where CustomerID=d.CustomerID) as 'Contact Name'
                            from Orders d";
            DataTable dataTable1 = GetDataTable(SqlQr1);

            foreach (DataRow item in dataTable1.Rows)
            {
                Order or = new Order();
                or.OrderID =(int) item["OrderID"];
                or.CustomerID =(string) item["CustomerID"];
                or.EmployeeID =(int) item["EmployeeID"];
                or.OrderDate =(DateTime) item["OrderDate "];
                or.Customer =new Customer();
                or.Customer.ContactName =item["ContactName"].ToString();
                or.Customer.CustumerID =(string) item["CustumerID"];

                //or =(int) item[""];

                lisT.Add(or);
            }
            return lisT;
        }

        private DataTable GetDataTable(string sqlQr1)
        {
            string connectionStr = @"Data Source=.; Initial Catalog=Northwind; Integrated Security=True";
            SqlDataAdapter SqlDA = new SqlDataAdapter(sqlQr1, connectionStr);
            DataTable dataTable2 = new DataTable();
            SqlDA.Fill(dataTable2);
            return dataTable2;

        }
    }

    class Customer
    {
        public string CustumerID { get; set; }
        public string ContactName { get; set; }
        public List<Order> Orders { get; set; }
        public int OrderCount
        {

            get { return Orders.Count; }

        }
    }
}
