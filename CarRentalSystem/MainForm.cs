using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car form = new Car();
            form.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer form = new Customer();
            form.Show();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental form = new Rental();
            form.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return form = new Return();
            form.Show();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driver form = new Driver();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarOwner form = new CarOwner();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users form = new Users();
            form.Show();
        }

        //LogOut Button
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }
    }
}
