
namespace CarRentalSystem
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtDelay = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.ReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.txtFine = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.btnBackReturn = new System.Windows.Forms.Button();
            this.btnDltReturn = new System.Windows.Forms.Button();
            this.btnEditReturn = new System.Windows.Forms.Button();
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.txtReturnId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblReturnId = new System.Windows.Forms.Label();
            this.lblCarId = new System.Windows.Forms.Label();
            this.txtCarId = new Guna.UI2.WinForms.Guna2TextBox();
            this.CarsOnRentGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsOnRentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 885);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 15);
            this.panel2.TabIndex = 31;
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
            this.panel1.TabIndex = 32;
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
            this.label5.Location = new System.Drawing.Point(531, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Return";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "CAR RENTAL MANAGEMENT SYSTEM";
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
            this.txtCustName.Location = new System.Drawing.Point(184, 340);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.PasswordChar = '\0';
            this.txtCustName.PlaceholderText = "";
            this.txtCustName.SelectedText = "";
            this.txtCustName.Size = new System.Drawing.Size(219, 36);
            this.txtCustName.TabIndex = 97;
            // 
            // lblCustName
            // 
            this.lblCustName.AccessibleName = "lblCustName";
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustName.Location = new System.Drawing.Point(27, 345);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(74, 31);
            this.lblCustName.TabIndex = 96;
            this.lblCustName.Text = "Name";
            // 
            // txtDelay
            // 
            this.txtDelay.AccessibleName = "txtDelay";
            this.txtDelay.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtDelay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDelay.DefaultText = "";
            this.txtDelay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDelay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDelay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDelay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDelay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDelay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtDelay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDelay.Location = new System.Drawing.Point(184, 464);
            this.txtDelay.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.PasswordChar = '\0';
            this.txtDelay.PlaceholderText = "";
            this.txtDelay.SelectedText = "";
            this.txtDelay.Size = new System.Drawing.Size(219, 36);
            this.txtDelay.TabIndex = 95;
            // 
            // lblDelay
            // 
            this.lblDelay.AccessibleName = "lblDelay";
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelay.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDelay.Location = new System.Drawing.Point(27, 469);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(72, 31);
            this.lblDelay.TabIndex = 94;
            this.lblDelay.Text = "Delay";
            // 
            // ReturnDate
            // 
            this.ReturnDate.AccessibleName = "ReturnDate";
            this.ReturnDate.Checked = true;
            this.ReturnDate.FillColor = System.Drawing.Color.Goldenrod;
            this.ReturnDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.ForeColor = System.Drawing.Color.White;
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ReturnDate.Location = new System.Drawing.Point(184, 402);
            this.ReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(219, 36);
            this.ReturnDate.TabIndex = 93;
            this.ReturnDate.Value = new System.DateTime(2022, 5, 8, 12, 37, 59, 37);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AccessibleName = "lblReturnDate";
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblReturnDate.Location = new System.Drawing.Point(27, 407);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(139, 31);
            this.lblReturnDate.TabIndex = 92;
            this.lblReturnDate.Text = "Return Date";
            // 
            // txtFine
            // 
            this.txtFine.AccessibleName = "txtFine";
            this.txtFine.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtFine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFine.DefaultText = "";
            this.txtFine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtFine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFine.Location = new System.Drawing.Point(184, 531);
            this.txtFine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFine.Name = "txtFine";
            this.txtFine.PasswordChar = '\0';
            this.txtFine.PlaceholderText = "";
            this.txtFine.SelectedText = "";
            this.txtFine.Size = new System.Drawing.Size(219, 36);
            this.txtFine.TabIndex = 89;
            // 
            // lblFine
            // 
            this.lblFine.AccessibleName = "lblFine";
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblFine.Location = new System.Drawing.Point(27, 536);
            this.lblFine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(60, 31);
            this.lblFine.TabIndex = 87;
            this.lblFine.Text = "Fine";
            this.lblFine.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnBackReturn
            // 
            this.btnBackReturn.AccessibleName = "btnBackReturn";
            this.btnBackReturn.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBackReturn.FlatAppearance.BorderSize = 0;
            this.btnBackReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackReturn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackReturn.ForeColor = System.Drawing.Color.White;
            this.btnBackReturn.Location = new System.Drawing.Point(191, 705);
            this.btnBackReturn.Name = "btnBackReturn";
            this.btnBackReturn.Size = new System.Drawing.Size(103, 41);
            this.btnBackReturn.TabIndex = 85;
            this.btnBackReturn.Text = "Back";
            this.btnBackReturn.UseVisualStyleBackColor = false;
            this.btnBackReturn.Click += new System.EventHandler(this.btnBackReturn_Click);
            // 
            // btnDltReturn
            // 
            this.btnDltReturn.AccessibleName = "btnBackReturn";
            this.btnDltReturn.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDltReturn.FlatAppearance.BorderSize = 0;
            this.btnDltReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDltReturn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltReturn.ForeColor = System.Drawing.Color.White;
            this.btnDltReturn.Location = new System.Drawing.Point(300, 658);
            this.btnDltReturn.Name = "btnDltReturn";
            this.btnDltReturn.Size = new System.Drawing.Size(103, 41);
            this.btnDltReturn.TabIndex = 84;
            this.btnDltReturn.Text = "DELETE";
            this.btnDltReturn.UseVisualStyleBackColor = false;
            // 
            // btnEditReturn
            // 
            this.btnEditReturn.AccessibleName = "btnEditReturn";
            this.btnEditReturn.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditReturn.FlatAppearance.BorderSize = 0;
            this.btnEditReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditReturn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReturn.ForeColor = System.Drawing.Color.White;
            this.btnEditReturn.Location = new System.Drawing.Point(191, 658);
            this.btnEditReturn.Name = "btnEditReturn";
            this.btnEditReturn.Size = new System.Drawing.Size(103, 41);
            this.btnEditReturn.TabIndex = 83;
            this.btnEditReturn.Text = "EDIT";
            this.btnEditReturn.UseVisualStyleBackColor = false;
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.AccessibleName = "btnAddReturn";
            this.btnAddReturn.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddReturn.FlatAppearance.BorderSize = 0;
            this.btnAddReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReturn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReturn.ForeColor = System.Drawing.Color.White;
            this.btnAddReturn.Location = new System.Drawing.Point(81, 658);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(104, 41);
            this.btnAddReturn.TabIndex = 82;
            this.btnAddReturn.Text = "ADD";
            this.btnAddReturn.UseVisualStyleBackColor = false;
            // 
            // txtReturnId
            // 
            this.txtReturnId.AccessibleName = "txtReturnId";
            this.txtReturnId.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtReturnId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReturnId.DefaultText = "";
            this.txtReturnId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReturnId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReturnId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReturnId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReturnId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReturnId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtReturnId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReturnId.Location = new System.Drawing.Point(184, 209);
            this.txtReturnId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtReturnId.Name = "txtReturnId";
            this.txtReturnId.PasswordChar = '\0';
            this.txtReturnId.PlaceholderText = "";
            this.txtReturnId.SelectedText = "";
            this.txtReturnId.Size = new System.Drawing.Size(219, 36);
            this.txtReturnId.TabIndex = 81;
            // 
            // lblReturnId
            // 
            this.lblReturnId.AccessibleName = "lblReturnId";
            this.lblReturnId.AutoSize = true;
            this.lblReturnId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblReturnId.Location = new System.Drawing.Point(27, 214);
            this.lblReturnId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnId.Name = "lblReturnId";
            this.lblReturnId.Size = new System.Drawing.Size(34, 31);
            this.lblReturnId.TabIndex = 80;
            this.lblReturnId.Text = "Id";
            // 
            // lblCarId
            // 
            this.lblCarId.AccessibleName = "lblCarId";
            this.lblCarId.AutoSize = true;
            this.lblCarId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCarId.Location = new System.Drawing.Point(27, 280);
            this.lblCarId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(71, 31);
            this.lblCarId.TabIndex = 78;
            this.lblCarId.Text = "CarId";
            // 
            // txtCarId
            // 
            this.txtCarId.AccessibleName = "txtCarId";
            this.txtCarId.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtCarId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarId.DefaultText = "";
            this.txtCarId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCarId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCarId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCarId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtCarId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarId.Location = new System.Drawing.Point(184, 275);
            this.txtCarId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.PasswordChar = '\0';
            this.txtCarId.PlaceholderText = "";
            this.txtCarId.SelectedText = "";
            this.txtCarId.Size = new System.Drawing.Size(219, 36);
            this.txtCarId.TabIndex = 100;
            // 
            // CarsOnRentGridView
            // 
            this.CarsOnRentGridView.AccessibleName = "CarsOnRentGridView";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CarsOnRentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CarsOnRentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarsOnRentGridView.BackgroundColor = System.Drawing.Color.White;
            this.CarsOnRentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsOnRentGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarsOnRentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarsOnRentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CarsOnRentGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarsOnRentGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CarsOnRentGridView.EnableHeadersVisualStyles = false;
            this.CarsOnRentGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarsOnRentGridView.Location = new System.Drawing.Point(469, 156);
            this.CarsOnRentGridView.Name = "CarsOnRentGridView";
            this.CarsOnRentGridView.RowHeadersVisible = false;
            this.CarsOnRentGridView.RowHeadersWidth = 51;
            this.CarsOnRentGridView.RowTemplate.Height = 28;
            this.CarsOnRentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarsOnRentGridView.Size = new System.Drawing.Size(646, 256);
            this.CarsOnRentGridView.TabIndex = 102;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(723, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 101;
            this.label3.Text = "Cars on Rent";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AccessibleName = "CarsOnRentGridView";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(469, 490);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(646, 256);
            this.guna2DataGridView1.TabIndex = 104;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Goldenrod;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(723, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 103;
            this.label2.Text = "Cars Returned";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 900);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarsOnRentGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.btnBackReturn);
            this.Controls.Add(this.btnDltReturn);
            this.Controls.Add(this.btnEditReturn);
            this.Controls.Add(this.btnAddReturn);
            this.Controls.Add(this.txtReturnId);
            this.Controls.Add(this.lblReturnId);
            this.Controls.Add(this.lblCarId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsOnRentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private Guna.UI2.WinForms.Guna2TextBox txtDelay;
        private System.Windows.Forms.Label lblDelay;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private Guna.UI2.WinForms.Guna2TextBox txtFine;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Button btnBackReturn;
        private System.Windows.Forms.Button btnDltReturn;
        private System.Windows.Forms.Button btnEditReturn;
        private System.Windows.Forms.Button btnAddReturn;
        private Guna.UI2.WinForms.Guna2TextBox txtReturnId;
        private System.Windows.Forms.Label lblReturnId;
        private System.Windows.Forms.Label lblCarId;
        private Guna.UI2.WinForms.Guna2TextBox txtCarId;
        private Guna.UI2.WinForms.Guna2DataGridView CarsOnRentGridView;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label label2;
    }
}