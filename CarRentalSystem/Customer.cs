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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        //Connect the SQL Server
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavya\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        //To Display the Values in Grid View
        private void populate()
        {
            Con.Open();
            string query = "select * from CUSTOMER ";
            SqlDataAdapter dAdapt = new SqlDataAdapter(query, Con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dAdapt);
            var dSet = new DataSet();
            dAdapt.Fill(dSet);
            CustomersListGridView.DataSource = dSet.Tables[0];
            Con.Close();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDltCust_Click(object sender, EventArgs e)
        {
            if (txtCustId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CUSTOMER where CustomerID = '" + txtCustId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception MyEx)
                {
                    MessageBox.Show(MyEx.Message);
                }
            }
        }

        private void CustomersListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustId.Text = CustomersListGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = CustomersListGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = CustomersListGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = CustomersListGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtPhone.Text = CustomersListGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtEmail.Text = CustomersListGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            if (txtCustId.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CUSTOMER set FirstName=' " + txtFirstName.Text + "',LastName='" + txtLastName.Text + "',Address='" + txtAddress.Text + "',Phone='" + txtPhone.Text + "',Email='" + txtEmail.Text + "' where CustomerID='" + txtCustId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);
                }
            }
        }

        private void btnBackCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
