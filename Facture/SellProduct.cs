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
    public partial class SellProduct : Form
    {
        List<Product> products;
        public SellProduct()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Random run = new Random();
            string str = run.Next().ToString();
            if (!string.IsNullOrEmpty(tBName.Text) && !string.IsNullOrEmpty(tBprice.Text))
            {
                Product product = new Product(int.Parse(run.Next().ToString()), tBName.Text, int.Parse(tBprice.Text), int.Parse(tBquantity.Text));
                products.Add(product);
                //Total += product.Price * product.Quantity;
               

                foreach (var p in products)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { str, tBName.Text, tBprice.Text, tBquantity.Text });
                    lvi.Tag = p;
                    listViewpro.Items.Add(lvi);
                    str = string.Empty;
                    tBName.Text = string.Empty;
                    tBprice.Text = string.Empty;
                    tBquantity.Text = string.Empty;
                    
                }
               
            }
            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            using (Bill form = new Bill(products))
            {
                form.ShowDialog();
            }
                

        }
    }
}
