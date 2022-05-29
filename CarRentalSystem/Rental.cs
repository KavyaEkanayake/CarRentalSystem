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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }

        //Connect the SQL Server
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavya\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

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
            Con.Close();
        }

        private void fillCustomersName()
        {
            Con.Open();
            string query = "select CustomerID from CUSTOMER";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader dReader;
            dReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerID", typeof(string));
            dt.Load(dReader);
            cmbBoxCustId.ValueMember = "CustomerID";
            cmbBoxCustId.DataSource = dt;
            Con.Close();
        }

        //Getting Customers names from the database according to the customerID
        private void fetchCustName()
        {
            Con.Open();
            string query = "select * from CUSTOMER where CustomerID='" + cmbBoxCustId.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtCustName.Text = dr["FirstName"] + " " + dr["LastName"].ToString();
            }
            Con.Close();
        }

        //Display DriverID in the combo box
        private void fillDriverIdCombo()
        {
            Con.Open();
            string query = "select ID from DRIVER";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader dReader;
            dReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Load(dReader);
            cmbBoxDId.ValueMember = "ID";
            cmbBoxDId.DataSource = dt;
            Con.Close();
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbBoxCustId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }

        //To Display the Values in Grid View
        private void populate()
        {
            Con.Open();
            string query = "select * from RENTAL";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            var dSet = new DataSet();
            da.Fill(dSet);
            CarsOnRentGridView.DataSource = dSet.Tables[0];
            Con.Close();
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            if (txtRentalId.Text == "" || txtCustName.Text == "" || txtLocation.Text == "" || txtRentFee.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into RENTAL(ID,CarRegNo,CustID,CustName,RentDate,ReturnDate,DrID,Location,RentFee) values('" + txtRentalId.Text + "', '" + cmbBoxCarReg.SelectedItem.ToString() + "', '" + cmbBoxCustId.SelectedItem.ToString() + "', '" + txtCustName.Text + "', '" + RentalDate.Value.Date + "', '" + ReturnDate.Value.Date + "', '" + cmbBoxDId.SelectedItem.ToString() + "', '" + txtLocation.Text + "', '" + txtRentFee.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented");
                    Con.Close();
                    populate();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);
                }
            }
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            fillCarRegCombo();
            fillCustomersName();
            fillDriverIdCombo();
            populate();
        }

        private void btnBackRental_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void cmbBoxDId_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnDltRental_Click(object sender, EventArgs e)
        {
            if (txtRentalId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from RENTAL where ID='" + txtRentalId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Information Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception MyEx)
                {
                    MessageBox.Show(MyEx.Message);
                }
            }
        }

        private void CarsOnRentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRentalId.Text = CarsOnRentGridView.SelectedRows[0].Cells[0].Value.ToString();
            cmbBoxCarReg.Text = CarsOnRentGridView.SelectedRows[0].Cells[1].Value.ToString();
            cmbBoxCustId.Text = CarsOnRentGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtCustName.Text = CarsOnRentGridView.SelectedRows[0].Cells[3].Value.ToString();
            RentalDate.Text = CarsOnRentGridView.SelectedRows[0].Cells[4].Value.ToString();
            ReturnDate.Text = CarsOnRentGridView.SelectedRows[0].Cells[5].Value.ToString();
            cmbBoxDId.Text = CarsOnRentGridView.SelectedRows[0].Cells[6].Value.ToString();
            txtLocation.Text = CarsOnRentGridView.SelectedRows[0].Cells[7].Value.ToString();
            txtRentFee.Text = CarsOnRentGridView.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnEditRental_Click(object sender, EventArgs e)
        {
            if (txtRentalId.Text == "" || txtCustName.Text == "" || txtLocation.Text == "" || txtRentFee.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update RENTAL set CarRegNo='"+cmbBoxCarReg.SelectedItem.ToString()+"', CustId='"+cmbBoxCustId.SelectedItem.ToString()+"', CustName='"+txtCustName.Text+"', RentDate='"+RentalDate.Value.Date+"', ReturnDate='"+ReturnDate.Value.Date+"', DrID='"+cmbBoxDId.SelectedItem.ToString()+"', Location='"+txtLocation.Text+"', RentFee='"+txtRentFee.Text+"' where ID='"+txtRentalId.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Details Successfully Updated");
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
