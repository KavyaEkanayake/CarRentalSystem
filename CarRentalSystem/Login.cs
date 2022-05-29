using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRentalSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Connect the SQL Server
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavya\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from [USER] where UserName='" + txtUid.Text + "' and UserPassword='" + txtPw.Text + "'";
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            Con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUid.Text = "";
            txtPw.Text = "";
        }
    }
}
