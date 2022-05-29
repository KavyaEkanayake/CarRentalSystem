
namespace CarRentalSystem
{
    partial class CarOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarOwner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBank = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOwnerPhone = new System.Windows.Forms.Label();
            this.lblOwnerBank = new System.Windows.Forms.Label();
            this.lblOwnerAddress = new System.Windows.Forms.Label();
            this.OwnersListGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBackOwner = new System.Windows.Forms.Button();
            this.btnDltOwner = new System.Windows.Forms.Button();
            this.btnEditOwner = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOwnerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOwnerId = new System.Windows.Forms.Label();
            this.lblOwnerAccNo = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.cmbBoxCarReg = new System.Windows.Forms.ComboBox();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnersListGridView)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(478, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Car Owners";
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
            this.panel2.TabIndex = 30;
            // 
            // txtBank
            // 
            this.txtBank.AccessibleName = "txtBank";
            this.txtBank.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtBank.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBank.DefaultText = "";
            this.txtBank.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBank.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBank.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBank.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBank.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtBank.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBank.Location = new System.Drawing.Point(175, 512);
            this.txtBank.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBank.Name = "txtBank";
            this.txtBank.PasswordChar = '\0';
            this.txtBank.PlaceholderText = "";
            this.txtBank.SelectedText = "";
            this.txtBank.Size = new System.Drawing.Size(219, 36);
            this.txtBank.TabIndex = 86;
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
            this.txtPhone.Location = new System.Drawing.Point(175, 447);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(219, 36);
            this.txtPhone.TabIndex = 85;
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
            this.txtAddress.Location = new System.Drawing.Point(175, 380);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(219, 36);
            this.txtAddress.TabIndex = 84;
            // 
            // txtAccNo
            // 
            this.txtAccNo.AccessibleName = "txtAccNo";
            this.txtAccNo.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtAccNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccNo.DefaultText = "";
            this.txtAccNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtAccNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccNo.Location = new System.Drawing.Point(175, 578);
            this.txtAccNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.PasswordChar = '\0';
            this.txtAccNo.PlaceholderText = "";
            this.txtAccNo.SelectedText = "";
            this.txtAccNo.Size = new System.Drawing.Size(219, 36);
            this.txtAccNo.TabIndex = 83;
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "txtName";
            this.txtName.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(175, 313);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(219, 36);
            this.txtName.TabIndex = 82;
            // 
            // lblOwnerPhone
            // 
            this.lblOwnerPhone.AccessibleName = "lblOwnerPhone";
            this.lblOwnerPhone.AutoSize = true;
            this.lblOwnerPhone.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerPhone.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblOwnerPhone.Location = new System.Drawing.Point(28, 452);
            this.lblOwnerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerPhone.Name = "lblOwnerPhone";
            this.lblOwnerPhone.Size = new System.Drawing.Size(83, 31);
            this.lblOwnerPhone.TabIndex = 81;
            this.lblOwnerPhone.Text = "Phone";
            // 
            // lblOwnerBank
            // 
            this.lblOwnerBank.AccessibleName = "lblOwnerBank";
            this.lblOwnerBank.AutoSize = true;
            this.lblOwnerBank.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerBank.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblOwnerBank.Location = new System.Drawing.Point(28, 512);
            this.lblOwnerBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerBank.Name = "lblOwnerBank";
            this.lblOwnerBank.Size = new System.Drawing.Size(68, 31);
            this.lblOwnerBank.TabIndex = 80;
            this.lblOwnerBank.Text = "Bank";
            // 
            // lblOwnerAddress
            // 
            this.lblOwnerAddress.AccessibleName = "lblOwnerAddress";
            this.lblOwnerAddress.AutoSize = true;
            this.lblOwnerAddress.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerAddress.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblOwnerAddress.Location = new System.Drawing.Point(28, 385);
            this.lblOwnerAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerAddress.Name = "lblOwnerAddress";
            this.lblOwnerAddress.Size = new System.Drawing.Size(103, 31);
            this.lblOwnerAddress.TabIndex = 79;
            this.lblOwnerAddress.Text = "Address";
            // 
            // OwnersListGridView
            // 
            this.OwnersListGridView.AccessibleName = "OwnersListGridView";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.OwnersListGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.OwnersListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OwnersListGridView.BackgroundColor = System.Drawing.Color.White;
            this.OwnersListGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OwnersListGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OwnersListGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OwnersListGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.OwnersListGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OwnersListGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.OwnersListGridView.EnableHeadersVisualStyles = false;
            this.OwnersListGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OwnersListGridView.Location = new System.Drawing.Point(486, 156);
            this.OwnersListGridView.Name = "OwnersListGridView";
            this.OwnersListGridView.RowHeadersVisible = false;
            this.OwnersListGridView.RowHeadersWidth = 51;
            this.OwnersListGridView.RowTemplate.Height = 28;
            this.OwnersListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OwnersListGridView.Size = new System.Drawing.Size(604, 638);
            this.OwnersListGridView.TabIndex = 78;
            this.OwnersListGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OwnersListGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OwnersListGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OwnersListGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OwnersListGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OwnersListGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OwnersListGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OwnersListGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Goldenrod;
            this.OwnersListGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OwnersListGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnersListGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OwnersListGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OwnersListGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.OwnersListGridView.ThemeStyle.ReadOnly = false;
            this.OwnersListGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OwnersListGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OwnersListGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnersListGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OwnersListGridView.ThemeStyle.RowsStyle.Height = 28;
            this.OwnersListGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OwnersListGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OwnersListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OwnersListGridView_CellContentClick);
            // 
            // btnBackOwner
            // 
            this.btnBackOwner.AccessibleName = "btnBackOwner";
            this.btnBackOwner.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBackOwner.FlatAppearance.BorderSize = 0;
            this.btnBackOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackOwner.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOwner.ForeColor = System.Drawing.Color.White;
            this.btnBackOwner.Location = new System.Drawing.Point(182, 729);
            this.btnBackOwner.Name = "btnBackOwner";
            this.btnBackOwner.Size = new System.Drawing.Size(103, 41);
            this.btnBackOwner.TabIndex = 77;
            this.btnBackOwner.Text = "Back";
            this.btnBackOwner.UseVisualStyleBackColor = false;
            this.btnBackOwner.Click += new System.EventHandler(this.btnBackOwner_Click);
            // 
            // btnDltOwner
            // 
            this.btnDltOwner.AccessibleName = "btnDltOwner";
            this.btnDltOwner.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDltOwner.FlatAppearance.BorderSize = 0;
            this.btnDltOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDltOwner.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltOwner.ForeColor = System.Drawing.Color.White;
            this.btnDltOwner.Location = new System.Drawing.Point(291, 682);
            this.btnDltOwner.Name = "btnDltOwner";
            this.btnDltOwner.Size = new System.Drawing.Size(103, 41);
            this.btnDltOwner.TabIndex = 76;
            this.btnDltOwner.Text = "DELETE";
            this.btnDltOwner.UseVisualStyleBackColor = false;
            this.btnDltOwner.Click += new System.EventHandler(this.btnDltOwner_Click);
            // 
            // btnEditOwner
            // 
            this.btnEditOwner.AccessibleName = "btnEditOwner";
            this.btnEditOwner.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditOwner.FlatAppearance.BorderSize = 0;
            this.btnEditOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOwner.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOwner.ForeColor = System.Drawing.Color.White;
            this.btnEditOwner.Location = new System.Drawing.Point(182, 682);
            this.btnEditOwner.Name = "btnEditOwner";
            this.btnEditOwner.Size = new System.Drawing.Size(103, 41);
            this.btnEditOwner.TabIndex = 75;
            this.btnEditOwner.Text = "EDIT";
            this.btnEditOwner.UseVisualStyleBackColor = false;
            this.btnEditOwner.Click += new System.EventHandler(this.btnEditOwner_Click);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.AccessibleName = "btnAddOwner";
            this.btnAddOwner.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddOwner.FlatAppearance.BorderSize = 0;
            this.btnAddOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOwner.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOwner.ForeColor = System.Drawing.Color.White;
            this.btnAddOwner.Location = new System.Drawing.Point(72, 682);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(104, 41);
            this.btnAddOwner.TabIndex = 74;
            this.btnAddOwner.Text = "ADD";
            this.btnAddOwner.UseVisualStyleBackColor = false;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(718, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 33);
            this.label3.TabIndex = 73;
            this.label3.Text = "Car Owners List";
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.AccessibleName = "txtOwnerId";
            this.txtOwnerId.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtOwnerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwnerId.DefaultText = "";
            this.txtOwnerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOwnerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOwnerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwnerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOwnerId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnerId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtOwnerId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOwnerId.Location = new System.Drawing.Point(175, 204);
            this.txtOwnerId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.PasswordChar = '\0';
            this.txtOwnerId.PlaceholderText = "";
            this.txtOwnerId.SelectedText = "";
            this.txtOwnerId.Size = new System.Drawing.Size(219, 36);
            this.txtOwnerId.TabIndex = 72;
            // 
            // lblOwnerId
            // 
            this.lblOwnerId.AccessibleName = "lblOwnerId";
            this.lblOwnerId.AutoSize = true;
            this.lblOwnerId.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblOwnerId.Location = new System.Drawing.Point(28, 209);
            this.lblOwnerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerId.Name = "lblOwnerId";
            this.lblOwnerId.Size = new System.Drawing.Size(34, 31);
            this.lblOwnerId.TabIndex = 71;
            this.lblOwnerId.Text = "Id";
            // 
            // lblOwnerAccNo
            // 
            this.lblOwnerAccNo.AccessibleName = "lblOwnerAccNo";
            this.lblOwnerAccNo.AutoSize = true;
            this.lblOwnerAccNo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerAccNo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblOwnerAccNo.Location = new System.Drawing.Point(28, 578);
            this.lblOwnerAccNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerAccNo.Name = "lblOwnerAccNo";
            this.lblOwnerAccNo.Size = new System.Drawing.Size(84, 31);
            this.lblOwnerAccNo.TabIndex = 70;
            this.lblOwnerAccNo.Text = "AccNo";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AccessibleName = "lblOwnerName";
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblOwnerName.Location = new System.Drawing.Point(28, 318);
            this.lblOwnerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(74, 31);
            this.lblOwnerName.TabIndex = 69;
            this.lblOwnerName.Text = "Name";
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
            this.cmbBoxCarReg.Location = new System.Drawing.Point(175, 261);
            this.cmbBoxCarReg.Name = "cmbBoxCarReg";
            this.cmbBoxCarReg.Size = new System.Drawing.Size(219, 31);
            this.cmbBoxCarReg.TabIndex = 88;
            this.cmbBoxCarReg.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxCarReg_SelectionChangeCommitted);
            // 
            // lblCarReg
            // 
            this.lblCarReg.AccessibleName = "lblCarReg";
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCarReg.Location = new System.Drawing.Point(29, 261);
            this.lblCarReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(93, 31);
            this.lblCarReg.TabIndex = 87;
            this.lblCarReg.Text = "CarReg";
            // 
            // CarOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 900);
            this.Controls.Add(this.cmbBoxCarReg);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOwnerPhone);
            this.Controls.Add(this.lblOwnerBank);
            this.Controls.Add(this.lblOwnerAddress);
            this.Controls.Add(this.OwnersListGridView);
            this.Controls.Add(this.btnBackOwner);
            this.Controls.Add(this.btnDltOwner);
            this.Controls.Add(this.btnEditOwner);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOwnerId);
            this.Controls.Add(this.lblOwnerId);
            this.Controls.Add(this.lblOwnerAccNo);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarOwner";
            this.Load += new System.EventHandler(this.CarOwner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OwnersListGridView)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtBank;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtAccNo;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblOwnerPhone;
        private System.Windows.Forms.Label lblOwnerBank;
        private System.Windows.Forms.Label lblOwnerAddress;
        private Guna.UI2.WinForms.Guna2DataGridView OwnersListGridView;
        private System.Windows.Forms.Button btnBackOwner;
        private System.Windows.Forms.Button btnDltOwner;
        private System.Windows.Forms.Button btnEditOwner;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtOwnerId;
        private System.Windows.Forms.Label lblOwnerId;
        private System.Windows.Forms.Label lblOwnerAccNo;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.ComboBox cmbBoxCarReg;
        private System.Windows.Forms.Label lblCarReg;
    }
}