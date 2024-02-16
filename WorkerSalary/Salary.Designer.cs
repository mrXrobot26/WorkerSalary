namespace WorkerSalary
{
    partial class Salary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_goHomeScreen = new System.Windows.Forms.Button();
            this.btn_goSalary = new System.Windows.Forms.Button();
            this.btn_goEmployee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(309, 761);
            this.panel1.TabIndex = 2;
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
            this.btn_goHomeScreen.Click += new System.EventHandler(this.btn_goHomeScreen_Click);
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
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 761);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_goHomeScreen;
        private System.Windows.Forms.Button btn_goSalary;
        private System.Windows.Forms.Button btn_goEmployee;
    }
}