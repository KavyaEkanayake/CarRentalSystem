
namespace CarRentalSystem
{
    partial class Rental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBoxCarReg = new System.Windows.Forms.ComboBox();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDriverId = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.btnBackRental = new System.Windows.Forms.Button();
            this.btnDltRental = new System.Windows.Forms.Button();
            this.btnEditRental = new System.Windows.Forms.Button();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRentalId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRentalId = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.RentalDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.txtRentFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRentFee = new System.Windows.Forms.Label();
            this.CarsOnRentGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtCustName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.cmbBoxCustId = new System.Windows.Forms.ComboBox();
            this.cmbBoxDId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsOnRentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 100);
            this.panel1.TabIndex = 2;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(22, -107);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(70, 297);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 12;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.AccessibleName = "lblExit";
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(1362, 9);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(25, 28);
            this.lblExit.TabIndex = 12;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(659, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "CAR RENTAL MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 885);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 15);
            this.panel2.TabIndex = 27;
            // 
            // cmbBoxCarReg
            // 
            this.cmbBoxCarReg.AccessibleName = "cmbBoxCarReg";
            this.cmbBoxCarReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cmbBoxCarReg.ForeColor = System.Drawing.Color.Goldenrod;
            this.cmbBoxCarReg.FormattingEnabled = true;
            this.cmbBoxCarReg.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbBoxCarReg.Location = new System.Drawing.Point(170, 253);
            this.cmbBoxCarReg.Name = "cmbBoxCarReg";
            this.cmbBoxCarReg.Size = new System.Drawing.Size(219, 31);
            this.cmbBoxCarReg.TabIndex = 68;
            // 
            // txtLocation
            // 
            this.txtLocation.AccessibleName = "txtLocation";
            this.txtLocation.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultText = "";
            this.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.Location = new System.Drawing.Point(170, 605);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PlaceholderText = "";
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(219, 36);
            this.txtLocation.TabIndex = 64;
            // 
            // lblDriverId
            // 
            this.lblDriverId.AccessibleName = "lblDriverId";
            this.lblDriverId.AutoSize = true;
            this.lblDriverId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDriverId.Location = new System.Drawing.Point(24, 543);
            this.lblDriverId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverId.Name = "lblDriverId";
            this.lblDriverId.Size = new System.Drawing.Size(98, 31);
            this.lblDriverId.TabIndex = 63;
            this.lblDriverId.Text = "DriverId";
            // 
            // lblLocation
            // 
            this.lblLocation.AccessibleName = "lblLocation";
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblLocation.Location = new System.Drawing.Point(24, 605);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(107, 31);
            this.lblLocation.TabIndex = 62;
            this.lblLocation.Text = "Location";
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AccessibleName = "lblRentalDate";
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalDate.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblRentalDate.Location = new System.Drawing.Point(24, 422);
            this.lblRentalDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(134, 31);
            this.lblRentalDate.TabIndex = 61;
            this.lblRentalDate.Text = "Rental Date";
            // 
            // btnBackRental
            // 
            this.btnBackRental.AccessibleName = "btnBackRental";
            this.btnBackRental.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBackRental.FlatAppearance.BorderSize = 0;
            this.btnBackRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackRental.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackRental.ForeColor = System.Drawing.Color.White;
            this.btnBackRental.Location = new System.Drawing.Point(177, 791);
            this.btnBackRental.Name = "btnBackRental";
            this.btnBackRental.Size = new System.Drawing.Size(103, 41);
            this.btnBackRental.TabIndex = 59;
            this.btnBackRental.Text = "Back";
            this.btnBackRental.UseVisualStyleBackColor = false;
            this.btnBackRental.Click += new System.EventHandler(this.btnBackRental_Click);
            // 
            // btnDltRental
            // 
            this.btnDltRental.AccessibleName = "btnBackRental";
            this.btnDltRental.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDltRental.FlatAppearance.BorderSize = 0;
            this.btnDltRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDltRental.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltRental.ForeColor = System.Drawing.Color.White;
            this.btnDltRental.Location = new System.Drawing.Point(286, 744);
            this.btnDltRental.Name = "btnDltRental";
            this.btnDltRental.Size = new System.Drawing.Size(103, 41);
            this.btnDltRental.TabIndex = 58;
            this.btnDltRental.Text = "DELETE";
            this.btnDltRental.UseVisualStyleBackColor = false;
            this.btnDltRental.Click += new System.EventHandler(this.btnDltRental_Click);
            // 
            // btnEditRental
            // 
            this.btnEditRental.AccessibleName = "btnEditRental";
            this.btnEditRental.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditRental.FlatAppearance.BorderSize = 0;
            this.btnEditRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRental.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRental.ForeColor = System.Drawing.Color.White;
            this.btnEditRental.Location = new System.Drawing.Point(177, 744);
            this.btnEditRental.Name = "btnEditRental";
            this.btnEditRental.Size = new System.Drawing.Size(103, 41);
            this.btnEditRental.TabIndex = 57;
            this.btnEditRental.Text = "EDIT";
            this.btnEditRental.UseVisualStyleBackColor = false;
            this.btnEditRental.Click += new System.EventHandler(this.btnEditRental_Click);
            // 
            // btnAddRental
            // 
            this.btnAddRental.AccessibleName = "btnAddRental";
            this.btnAddRental.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddRental.FlatAppearance.BorderSize = 0;
            this.btnAddRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRental.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRental.ForeColor = System.Drawing.Color.White;
            this.btnAddRental.Location = new System.Drawing.Point(67, 744);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(104, 41);
            this.btnAddRental.TabIndex = 56;
            this.btnAddRental.Text = "ADD";
            this.btnAddRental.UseVisualStyleBackColor = false;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(871, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cars on Rent";
            // 
            // txtRentalId
            // 
            this.txtRentalId.AccessibleName = "txtRentalId";
            this.txtRentalId.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtRentalId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentalId.DefaultText = "";
            this.txtRentalId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentalId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRentalId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentalId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtRentalId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentalId.Location = new System.Drawing.Point(170, 194);
            this.txtRentalId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRentalId.Name = "txtRentalId";
            this.txtRentalId.PasswordChar = '\0';
            this.txtRentalId.PlaceholderText = "";
            this.txtRentalId.SelectedText = "";
            this.txtRentalId.Size = new System.Drawing.Size(219, 36);
            this.txtRentalId.TabIndex = 54;
            // 
            // lblRentalId
            // 
            this.lblRentalId.AccessibleName = "lblRentalId";
            this.lblRentalId.AutoSize = true;
            this.lblRentalId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblRentalId.Location = new System.Drawing.Point(24, 194);
            this.lblRentalId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentalId.Name = "lblRentalId";
            this.lblRentalId.Size = new System.Drawing.Size(34, 31);
            this.lblRentalId.TabIndex = 53;
            this.lblRentalId.Text = "Id";
            // 
            // lblCustId
            // 
            this.lblCustId.AccessibleName = "lblCustId";
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustId.Location = new System.Drawing.Point(24, 309);
            this.lblCustId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(83, 31);
            this.lblCustId.TabIndex = 52;
            this.lblCustId.Text = "CustId";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AccessibleName = "lblCarReg";
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCarReg.Location = new System.Drawing.Point(24, 253);
            this.lblCarReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(93, 31);
            this.lblCarReg.TabIndex = 51;
            this.lblCarReg.Text = "CarReg";
            // 
            // RentalDate
            // 
            this.RentalDate.AccessibleName = "RentalDate";
            this.RentalDate.AutoRoundedCorners = true;
            this.RentalDate.BackColor = System.Drawing.Color.Transparent;
            this.RentalDate.BorderRadius = 17;
            this.RentalDate.Checked = true;
            this.RentalDate.FillColor = System.Drawing.Color.Goldenrod;
            this.RentalDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.RentalDate.ForeColor = System.Drawing.Color.White;
            this.RentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.RentalDate.Location = new System.Drawing.Point(170, 422);
            this.RentalDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.RentalDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RentalDate.Name = "RentalDate";
            this.RentalDate.Size = new System.Drawing.Size(219, 36);
            this.RentalDate.TabIndex = 69;
            this.RentalDate.Value = new System.DateTime(2022, 5, 8, 12, 37, 0, 0);
            // 
            // ReturnDate
            // 
            this.ReturnDate.AccessibleName = "ReturnDate";
            this.ReturnDate.AutoRoundedCorners = true;
            this.ReturnDate.BorderRadius = 17;
            this.ReturnDate.Checked = true;
            this.ReturnDate.FillColor = System.Drawing.Color.Goldenrod;
            this.ReturnDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.ReturnDate.ForeColor = System.Drawing.Color.White;
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ReturnDate.Location = new System.Drawing.Point(170, 482);
            this.ReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(219, 36);
            this.ReturnDate.TabIndex = 71;
            this.ReturnDate.Value = new System.DateTime(2022, 5, 8, 12, 37, 0, 0);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AccessibleName = "lblReturnDate";
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblReturnDate.Location = new System.Drawing.Point(24, 482);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(139, 31);
            this.lblReturnDate.TabIndex = 70;
            this.lblReturnDate.Text = "Return Date";
            // 
            // txtRentFee
            // 
            this.txtRentFee.AccessibleName = "txtRentFee";
            this.txtRentFee.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtRentFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRentFee.DefaultText = "";
            this.txtRentFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRentFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRentFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRentFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentFee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtRentFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRentFee.Location = new System.Drawing.Point(170, 667);
            this.txtRentFee.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRentFee.Name = "txtRentFee";
            this.txtRentFee.PasswordChar = '\0';
            this.txtRentFee.PlaceholderText = "";
            this.txtRentFee.SelectedText = "";
            this.txtRentFee.Size = new System.Drawing.Size(219, 36);
            this.txtRentFee.TabIndex = 73;
            // 
            // lblRentFee
            // 
            this.lblRentFee.AccessibleName = "lblRentFee";
            this.lblRentFee.AutoSize = true;
            this.lblRentFee.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentFee.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblRentFee.Location = new System.Drawing.Point(24, 667);
            this.lblRentFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentFee.Name = "lblRentFee";
            this.lblRentFee.Size = new System.Drawing.Size(107, 31);
            this.lblRentFee.TabIndex = 72;
            this.lblRentFee.Text = "Rent Fee";
            // 
            // CarsOnRentGridView
            // 
            this.CarsOnRentGridView.AccessibleName = "CarsOnRentGridView";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CarsOnRentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CarsOnRentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarsOnRentGridView.BackgroundColor = System.Drawing.Color.White;
            this.CarsOnRentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsOnRentGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarsOnRentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarsOnRentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CarsOnRentGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarsOnRentGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.CarsOnRentGridView.EnableHeadersVisualStyles = false;
            this.CarsOnRentGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsOnRentGridView.Location = new System.Drawing.Point(449, 156);
            this.CarsOnRentGridView.Name = "CarsOnRentGridView";
            this.CarsOnRentGridView.RowHeadersVisible = false;
            this.CarsOnRentGridView.RowHeadersWidth = 51;
            this.CarsOnRentGridView.RowTemplate.Height = 28;
            this.CarsOnRentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarsOnRentGridView.Size = new System.Drawing.Size(926, 638);
            this.CarsOnRentGridView.TabIndex = 60;
            this.CarsOnRentGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CarsOnRentGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CarsOnRentGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CarsOnRentGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CarsOnRentGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CarsOnRentGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CarsOnRentGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsOnRentGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Goldenrod;
            this.CarsOnRentGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CarsOnRentGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsOnRentGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CarsOnRentGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CarsOnRentGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.CarsOnRentGridView.ThemeStyle.ReadOnly = false;
            this.CarsOnRentGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CarsOnRentGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarsOnRentGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarsOnRentGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarsOnRentGridView.ThemeStyle.RowsStyle.Height = 28;
            this.CarsOnRentGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsOnRentGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarsOnRentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsOnRentGridView_CellContentClick);
            // 
            // txtCustName
            // 
            this.txtCustName.AccessibleName = "txtCustName";
            this.txtCustName.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustName.DefaultText = "";
            this.txtCustName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtCustName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustName.Location = new System.Drawing.Point(170, 365);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.PasswordChar = '\0';
            this.txtCustName.PlaceholderText = "";
            this.txtCustName.SelectedText = "";
            this.txtCustName.Size = new System.Drawing.Size(219, 36);
            this.txtCustName.TabIndex = 75;
            // 
            // lblCustName
            // 
            this.lblCustName.AccessibleName = "lblCustName";
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustName.Location = new System.Drawing.Point(24, 365);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(74, 31);
            this.lblCustName.TabIndex = 74;
            this.lblCustName.Text = "Name";
            // 
            // cmbBoxCustId
            // 
            this.cmbBoxCustId.AccessibleName = "cmbBoxCustId";
            this.cmbBoxCustId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cmbBoxCustId.ForeColor = System.Drawing.Color.Goldenrod;
            this.cmbBoxCustId.FormattingEnabled = true;
            this.cmbBoxCustId.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbBoxCustId.Location = new System.Drawing.Point(170, 312);
            this.cmbBoxCustId.Name = "cmbBoxCustId";
            this.cmbBoxCustId.Size = new System.Drawing.Size(219, 31);
            this.cmbBoxCustId.TabIndex = 76;
            this.cmbBoxCustId.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxCustId_SelectionChangeCommitted);
            // 
            // cmbBoxDId
            // 
            this.cmbBoxDId.AccessibleName = "cmbBoxDId";
            this.cmbBoxDId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cmbBoxDId.ForeColor = System.Drawing.Color.Goldenrod;
            this.cmbBoxDId.FormattingEnabled = true;
            this.cmbBoxDId.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbBoxDId.Location = new System.Drawing.Point(170, 546);
            this.cmbBoxDId.Name = "cmbBoxDId";
            this.cmbBoxDId.Size = new System.Drawing.Size(219, 31);
            this.cmbBoxDId.TabIndex = 77;
            this.cmbBoxDId.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxDId_SelectionChangeCommitted);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.cmbBoxDId);
            this.Controls.Add(this.cmbBoxCustId);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.txtRentFee);
            this.Controls.Add(this.lblRentFee);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.RentalDate);
            this.Controls.Add(this.cmbBoxCarReg);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblDriverId);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblRentalDate);
            this.Controls.Add(this.CarsOnRentGridView);
            this.Controls.Add(this.btnBackRental);
            this.Controls.Add(this.btnDltRental);
            this.Controls.Add(this.btnEditRental);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRentalId);
            this.Controls.Add(this.lblRentalId);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsOnRentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBoxCarReg;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private System.Windows.Forms.Label lblDriverId;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.Button btnBackRental;
        private System.Windows.Forms.Button btnDltRental;
        private System.Windows.Forms.Button btnEditRental;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtRentalId;
        private System.Windows.Forms.Label lblRentalId;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblCarReg;
        private Guna.UI2.WinForms.Guna2DateTimePicker RentalDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private Guna.UI2.WinForms.Guna2TextBox txtRentFee;
        private System.Windows.Forms.Label lblRentFee;
        private Guna.UI2.WinForms.Guna2DataGridView CarsOnRentGridView;
        private Guna.UI2.WinForms.Guna2TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.ComboBox cmbBoxCustId;
        private System.Windows.Forms.ComboBox cmbBoxDId;
    }
}