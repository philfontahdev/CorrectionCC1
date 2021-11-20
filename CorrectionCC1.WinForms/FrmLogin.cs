using CorrectionCC1.BLL;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtEmail.Text = "admin@admin.net";
            txtPassword.Text = "admin12345";
        }

        private void btnCoonect_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager userManager = new UserManager();
                var user = userManager.Authenticate(txtEmail.Text, txtPassword.Text);
                if (user == null)
                    throw new Exception("Email or password is incorrect !");

                Program.CurrentUser = user;

                MessageBox.Show($"Welcome {user.Fullname} !", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmParent form = new FrmParent();
                form.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
