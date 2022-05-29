
namespace CarRentalSystem
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.myCar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.myProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).BeginInit();
            this.myProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // myCar
            // 
            this.myCar.Image = ((System.Drawing.Image)(resources.GetObject("myCar.Image")));
            this.myCar.ImageRotate = 0F;
            this.myCar.Location = new System.Drawing.Point(26, 45);
            this.myCar.Margin = new System.Windows.Forms.Padding(2);
            this.myCar.Name = "myCar";
            this.myCar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myCar.Size = new System.Drawing.Size(142, 102);
            this.myCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCar.TabIndex = 0;
            this.myCar.TabStop = false;
            this.myCar.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // myProgress
            // 
            this.myProgress.Controls.Add(this.lblPercentage);
            this.myProgress.Controls.Add(this.myCar);
            this.myProgress.FillColor = System.Drawing.Color.Goldenrod;
            this.myProgress.FillThickness = 8;
            this.myProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.myProgress.ForeColor = System.Drawing.Color.White;
            this.myProgress.Location = new System.Drawing.Point(217, 68);
            this.myProgress.Minimum = 0;
            this.myProgress.Name = "myProgress";
            this.myProgress.ProgressColor = System.Drawing.Color.White;
            this.myProgress.ProgressColor2 = System.Drawing.Color.White;
            this.myProgress.ProgressThickness = 8;
            this.myProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myProgress.Size = new System.Drawing.Size(193, 193);
            this.myProgress.TabIndex = 1;
            this.myProgress.Text = "guna2CircleProgressBar1";
            this.myProgress.ValueChanged += new System.EventHandler(this.myProgress_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AccessibleName = "lblPercentage";
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(81, 133);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(28, 25);
            this.lblPercentage.TabIndex = 1;
            this.lblPercentage.Text = "%";
            this.lblPercentage.Click += new System.EventHandler(this.lblPercentage_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(623, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myProgress);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).EndInit();
            this.myProgress.ResumeLayout(false);
            this.myProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox myCar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar myProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPercentage;
    }
}

