using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        SqlConnection con = new SqlConnection(@"Data Source=PASIYA;Initial Catalog=Student;Integrated Security=True;");

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Username & Password Is Empty!!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else
            {
                try
                {
                    string sql = "SELECT * FROM Logins WHERE username=@username AND password=@password";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.ToString());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.ToString());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        registration reg = new registration();
                        this.Hide();
                        reg.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials, Please check. Username and Password and try again!!!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { 
                    con.Close();
                }
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
