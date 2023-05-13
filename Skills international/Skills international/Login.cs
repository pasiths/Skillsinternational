using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_international
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "ayodya" && txtPassword.Text == "ayodya456")
            {
                registration reg = new registration();
                this.Hide();
                reg.Show();

            }
            else if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Username & Password Is Empty!!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();

            }
            else
            {
                MessageBox.Show("Invalid login credentials, Please check Username & Password and try again!", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
