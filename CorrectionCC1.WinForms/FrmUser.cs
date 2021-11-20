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
    public partial class FrmUser : Form
    {
        private UserManager userManager;
        private User editedUser;
        public FrmUser()
        {
            InitializeComponent();
            userManager = new UserManager();
            LoadUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtPassword.Text != txtConfirmPassword.Text)
                    throw new Exception("New password and Confirm password doesn't match !");

                var user = new User(txtEmail.Text, txtPassword.Text, txtFullname.Text);
                if (editedUser == null)
                {
                    userManager.AddUser(user);
                }
                else
                {
                    userManager.EditUser(editedUser, user);
                }

                MessageBox.Show($"Save done !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reset();

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            txtEmail.Clear();
            txtFullname.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            editedUser = null;
            lvUser.SelectedItems.Clear();
            lvProduct.SelectedItems.Clear();
            lvProduct.Items.Clear();
        }

        private void LoadUsers()
        {
            var users = userManager.GetAllUser();
            lvUser.Items.Clear();
            foreach (var u in users)
            {
                ListViewItem lvi = new ListViewItem(new string[] { u.Email, u.Fullname });
                lvi.Tag = u;
                lvUser.Items.Add(lvi);
            }
        }

        private void lvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUser.SelectedItems.Count == 0)
                return;
            var user = lvUser.SelectedItems[0].Tag as User;
            LoadUserProducts(user);

        }

        private void LoadUserProducts(User user)
        {
            var products = user.GetProducts();
            lvProduct.Items.Clear();
            foreach (var p in products)
            {
                ListViewItem lvi = new ListViewItem(new string[] { p.Reference, p.Name, p.Price.ToString() });
                lvi.Tag = p;
                lvProduct.Items.Add(lvi);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (lvUser.SelectedItems.Count == 0)
                return;
            var user = lvUser.SelectedItems[0].Tag as User;

            txtConfirmPassword.Text = user.Password;
            txtEmail.Text = user.Email;
            txtFullname.Text = user.Fullname;
            txtPassword.Text = user.Password;
            editedUser = user;
        }

        private void btnAddUserProduct_Click(object sender, EventArgs e)
        {
            if (lvUser.SelectedItems.Count == 0)
                return;
            var user = lvUser.SelectedItems[0].Tag as User;

            FrmAddUserProduct form = new FrmAddUserProduct(user);
            form.ShowDialog();
            LoadUserProducts(user);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteUserProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
