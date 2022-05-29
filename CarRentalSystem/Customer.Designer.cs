
namespace CarRentalSystem
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.CustomersListGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBackCust = new System.Windows.Forms.Button();
            this.btnDltCust = new System.Windows.Forms.Button();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblCustLName = new System.Windows.Forms.Label();
            this.lblCustFName = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersListGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1130, 100);
            this.panel1.TabIndex = 3;
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
            this.lblExit.Location = new System.Drawing.Point(1090, 9);
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
            this.label5.Location = new System.Drawing.Point(489, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 9);
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
            this.panel2.Size = new System.Drawing.Size(1130, 15);
            this.panel2.TabIndex = 28;
            // 
            // txtPhone
            // 
            this.txtPhone.AccessibleName = "txtPhone";
            this.txtPhone.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(156, 450);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(219, 36);
            this.txtPhone.TabIndex = 67;
            // 
            // txtAddress
            // 
            this.txtAddress.AccessibleName = "txtAddress";
            this.txtAddress.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(156, 386);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(219, 36);
            this.txtAddress.TabIndex = 66;
            // 
            // txtLastName
            // 
            this.txtLastName.AccessibleName = "txtLastName";
            this.txtLastName.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(156, 324);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(219, 36);
            this.txtLastName.TabIndex = 65;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AccessibleName = "txtFirstName";
            this.txtFirstName.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(156, 262);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(219, 36);
            this.txtFirstName.TabIndex = 64;
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AccessibleName = "lblCustPhone";
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPhone.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustPhone.Location = new System.Drawing.Point(19, 450);
            this.lblCustPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(83, 31);
            this.lblCustPhone.TabIndex = 63;
            this.lblCustPhone.Text = "Phone";
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AccessibleName = "lblCustEmail";
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustEmail.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustEmail.Location = new System.Drawing.Point(16, 516);
            this.lblCustEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(73, 31);
            this.lblCustEmail.TabIndex = 62;
            this.lblCustEmail.Text = "Email";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AccessibleName = "lblCustAddress";
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustAddress.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustAddress.Location = new System.Drawing.Point(19, 381);
            this.lblCustAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(103, 31);
            this.lblCustAddress.TabIndex = 61;
            this.lblCustAddress.Text = "Address";
            // 
            // CustomersListGridView
            // 
            this.CustomersListGridView.AccessibleName = "CustomersListGridView";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomersListGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomersListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersListGridView.BackgroundColor = System.Drawing.Color.White;
            this.CustomersListGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomersListGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomersListGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersListGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomersListGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersListGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomersListGridView.EnableHeadersVisualStyles = false;
            this.CustomersListGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersListGridView.Location = new System.Drawing.Point(486, 156);
            this.CustomersListGridView.Name = "CustomersListGridView";
            this.CustomersListGridView.RowHeadersVisible = false;
            this.CustomersListGridView.RowHeadersWidth = 51;
            this.CustomersListGridView.RowTemplate.Height = 28;
            this.CustomersListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersListGridView.Size = new System.Drawing.Size(604, 638);
            this.CustomersListGridView.TabIndex = 60;
            this.CustomersListGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersListGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomersListGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomersListGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomersListGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomersListGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomersListGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersListGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Goldenrod;
            this.CustomersListGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomersListGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersListGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomersListGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomersListGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.CustomersListGridView.ThemeStyle.ReadOnly = false;
            this.CustomersListGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersListGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomersListGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersListGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomersListGridView.ThemeStyle.RowsStyle.Height = 28;
            this.CustomersListGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersListGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomersListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersListGridView_CellContentClick);
            // 
            // btnBackCust
            // 
            this.btnBackCust.AccessibleName = "btnBackCust";
            this.btnBackCust.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBackCust.FlatAppearance.BorderSize = 0;
            this.btnBackCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackCust.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCust.ForeColor = System.Drawing.Color.White;
            this.btnBackCust.Location = new System.Drawing.Point(163, 711);
            this.btnBackCust.Name = "btnBackCust";
            this.btnBackCust.Size = new System.Drawing.Size(103, 41);
            this.btnBackCust.TabIndex = 59;
            this.btnBackCust.Text = "Back";
            this.btnBackCust.UseVisualStyleBackColor = false;
            this.btnBackCust.Click += new System.EventHandler(this.btnBackCust_Click);
            // 
            // btnDltCust
            // 
            this.btnDltCust.AccessibleName = "btnDltCust";
            this.btnDltCust.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDltCust.FlatAppearance.BorderSize = 0;
            this.btnDltCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDltCust.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltCust.ForeColor = System.Drawing.Color.White;
            this.btnDltCust.Location = new System.Drawing.Point(272, 664);
            this.btnDltCust.Name = "btnDltCust";
            this.btnDltCust.Size = new System.Drawing.Size(103, 41);
            this.btnDltCust.TabIndex = 58;
            this.btnDltCust.Text = "DELETE";
            this.btnDltCust.UseVisualStyleBackColor = false;
            this.btnDltCust.Click += new System.EventHandler(this.btnDltCust_Click);
            // 
            // btnEditCust
            // 
            this.btnEditCust.AccessibleName = "btnEditCust";
            this.btnEditCust.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditCust.FlatAppearance.BorderSize = 0;
            this.btnEditCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCust.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCust.ForeColor = System.Drawing.Color.White;
            this.btnEditCust.Location = new System.Drawing.Point(163, 664);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(103, 41);
            this.btnEditCust.TabIndex = 57;
            this.btnEditCust.Text = "EDIT";
            this.btnEditCust.UseVisualStyleBackColor = false;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.AccessibleName = "btnAddCust";
            this.btnAddCust.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddCust.FlatAppearance.BorderSize = 0;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCust.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.Color.White;
            this.btnAddCust.Location = new System.Drawing.Point(53, 664);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(104, 41);
            this.btnAddCust.TabIndex = 56;
            this.btnAddCust.Text = "ADD";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(713, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 33);
            this.label3.TabIndex = 55;
            this.label3.Text = "Customers List";
            // 
            // txtCustId
            // 
            this.txtCustId.AccessibleName = "txtCustId";
            this.txtCustId.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtCustId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustId.DefaultText = "";
            this.txtCustId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtCustId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustId.Location = new System.Drawing.Point(156, 198);
            this.txtCustId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.PasswordChar = '\0';
            this.txtCustId.PlaceholderText = "";
            this.txtCustId.SelectedText = "";
            this.txtCustId.Size = new System.Drawing.Size(219, 36);
            this.txtCustId.TabIndex = 54;
            // 
            // lblCustId
            // 
            this.lblCustId.AccessibleName = "lblCustId";
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustId.Location = new System.Drawing.Point(19, 203);
            this.lblCustId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(34, 31);
            this.lblCustId.TabIndex = 53;
            this.lblCustId.Text = "Id";
            // 
            // lblCustLName
            // 
            this.lblCustLName.AccessibleName = "lblCustLName";
            this.lblCustLName.AutoSize = true;
            this.lblCustLName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustLName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustLName.Location = new System.Drawing.Point(19, 319);
            this.lblCustLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustLName.Name = "lblCustLName";
            this.lblCustLName.Size = new System.Drawing.Size(119, 31);
            this.lblCustLName.TabIndex = 52;
            this.lblCustLName.Text = "LastName";
            // 
            // lblCustFName
            // 
            this.lblCustFName.AccessibleName = "lblCustFName";
            this.lblCustFName.AutoSize = true;
            this.lblCustFName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustFName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustFName.Location = new System.Drawing.Point(19, 262);
            this.lblCustFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustFName.Name = "lblCustFName";
            this.lblCustFName.Size = new System.Drawing.Size(122, 31);
            this.lblCustFName.TabIndex = 51;
            this.lblCustFName.Text = "FirstName";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = "txtEmail";
            this.txtEmail.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(156, 516);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(219, 36);
            this.txtEmail.TabIndex = 68;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 900);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.lblCustEmail);
            this.Controls.Add(this.lblCustAddress);
            this.Controls.Add(this.CustomersListGridView);
            this.Controls.Add(this.btnBackCust);
            this.Controls.Add(this.btnDltCust);
            this.Controls.Add(this.btnEditCust);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.lblCustLName);
            this.Controls.Add(this.lblCustFName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersListGridView)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.Label lblCustAddress;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersListGridView;
        private System.Windows.Forms.Button btnBackCust;
        private System.Windows.Forms.Button btnDltCust;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCustId;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblCustLName;
        private System.Windows.Forms.Label lblCustFName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}