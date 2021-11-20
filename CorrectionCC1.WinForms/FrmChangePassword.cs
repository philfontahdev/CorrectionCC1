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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager userManager = new UserManager();
                var user = userManager.Authenticate(Program.CurrentUser.Email, txtOldPassword.Text);
                if (user == null)
                    throw new Exception("Old password is incorrect !");
                if(txtNewPassword.Text != txtConfirmPassword.Text)
                    throw new Exception("New password and Confirm password doesn't match !");

                Program.CurrentUser.Password = txtNewPassword.Text;
                userManager.EditUser(user, Program.CurrentUser);

                MessageBox.Show($"Password change successfully !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
