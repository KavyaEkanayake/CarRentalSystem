
namespace CarRentalSystem
{
    partial class Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CarListGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnBackCar = new System.Windows.Forms.Button();
            this.btnDltCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFuelType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbBoxAvailable = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarListGridView)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(498, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Cars";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 9);
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
            this.panel2.TabIndex = 27;
            // 
            // CarListGridView
            // 
            this.CarListGridView.AccessibleName = "CarListGridView";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.CarListGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CarListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarListGridView.BackgroundColor = System.Drawing.Color.White;
            this.CarListGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarListGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarListGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CarListGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CarListGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CarListGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.CarListGridView.EnableHeadersVisualStyles = false;
            this.CarListGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarListGridView.Location = new System.Drawing.Point(492, 203);
            this.CarListGridView.Name = "CarListGridView";
            this.CarListGridView.RowHeadersVisible = false;
            this.CarListGridView.RowHeadersWidth = 51;
            this.CarListGridView.RowTemplate.Height = 28;
            this.CarListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarListGridView.Size = new System.Drawing.Size(604, 638);
            this.CarListGridView.TabIndex = 39;
            this.CarListGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CarListGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CarListGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CarListGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CarListGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CarListGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CarListGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarListGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Goldenrod;
            this.CarListGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CarListGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarListGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CarListGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CarListGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.CarListGridView.ThemeStyle.ReadOnly = false;
            this.CarListGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CarListGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CarListGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarListGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarListGridView.ThemeStyle.RowsStyle.Height = 28;
            this.CarListGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CarListGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CarListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarListGridView_CellContentClick);
            // 
            // btnBackCar
            // 
            this.btnBackCar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBackCar.FlatAppearance.BorderSize = 0;
            this.btnBackCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackCar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCar.ForeColor = System.Drawing.Color.White;
            this.btnBackCar.Location = new System.Drawing.Point(162, 715);
            this.btnBackCar.Name = "btnBackCar";
            this.btnBackCar.Size = new System.Drawing.Size(103, 41);
            this.btnBackCar.TabIndex = 38;
            this.btnBackCar.Text = "Back";
            this.btnBackCar.UseVisualStyleBackColor = false;
            this.btnBackCar.Click += new System.EventHandler(this.btnBackCar_Click);
            // 
            // btnDltCar
            // 
            this.btnDltCar.AccessibleName = "btnBackCar";
            this.btnDltCar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDltCar.FlatAppearance.BorderSize = 0;
            this.btnDltCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDltCar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltCar.ForeColor = System.Drawing.Color.White;
            this.btnDltCar.Location = new System.Drawing.Point(271, 668);
            this.btnDltCar.Name = "btnDltCar";
            this.btnDltCar.Size = new System.Drawing.Size(103, 41);
            this.btnDltCar.TabIndex = 37;
            this.btnDltCar.Text = "DELETE";
            this.btnDltCar.UseVisualStyleBackColor = false;
            this.btnDltCar.Click += new System.EventHandler(this.btnDltCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.AccessibleName = "btnEditCar";
            this.btnEditCar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEditCar.FlatAppearance.BorderSize = 0;
            this.btnEditCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.ForeColor = System.Drawing.Color.White;
            this.btnEditCar.Location = new System.Drawing.Point(162, 668);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(103, 41);
            this.btnEditCar.TabIndex = 36;
            this.btnEditCar.Text = "EDIT";
            this.btnEditCar.UseVisualStyleBackColor = false;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.AccessibleName = "btnAddCar";
            this.btnAddCar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddCar.FlatAppearance.BorderSize = 0;
            this.btnAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.Location = new System.Drawing.Point(52, 668);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(104, 41);
            this.btnAddCar.TabIndex = 35;
            this.btnAddCar.Text = "ADD";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(744, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 33);
            this.label3.TabIndex = 34;
            this.label3.Text = "Cars List";
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
            this.txtCarId.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtCarId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCarId.Location = new System.Drawing.Point(155, 218);
            this.txtCarId.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.PasswordChar = '\0';
            this.txtCarId.PlaceholderText = "";
            this.txtCarId.SelectedText = "";
            this.txtCarId.Size = new System.Drawing.Size(219, 36);
            this.txtCarId.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(18, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "RegNo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(18, 343);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 31);
            this.label8.TabIndex = 29;
            this.label8.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(18, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(18, 400);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 31);
            this.label6.TabIndex = 40;
            this.label6.Text = "FuelType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(18, 530);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 42;
            this.label9.Text = "Available";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Goldenrod;
            this.label10.Location = new System.Drawing.Point(18, 466);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 31);
            this.label10.TabIndex = 44;
            this.label10.Text = "Price";
            // 
            // txtModel
            // 
            this.txtModel.AccessibleName = "txtModel";
            this.txtModel.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.DefaultText = "";
            this.txtModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtModel.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.Location = new System.Drawing.Point(155, 279);
            this.txtModel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.PlaceholderText = "";
            this.txtModel.SelectedText = "";
            this.txtModel.Size = new System.Drawing.Size(219, 36);
            this.txtModel.TabIndex = 45;
            // 
            // txtColor
            // 
            this.txtColor.AccessibleName = "txtColor";
            this.txtColor.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.DefaultText = "";
            this.txtColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtColor.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColor.Location = new System.Drawing.Point(155, 343);
            this.txtColor.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.PlaceholderText = "";
            this.txtColor.SelectedText = "";
            this.txtColor.Size = new System.Drawing.Size(219, 36);
            this.txtColor.TabIndex = 46;
            // 
            // txtFuelType
            // 
            this.txtFuelType.AccessibleName = "txtFuelType";
            this.txtFuelType.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtFuelType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFuelType.DefaultText = "";
            this.txtFuelType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFuelType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFuelType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuelType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuelType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuelType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtFuelType.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtFuelType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuelType.Location = new System.Drawing.Point(155, 405);
            this.txtFuelType.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.PasswordChar = '\0';
            this.txtFuelType.PlaceholderText = "";
            this.txtFuelType.SelectedText = "";
            this.txtFuelType.Size = new System.Drawing.Size(219, 36);
            this.txtFuelType.TabIndex = 47;
            // 
            // txtPrice
            // 
            this.txtPrice.AccessibleName = "txtPrice";
            this.txtPrice.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(155, 466);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(219, 36);
            this.txtPrice.TabIndex = 49;
            // 
            // cmbBoxAvailable
            // 
            this.cmbBoxAvailable.AccessibleName = "cmbBoxAvailable";
            this.cmbBoxAvailable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cmbBoxAvailable.ForeColor = System.Drawing.Color.Goldenrod;
            this.cmbBoxAvailable.FormattingEnabled = true;
            this.cmbBoxAvailable.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbBoxAvailable.Location = new System.Drawing.Point(155, 533);
            this.cmbBoxAvailable.Name = "cmbBoxAvailable";
            this.cmbBoxAvailable.Size = new System.Drawing.Size(219, 31);
            this.cmbBoxAvailable.TabIndex = 50;
            // 
            // Search
            // 
            this.Search.AccessibleName = "Search";
            this.Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.Goldenrod;
            this.Search.FormattingEnabled = true;
            this.Search.Items.AddRange(new object[] {
            "Available",
            "Rented"});
            this.Search.Location = new System.Drawing.Point(629, 166);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(219, 31);
            this.Search.TabIndex = 51;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleName = "btnRefresh";
            this.btnRefresh.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(854, 166);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 31);
            this.btnRefresh.TabIndex = 52;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 900);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.cmbBoxAvailable);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CarListGridView);
            this.Controls.Add(this.btnBackCar);
            this.Controls.Add(this.btnDltCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarListGridView)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView CarListGridView;
        private System.Windows.Forms.Button btnBackCar;
        private System.Windows.Forms.Button btnDltCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCarId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtModel;
        private Guna.UI2.WinForms.Guna2TextBox txtColor;
        private Guna.UI2.WinForms.Guna2TextBox txtFuelType;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbBoxAvailable;
        private System.Windows.Forms.ComboBox Search;
        private System.Windows.Forms.Button btnRefresh;
    }
}