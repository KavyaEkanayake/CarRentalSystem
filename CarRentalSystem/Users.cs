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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        //Connect the SQL Server
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavya\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        

        //To Display the Values in Grid View
        private void populate()
        {
            Con.Open();
            string query = "select * from [USER] ";
            SqlDataAdapter dAdapt = new SqlDataAdapter(query, Con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dAdapt);
            var dSet = new DataSet();
            dAdapt.Fill(dSet);
            UserListGridView.DataSource = dSet.Tables[0];
            Con.Close();
        }

        //Inserting values for the Table
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUid.Text == "" || txtUname.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into [USER] values(" + txtUid.Text + ",'" + txtUname.Text + "','" + txtPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);
                }
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        //Delete Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtUid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from [USER] where UserID = " + txtUid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception MyEx)
                {
                    MessageBox.Show(MyEx.Message);
                }
            }
        }

        //Assign grid values to the textboxes
        private void UserListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUid.Text = UserListGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtUname.Text = UserListGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword.Text = UserListGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        //Editing User details
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (txtUid.Text == "" || txtUname.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update [USER] set UserName=' " + txtUname.Text + "',UserPassword='" + txtPassword.Text + "' where UserID=" + txtUid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);
                }
            }
        }

        //To return to Main Form Page
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
