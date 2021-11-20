using CorrectionCC1.BLL;
using CorrectionCC1.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrectionCC1.WinForms
{
    public partial class FrmAddUserProduct : Form
    {
        private User user;
        private FrmAddUserProduct()
        {
            InitializeComponent();
        }

        public FrmAddUserProduct(User user):this()
        {
            this.user = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager userManager = new UserManager();               

                if (!double.TryParse(txtPrice.Text, out _))
                    throw new Exception("Invalid price !");

                var product = new Product(txtReference.Text, txtName.Text, double.Parse(txtPrice.Text));

                userManager.AddUserProduct(user, product);

                MessageBox.Show($"Product added !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
