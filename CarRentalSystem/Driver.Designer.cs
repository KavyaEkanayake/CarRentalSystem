
namespace CarRentalSystem
{
    partial class Driver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDriverLicenseNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDriverPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDriverNIC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDriverAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDriverName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDriverPhone = new System.Windows.Forms.Label();
            this.lblDriverLNo = new System.Windows.Forms.Label();
            this.lblDriverAddress = new System.Windows.Forms.Label();
            this.DriversListGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBackDriver = new System.Windows.Forms.Button();
            this.btnDltDriver = new System.Windows.Forms.Button();
            this.btnEditDriver = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDriverId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDriverId = new System.Windows.Forms.Label();
            this.lblDriverNIC = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblDriverGender = new System.Windows.Forms.Label();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.lblDriverDob = new System.Windows.Forms.Label();
            this.txtDriverAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriversListGridView)).BeginInit();
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
            this.panel1.TabIndex = 4;
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
            this.label5.Location = new System.Drawing.Point(603, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Drivers";
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
            this.panel2.TabIndex = 29;
            // 
            // txtDriverLicenseNo
            // 
            this.txtDriverLicenseNo.AccessibleName = "txtDriverLicenseNo";
            this.txtDriverLicenseNo.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtDriverLicenseNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverLicenseNo.DefaultText = "";
            this.txtDriverLicenseNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDriverLicenseNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDriverLicenseNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverLicenseNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverLicenseNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverLicenseNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDriverLicenseNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverLicenseNo.Location = new System.Drawing.Point(168, 633);
            this.txtDriverLicenseNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDriverLicenseNo.Name = "txtDriverLicenseNo";
            this.txtDriverLicenseNo.PasswordChar = '\0';
            this.txtDriverLicenseNo.PlaceholderText = "";
            this.txtDriverLicenseNo.SelectedText = "";
            this.txtDriverLicenseNo.Size = new System.Drawing.Size(219, 36);
            this.txtDriverLicenseNo.TabIndex = 86;
            // 
            // txtDriverPhone
            // 
            this.txtDriverPhone.AccessibleName = "txtDriverPhone";
            this.txtDriverPhone.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtDriverPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverPhone.DefaultText = "";
            this.txtDriverPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDriverPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDriverPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDriverPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverPhone.Location = new System.Drawing.Point(168, 567);
            this.txtDriverPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDriverPhone.Name = "txtDriverPhone";
            this.txtDriverPhone.PasswordChar = '\0';
            this.txtDriverPhone.PlaceholderText = "";
            this.txtDriverPhone.SelectedText = "";
            this.txtDriverPhone.Size = new System.Drawing.Size(219, 36);
            this.txtDriverPhone.TabIndex = 85;
            // 
            // txtDriverNIC
            // 
            this.txtDriverNIC.AccessibleName = "txtDriverNIC";
            this.txtDriverNIC.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtDriverNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverNIC.DefaultText = "";
            this.txtDriverNIC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDriverNIC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDriverNIC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverNIC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverNIC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverNIC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDriverNIC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverNIC.Location = new System.Drawing.Point(168, 379);
            this.txtDriverNIC.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDriverNIC.Name = "txtDriverNIC";
            this.txtDriverNIC.PasswordChar = '\0';
            this.txtDriverNIC.PlaceholderText = "";
            this.txtDriverNIC.SelectedText = "";
            this.txtDriverNIC.Size = new System.Drawing.Size(219, 36);
            this.txtDriverNIC.TabIndex = 84;
            // 
            // txtDriverAddress
            // 
            this.txtDriverAddress.AccessibleName = "txtDriverAddress";
            this.txtDriverAddress.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtDriverAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverAddress.DefaultText = "";
            this.txtDriverAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDriverAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDriverAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDriverAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverAddress.Location = new System.Drawing.Point(168, 317);
            this.txtDriverAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDriverAddress.Name = "txtDriverAddress";
            this.txtDriverAddress.PasswordChar = '\0';
            this.txtDriverAddress.PlaceholderText = "";
            this.txtDriverAddress.SelectedText = "";
            this.txtDriverAddress.Size = new System.Drawing.Size(219, 36);
            this.txtDriverAddress.TabIndex = 83;
            // 
            // txtDriverName
            // 
            this.txtDriverName.AccessibleName = "txtDriverName";
            this.txtDriverName.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtDriverName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverName.DefaultText = "";
            this.txtDriverName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDriverName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDriverName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDriverName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverName.Location = new System.Drawing.Point(168, 255);
            this.txtDriverName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.PasswordChar = '\0';
            this.txtDriverName.PlaceholderText = "";
            this.txtDriverName.SelectedText = "";
            this.txtDriverName.Size = new System.Drawing.Size(219, 36);
            this.txtDriverName.TabIndex = 82;
            // 
            // lblDriverPhone
            // 
            this.lblDriverPhone.AccessibleName = "lblDriverPhone";
            this.lblDriverPhone.AutoSize = true;
            this.lblDriverPhone.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverPhone.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDriverPhone.Location = new System.Drawing.Point(16, 567);
            this.lblDriverPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverPhone.Name = "lblDriverPhone";
            this.lblDriverPhone.Size = new System.Drawing.Size(83, 31);
            this.lblDriverPhone.TabIndex = 81;
            this.lblDriverPhone.Text = "Phone";
            // 
            // lblDriverLNo
            // 
            this.lblDriverLNo.AccessibleName = "lblDriverLNo";
            this.lblDriverLNo.AutoSize = true;
            this.lblDriverLNo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverLNo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDriverLNo.Location = new System.Drawing.Point(16, 633);
            this.lblDriverLNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverLNo.Name = "lblDriverLNo";
            this.lblDriverLNo.Size = new System.Drawing.Size(132, 31);
            this.lblDriverLNo.TabIndex = 80;
            this.lblDriverLNo.Text = "License No";
            // 
            // lblDriverAddress
            // 
            this.lblDriverAddress.AccessibleName = "lblDriverAddress";
            this.lblDriverAddress.AutoSize = true;
            this.lblDriverAddress.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverAddress.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDriverAddress.Location = new System.Drawing.Point(13, 322);
            this.lblDriverAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverAddress.Name = "lblDriverAddress";
            this.lblDriverAddress.Size = new System.Drawing.Size(103, 31);
            this.lblDriverAddress.TabIndex = 79;
            this.lblDriverAddress.Text = "Address";
            // 
            // DriversListGridView
            // 
            this.DriversListGridView.AccessibleName = "DriversListGridView";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.DriversListGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DriversListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DriversListGridView.BackgroundColor = System.Drawing.Color.White;
            this.DriversListGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DriversListGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DriversListGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DriversListGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DriversListGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DriversListGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.DriversListGridView.EnableHeadersVisualStyles = false;
            this.DriversListGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DriversListGridView.Location = new System.Drawing.Point(449, 156);
            this.DriversListGridView.Name = "DriversListGridView";
            this.DriversListGridView.RowHeadersVisible = false;
            this.DriversListGridView.RowHeadersWidth = 51;
            this.DriversListGridView.RowTemplate.Height = 28;
            this.DriversListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DriversListGridView.Size = new System.Drawing.Size(926, 638);
            this.DriversListGridView.TabIndex = 78;
            this.DriversListGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DriversListGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DriversListGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DriversListGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DriversListGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DriversListGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DriversListGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DriversListGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Goldenrod;
            this.DriversListGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DriversListGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversListGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DriversListGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DriversListGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.DriversListGridView.ThemeStyle.ReadOnly = false;
            this.DriversListGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DriversListGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DriversListGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversListGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DriversListGridView.ThemeStyle.RowsStyle.Height = 28;
            this.DriversListGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DriversListGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DriversListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DriversListGridView_CellContentClick);
            // 
            // btnBackDriver
            // 
            this.btnBackDriver.AccessibleName = "btnBackDriver";
            this.btnBackDriver.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBackDriver.FlatAppearance.BorderSize = 0;
            this.btnBackDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackDriver.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDriver.ForeColor = System.Drawing.Color.White;
            this.btnBackDriver.Location = new System.Drawing.Point(175, 768);
            this.btnBackDriver.Name = "btnBackDriver";
            this.btnBackDriver.Size = new System.Drawing.Size(103, 41);
            this.btnBackDriver.TabIndex = 77;
            this.btnBackDriver.Text = "Back";
            this.btnBackDriver.UseVisualStyleBackColor = false;
            this.btnBackDriver.Click += new System.EventHandler(this.btnBackDriver_Click);
            // 
            // btnDltDriver
            // 
            this.btnDltDriver.AccessibleName = "btnDltDriver";
            this.btnDltDriver.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDltDriver.FlatAppearance.BorderSize = 0;
            this.btnDltDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDltDriver.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltDriver.ForeColor = System.Drawing.Color.White;
            this.btnDltDriver.Location = new System.Drawing.Point(284, 721);
            this.btnDltDriver.Name = "btnDltDriver";
            this.btnDltDriver.Size = new System.Drawing.Size(103, 41);
            this.btnDltDriver.TabIndex = 76;
            this.btnDltDriver.Text = "DELETE";
            this.btnDltDriver.UseVisualStyleBackColor = false;
            this.btnDltDriver.Click += new System.EventHandler(this.btnDltDriver_Click);
            // 
            // btnEditDriver
            // 
            this.btnEditDriver.AccessibleName = "btnEditDriver";
            this.btnEditDriver.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditDriver.FlatAppearance.BorderSize = 0;
            this.btnEditDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDriver.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDriver.ForeColor = System.Drawing.Color.White;
            this.btnEditDriver.Location = new System.Drawing.Point(175, 721);
            this.btnEditDriver.Name = "btnEditDriver";
            this.btnEditDriver.Size = new System.Drawing.Size(103, 41);
            this.btnEditDriver.TabIndex = 75;
            this.btnEditDriver.Text = "EDIT";
            this.btnEditDriver.UseVisualStyleBackColor = false;
            this.btnEditDriver.Click += new System.EventHandler(this.btnEditDriver_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.AccessibleName = "btnAddDriver";
            this.btnAddDriver.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddDriver.FlatAppearance.BorderSize = 0;
            this.btnAddDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDriver.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDriver.ForeColor = System.Drawing.Color.White;
            this.btnAddDriver.Location = new System.Drawing.Point(65, 721);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(104, 41);
            this.btnAddDriver.TabIndex = 74;
            this.btnAddDriver.Text = "ADD";
            this.btnAddDriver.UseVisualStyleBackColor = false;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(870, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 33);
            this.label3.TabIndex = 73;
            this.label3.Text = "Drivers List";
            // 
            // txtDriverId
            // 
            this.txtDriverId.AccessibleName = "txtDriverId";
            this.txtDriverId.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtDriverId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverId.DefaultText = "";
            this.txtDriverId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDriverId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDriverId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDriverId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverId.Location = new System.Drawing.Point(168, 191);
            this.txtDriverId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDriverId.Name = "txtDriverId";
            this.txtDriverId.PasswordChar = '\0';
            this.txtDriverId.PlaceholderText = "";
            this.txtDriverId.SelectedText = "";
            this.txtDriverId.Size = new System.Drawing.Size(219, 36);
            this.txtDriverId.TabIndex = 72;
            // 
            // lblDriverId
            // 
            this.lblDriverId.AccessibleName = "lblDriverId";
            this.lblDriverId.AutoSize = true;
            this.lblDriverId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDriverId.Location = new System.Drawing.Point(13, 196);
            this.lblDriverId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverId.Name = "lblDriverId";
            this.lblDriverId.Size = new System.Drawing.Size(34, 31);
            this.lblDriverId.TabIndex = 71;
            this.lblDriverId.Text = "Id";
            // 
            // lblDriverNIC
            // 
            this.lblDriverNIC.AccessibleName = "lblDriverNIC";
            this.lblDriverNIC.AutoSize = true;
            this.lblDriverNIC.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverNIC.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDriverNIC.Location = new System.Drawing.Point(13, 379);
            this.lblDriverNIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverNIC.Name = "lblDriverNIC";
            this.lblDriverNIC.Size = new System.Drawing.Size(52, 31);
            this.lblDriverNIC.TabIndex = 70;
            this.lblDriverNIC.Text = "NIC";
            // 
            // lblDriverName
            // 
            this.lblDriverName.AccessibleName = "lblDriverName";
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDriverName.Location = new System.Drawing.Point(13, 260);
            this.lblDriverName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(74, 31);
            this.lblDriverName.TabIndex = 69;
            this.lblDriverName.Text = "Name";
            // 
            // lblDriverGender
            // 
            this.lblDriverGender.AccessibleName = "lblDriverGender";
            this.lblDriverGender.AutoSize = true;
            this.lblDriverGender.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverGender.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDriverGender.Location = new System.Drawing.Point(13, 446);
            this.lblDriverGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverGender.Name = "lblDriverGender";
            this.lblDriverGender.Size = new System.Drawing.Size(92, 31);
            this.lblDriverGender.TabIndex = 87;
            this.lblDriverGender.Text = "Gender";
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.AccessibleName = "cmbBoxGender";
            this.cmbBoxGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cmbBoxGender.ForeColor = System.Drawing.Color.Goldenrod;
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbBoxGender.Location = new System.Drawing.Point(168, 446);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(219, 31);
            this.cmbBoxGender.TabIndex = 88;
            // 
            // lblDriverDob
            // 
            this.lblDriverDob.AccessibleName = "lblDriverDob";
            this.lblDriverDob.AutoSize = true;
            this.lblDriverDob.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverDob.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDriverDob.Location = new System.Drawing.Point(13, 505);
            this.lblDriverDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverDob.Name = "lblDriverDob";
            this.lblDriverDob.Size = new System.Drawing.Size(56, 31);
            this.lblDriverDob.TabIndex = 89;
            this.lblDriverDob.Text = "Age";
            // 
            // txtDriverAge
            // 
            this.txtDriverAge.AccessibleName = "txtDriverAge";
            this.txtDriverAge.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtDriverAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverAge.DefaultText = "";
            this.txtDriverAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDriverAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDriverAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDriverAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDriverAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDriverAge.Location = new System.Drawing.Point(168, 505);
            this.txtDriverAge.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDriverAge.Name = "txtDriverAge";
            this.txtDriverAge.PasswordChar = '\0';
            this.txtDriverAge.PlaceholderText = "";
            this.txtDriverAge.SelectedText = "";
            this.txtDriverAge.Size = new System.Drawing.Size(219, 36);
            this.txtDriverAge.TabIndex = 90;
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.txtDriverAge);
            this.Controls.Add(this.lblDriverDob);
            this.Controls.Add(this.cmbBoxGender);
            this.Controls.Add(this.lblDriverGender);
            this.Controls.Add(this.txtDriverLicenseNo);
            this.Controls.Add(this.txtDriverPhone);
            this.Controls.Add(this.txtDriverNIC);
            this.Controls.Add(this.txtDriverAddress);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.lblDriverPhone);
            this.Controls.Add(this.lblDriverLNo);
            this.Controls.Add(this.lblDriverAddress);
            this.Controls.Add(this.DriversListGridView);
            this.Controls.Add(this.btnBackDriver);
            this.Controls.Add(this.btnDltDriver);
            this.Controls.Add(this.btnEditDriver);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDriverId);
            this.Controls.Add(this.lblDriverId);
            this.Controls.Add(this.lblDriverNIC);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriversListGridView)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtDriverLicenseNo;
        private Guna.UI2.WinForms.Guna2TextBox txtDriverPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtDriverNIC;
        private Guna.UI2.WinForms.Guna2TextBox txtDriverAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtDriverName;
        private System.Windows.Forms.Label lblDriverPhone;
        private System.Windows.Forms.Label lblDriverLNo;
        private System.Windows.Forms.Label lblDriverAddress;
        private Guna.UI2.WinForms.Guna2DataGridView DriversListGridView;
        private System.Windows.Forms.Button btnBackDriver;
        private System.Windows.Forms.Button btnDltDriver;
        private System.Windows.Forms.Button btnEditDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDriverId;
        private System.Windows.Forms.Label lblDriverId;
        private System.Windows.Forms.Label lblDriverNIC;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblDriverGender;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.Label lblDriverDob;
        private Guna.UI2.WinForms.Guna2TextBox txtDriverAge;
    }
}