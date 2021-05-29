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
    }
}
