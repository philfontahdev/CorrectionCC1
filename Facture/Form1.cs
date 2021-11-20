using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture
{
    public partial class Form1 : Form
    {
        Random Run = new Random();
        List<Product> products;
        double Total = 0;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = new List<Product>();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(namep.Text) && string.IsNullOrEmpty(Price.Text))
            { 
               Product product = new Product(int.Parse(Run.Next().ToString()), namep.Text, int.Parse(Price.Text), int.Parse(Quantity.Text));
                   
                Total += product.Price * product.Quantity;
                bindingSource1.Add(product);
                bindingSource1.MoveLast();
                namep.Text = string.Empty;
                Price.Text = string.Empty;
                total.Text = string.Format("(0)$", Total);

                foreach (var stock in products)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { Run.Next().ToString(), namep.Text, Price.Text, Quantity.Text });
                    lvi.Tag = stock;
                    listView1.Items.Add(lvi);

                }
              
            }
            

        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
           Product product =bindingSource1.Current as Product;
            if(product != null)
            {
                Total -= product.Price * product.Quantity;
                total.Text = string.Format("(0)$", Total);
            }
            bindingSource1.RemoveCurrent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            /*
            using(Bill form = new Bill(bindingSource1.DataSource as List<Product>,
                string.Format("(0:0.00)$", Total), string.Format("(0)$", Cash.Text),
                string.Format("(0)$", Convert.ToDouble(Cash.Text)-Total),DateTime.Now.ToString("MM/dd/yyyy")))
            {
                form.ShowDialog();
            }*/
        }
    }
}
