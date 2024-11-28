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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=PASIYA;Initial Catalog=Student;Integrated Security=True;");

        private void linkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void regNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string no = regNo.Text;

            try
            {
                if (no != "New Register")
                {
                    con.Open();
                    string query_select = "SELECT * FROM  Registration WHERE regNo =" + no;
                    SqlCommand cmd = new SqlCommand(query_select, con);
                    SqlDataReader row = cmd.ExecuteReader();
                    while (row.Read())
                    {
                        txtFName.Text = row[1].ToString();
                        txtLName.Text = row[2].ToString();
                        dtpDob.Format = DateTimePickerFormat.Custom;
                        dtpDob.CustomFormat = "yyyy/MM/dd";
                        dtpDob.Text = row[3].ToString();
                        if (row[4].ToString() == "Male")
                        {
                            rbMale.Checked = true;
                            rbFemale.Checked = false;
                        }
                        else
                        {
                            rbMale.Checked = false;
                            rbFemale.Checked = true;
                        }
                        txtAddress.Text = row[5].ToString();
                        txtEmail.Text = row[6].ToString();
                        txtMobile.Text = row[7].ToString();
                        txtHphone.Text = row[8].ToString();
                        txtPName.Text = row[9].ToString();
                        txtNIC.Text = row[10].ToString();
                        txtConNum.Text = row[11].ToString();
                    }
                    con.Close();
                    btnReg.Enabled = false;
                    btnUp.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    txtFName.Text = "";
                    txtLName.Text = "";
                    dtpDob.Format = DateTimePickerFormat.Custom;
                    dtpDob.CustomFormat = "yyyy/MM/dd";
                    DateTime thisDay = DateTime.Today;
                    dtpDob.Text = thisDay.ToString();

                    rbMale.Checked = false;
                    rbFemale.Checked = false;

                    txtAddress.Text = "";
                    txtEmail.Text = "";
                    txtMobile.Text = "";
                    txtHphone.Text = "";
                    txtPName.Text = "";
                    txtNIC.Text = "";
                    txtConNum.Text = "";

                    btnReg.Enabled = true;
                    btnUp.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void registration_Load(object sender, EventArgs e)
        {
            con.Open();
            string query_select = "SELECT * FROM Registration";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            SqlDataReader row = cmnd.ExecuteReader();
            regNo.Items.Add("New Register");
            while (row.Read())
            {
                regNo.Items.Add(row[0].ToString());
            }
            con.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFName.Text;
                string lastName = txtLName.Text;
                dtpDob.Format = DateTimePickerFormat.Custom;
                dtpDob.CustomFormat = "yyyy/MM/dd";
                string gender;
                if (rbMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                int mobilePhone = int.Parse(txtMobile.Text);
                int homePhone = int.Parse(txtHphone.Text);
                string pName = txtPName.Text;
                string nic = txtNIC.Text;
                int conNum = int.Parse(txtConNum.Text);

                con.Open();
                string query_insert = "INSERT INTO Registration VALUES('" + firstName + "','" + lastName + "','" + dtpDob.Text + "','" + gender + "','" + address + "','" + email + "'," + mobilePhone + "," + homePhone + ",'" + pName + "','" + nic + "'," + conNum + ")";
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Record added successfully!", "Registered Employee!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string no = regNo.Text;

            try
            {


                if (no != "New Register")
                {
                    string firstName = txtFName.Text;
                    string lastName = txtLName.Text;
                    dtpDob.Format = DateTimePickerFormat.Custom;
                    dtpDob.CustomFormat = "yyyy/MM/dd";
                    string gender;
                    if (rbMale.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string address = txtAddress.Text;
                    string email = txtEmail.Text;
                    int mobilePhone = int.Parse(txtMobile.Text);
                    int homePhone = int.Parse(txtHphone.Text);
                    string pName = txtPName.Text;
                    string nic = txtNIC.Text;
                    int conNum = int.Parse(txtConNum.Text);

                    con.Open();
                    string query_insert = "UPDATE Registration SET firstName = '" + firstName + "',lastName='" + lastName + "',dateOfBirth= '" + dtpDob.Text + "',gender = '" + gender + "',address = '" + address + "',email = '" + email + "',mobilePhone = " + mobilePhone + ",homePhone = " + homePhone + ",parentName ='" + pName + "',NIC = '" + nic + "',contactNo = " + conNum + " WHERE regNo = '" + no + "'";
                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Record Update Successfully!", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            dtpDob.Format = DateTimePickerFormat.Custom;
            dtpDob.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            dtpDob.Text = thisDay.ToString();

            rbMale.Checked = false;
            rbFemale.Checked = false;

            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtHphone.Text = "";
            txtPName.Text = "";
            txtNIC.Text = "";
            txtConNum.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure, Do you really want to delete this record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string no = regNo.Text;

                    con.Open();
                    string query_inset = "DELETE FROM Registration WHERE regNo = " + no + "";
                    SqlCommand cmnd = new SqlCommand(query_inset, con);
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully!", "Deleted Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
