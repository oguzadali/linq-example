using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace linq_example
{
    public partial class Form1 : Form
    {
        // data lists
        private int[] numbrs = { -5, -25, 60, 23, 45, 100, -30, -50, 19, 27, 6, 8, -12, 12 };
        List<string> cities = new List<string>();

        public Form1()
        {


            cities.Add("Aalst");
            cities.Add("Bouillon");
            cities.Add("Brussels");
            cities.Add("Couvin");
            cities.Add("Hasselt");
            cities.Add("Landen");
            cities.Add("Mesen");
            cities.Add("Tienen");
            cities.Add("Ypres ");
            cities.Add("Gembloux ");
            cities.Add("Eeklo");
            cities.Add("Herk-de-Stad ");
            cities.Add("Zoutleeuw ");
           

            InitializeComponent();


        }

        // Num Ops ---------------
        private void buttonGetNumbers_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = numbrs.ToList();
        }

        private void buttonNegativeNumbers_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = numbrs.Where(x => x < 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void buttonPositiveNumbers_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = numbrs.Where(x => x > 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void buttonOddNumbers_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = numbrs.Where(x => x % 2 == 1 || x % 2 == -1);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void buttonEvenNumbers_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = numbrs.Where(x => x % 2 == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void buttonMaxNumber_Click(object sender, EventArgs e)
        {
            int MaxNum = numbrs.Max();
            MessageBox.Show(MaxNum.ToString());
        }

        private void buttonMinNumber_Click(object sender, EventArgs e)
        {
            int MaxNum = numbrs.Min();
            MessageBox.Show(MaxNum.ToString());
        }

        private void buttonCountNum_Click(object sender, EventArgs e)
        {
            int countList = numbrs.Count();
            MessageBox.Show(countList.ToString());
        }

        // String ops --------------------


        private void buttonGetCities_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cities;
        }

        private void buttonAsc_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cities.OrderBy(x=>x).ToList();
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cities.OrderByDescending(x => x).ToList();
        }

        private void buttonLength_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;

            List<string> temp = new List<string>();
            foreach (var item in cities)
            {
                temp.Add(item +"  " +item.Length );
            }
                       
            listBox1.DataSource =temp ;
           
        }

        private void buttonContain_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cities.Where(x => x.Contains('t') || x.Contains('T')).ToList();

        }

        private void buttonStartWith_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = cities.Where(x => x.StartsWith("z") || x.StartsWith("Z")).ToList();
        }

        //DB Table operations
        private void buttonGetOrders_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            var gt = orders.Select(x => new
            {
                OrderId = x.OrderID,
                Date = x.OrderDate,
                Customer = x.Customer.ContactName
            }) ;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gt.ToList();
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = orders.Select(x => x.OrderDate).ToList();
        }

        private void buttonTopFive_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void buttonLastFive_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderID).Take(5)
                .Select(x => new
                {
                    x.OrderID,
                    x.Customer.ContactName,
                    x.OrderDate

                }).ToList();
        }

        private void buttonGetX_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            var filter = orders.Where(x => x.Customer.ContactName == "Maria Anders").ToList();
            dataGridView1.DataSource = filter;
        }

        private void buttonOrderCount_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            int count = orders.Count;
            MessageBox.Show(count.ToString());
        }
    }
}
