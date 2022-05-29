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
    public partial class CarOwner : Form
    {
        public CarOwner()
        {
            InitializeComponent();
        }

        //Connect the SQL Server
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavya\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //RETURN TO MAINFRORM
        private void btnBackOwner_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        //Display CarID in the combo box
        private void fillCarRegCombo()
        {
            Con.Open();
            string query = "select CarID from CAR";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader dReader;
            dReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CarID", typeof(string));
            dt.Load(dReader);
            cmbBoxCarReg.ValueMember = "CarID";
            cmbBoxCarReg.DataSource = dt;
            cmbBoxCarReg.DisplayMember = "CarID";
            Con.Close();
        }

        //To Display the Values in Grid View
        private void populate()
        {
            Con.Open();
            string query = "select * from CAR_OWNER ";
            SqlDataAdapter dAdapt = new SqlDataAdapter(query, Con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dAdapt);
            var dSet = new DataSet();
            dAdapt.Fill(dSet);
            OwnersListGridView.DataSource = dSet.Tables[0];
            Con.Close();
        }

        //ADD OWNER DETAILS
        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            if (txtOwnerId.Text == "" || txtName.Text == "" || txtAddress.Text == "" ||txtPhone.Text == "" || txtBank.Text == "" || txtAccNo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CAR_OWNER(ID,CarID,Name,Address,Phone,Bank,AccNo) values('"+txtOwnerId.Text+"', '"+cmbBoxCarReg.SelectedItem.ToString()+"', '"+txtName.Text+"', '"+txtAddress.Text+"', '"+txtPhone.Text+"', '"+txtBank.Text+"', '"+txtAccNo.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Owner Successfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);
                }
            }
        }

        private void OwnersListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOwnerId.Text = OwnersListGridView.SelectedRows[0].Cells[0].Value.ToString();
            cmbBoxCarReg.Text = OwnersListGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = OwnersListGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = OwnersListGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtPhone.Text = OwnersListGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtBank.Text = OwnersListGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtAccNo.Text = OwnersListGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void CarOwner_Load(object sender, EventArgs e)
        {
            fillCarRegCombo();
            populate();
        }

        private void cmbBoxCarReg_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        //DELETE OWNER DETAILS
        private void btnDltOwner_Click(object sender, EventArgs e)
        {
            if (txtOwnerId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CAR_OWNER where ID='"+txtOwnerId.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Owner Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception MyEx)
                {
                    MessageBox.Show(MyEx.Message);
                }
            }
        }

        //EDIT OWNER DETAILS
        private void btnEditOwner_Click(object sender, EventArgs e)
        {
            if (txtOwnerId.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || txtBank.Text == "" || txtAccNo.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CAR_OWNER set CarID='" + cmbBoxCarReg.SelectedItem.ToString() + "', Name='" + txtName.Text + "', Address='" + txtAddress.Text + "', Phone='" + txtPhone.Text + "', Bank='" + txtBank.Text + "', AccNo='" + txtAccNo.Text + "' where ID='" + txtOwnerId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Owner Successfully Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);
                }
            }
        }
    }
}
