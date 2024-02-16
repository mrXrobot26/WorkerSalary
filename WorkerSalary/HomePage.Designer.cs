namespace WorkerSalary
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_goHomeScreen = new System.Windows.Forms.Button();
            this.btn_goSalary = new System.Windows.Forms.Button();
            this.btn_goEmployee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.btn_goHomeScreen);
            this.panel1.Controls.Add(this.btn_goSalary);
            this.panel1.Controls.Add(this.btn_goEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 788);
            this.panel1.TabIndex = 1;
            // 
            // btn_goHomeScreen
            // 
            this.btn_goHomeScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.btn_goHomeScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goHomeScreen.ForeColor = System.Drawing.Color.White;
            this.btn_goHomeScreen.Location = new System.Drawing.Point(3, 12);
            this.btn_goHomeScreen.Name = "btn_goHomeScreen";
            this.btn_goHomeScreen.Size = new System.Drawing.Size(303, 92);
            this.btn_goHomeScreen.TabIndex = 2;
            this.btn_goHomeScreen.Text = "الصفحه الرئيسيه";
            this.btn_goHomeScreen.UseVisualStyleBackColor = false;
            // 
            // btn_goSalary
            // 
            this.btn_goSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.btn_goSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goSalary.ForeColor = System.Drawing.Color.White;
            this.btn_goSalary.Location = new System.Drawing.Point(3, 208);
            this.btn_goSalary.Name = "btn_goSalary";
            this.btn_goSalary.Size = new System.Drawing.Size(303, 92);
            this.btn_goSalary.TabIndex = 1;
            this.btn_goSalary.Text = "الراتب";
            this.btn_goSalary.UseVisualStyleBackColor = false;
            this.btn_goSalary.Click += new System.EventHandler(this.btn_goSalary_Click);
            // 
            // btn_goEmployee
            // 
            this.btn_goEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(37)))), ((int)(((byte)(53)))));
            this.btn_goEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_goEmployee.Location = new System.Drawing.Point(3, 110);
            this.btn_goEmployee.Name = "btn_goEmployee";
            this.btn_goEmployee.Size = new System.Drawing.Size(303, 92);
            this.btn_goEmployee.TabIndex = 0;
            this.btn_goEmployee.Text = "العمال";
            this.btn_goEmployee.UseVisualStyleBackColor = false;
            this.btn_goEmployee.Click += new System.EventHandler(this.btn_goEmployee_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1277, 788);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1586, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_goHomeScreen;
        private System.Windows.Forms.Button btn_goSalary;
        private System.Windows.Forms.Button btn_goEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}