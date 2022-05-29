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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        //Connect the SQL Server
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kavya\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        //To Display the Values in Grid View
        private void populate()
        {
            Con.Open();
            string query = "select * from CAR ";
            SqlDataAdapter dAdapt = new SqlDataAdapter(query, Con);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dAdapt);
            var dSet = new DataSet();
            dAdapt.Fill(dSet);
            CarListGridView.DataSource = dSet.Tables[0];
            Con.Close();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (txtCarId.Text == "" || txtModel.Text == "" || txtColor.Text == "" || txtFuelType.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CAR(CarID,Model,Color,FuelType,Available,Price) values('" + txtCarId.Text + "','" + txtModel.Text + "','" + txtColor.Text + "','"+txtFuelType.Text + "','"+cmbBoxAvailable.SelectedItem.ToString()+"',"+txtPrice.Text+")";
                    SqlCommand cmd = new SqlCommand(query, Con); //'" + txtCarId.Text + "',
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
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

        private void Car_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDltCar_Click(object sender, EventArgs e)
        {
            if (txtCarId.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CAR where CarID = '" + txtCarId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception MyEx)
                {
                    MessageBox.Show(MyEx.Message);
                }
            }
        }

        private void CarListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCarId.Text = CarListGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtModel.Text = CarListGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtColor.Text = CarListGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtFuelType.Text = CarListGridView.SelectedRows[0].Cells[3].Value.ToString();
            cmbBoxAvailable.SelectedItem = CarListGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtPrice.Text = CarListGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (txtCarId.Text == "" || txtModel.Text == "" || txtColor.Text == "" || txtFuelType.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CAR set Model=' " + txtModel.Text + "',Color=' " + txtColor.Text + " ',FuelType =' " + txtFuelType.Text + "', Available ='" + cmbBoxAvailable.SelectedItem + "', Price ='" + txtPrice.Text + "' where CarID='" + txtCarId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception myEx)
                {
                    MessageBox.Show(myEx.Message);
                }
            }
        }

        private void btnBackCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
