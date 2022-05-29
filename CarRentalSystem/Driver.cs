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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        //Connect the SQL Server
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavya\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        //Exit Button
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //To Display the Values in Grid View
        private void populate()
        {
            Con.Open();
            string query = "select * from DRIVER ";
            SqlDataAdapter dAdapt = new SqlDataAdapter(query, Con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dAdapt);
            var dSet = new DataSet();
            dAdapt.Fill(dSet);
            DriversListGridView.DataSource = dSet.Tables[0];
            Con.Close();
        }

        //Inserting a driver
        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (txtDriverId.Text == "" || txtDriverName.Text == "" || txtDriverAddress.Text == "" || txtDriverNIC.Text == "" || txtDriverAge.Text == "" || txtDriverPhone.Text == "" || txtDriverLicenseNo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into DRIVER(ID,Name,Address,NIC,Gender,Age,Phone,LicenseNo) values('" + txtDriverId.Text + "','" + txtDriverName.Text + "','" + txtDriverAddress.Text + "','" + txtDriverNIC.Text + "','" + cmbBoxGender.SelectedItem.ToString() + "','" + txtDriverAge.Text + "','" + txtDriverPhone.Text + "','" + txtDriverLicenseNo.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Driver Successfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);
                }
            }
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            populate();
        }

        //Driver delete button
        private void btnDltDriver_Click(object sender, EventArgs e)
        {
            if (txtDriverId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from DRIVER where ID = '" + txtDriverId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Driver Deleted Successfully");
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
        private void DriversListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDriverId.Text = DriversListGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtDriverName.Text = DriversListGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtDriverAddress.Text = DriversListGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtDriverNIC.Text = DriversListGridView.SelectedRows[0].Cells[3].Value.ToString();
            cmbBoxGender.Text = DriversListGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtDriverAge.Text = DriversListGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtDriverPhone.Text = DriversListGridView.SelectedRows[0].Cells[6].Value.ToString();
            txtDriverLicenseNo.Text = DriversListGridView.SelectedRows[0].Cells[7].Value.ToString();
        }

        //Editing the Driver details
        private void btnEditDriver_Click(object sender, EventArgs e)
        {
            if (txtDriverId.Text == "" || txtDriverName.Text == "" || txtDriverAddress.Text == "" || txtDriverNIC.Text == "" || txtDriverAge.Text == "" || txtDriverPhone.Text == "" || txtDriverLicenseNo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update DRIVER set Name=' " + txtDriverName.Text + "',Address='" + txtDriverAddress.Text + "',NIC='" + txtDriverNIC.Text + "',Gender='"+cmbBoxGender.SelectedItem+"',Age='"+txtDriverAge.Text+"',Phone='"+txtDriverPhone.Text+"',LicenseNo='"+txtDriverLicenseNo.Text+"' where ID='" + txtDriverId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Driver Successfully Updated");
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
        private void btnBackDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}

