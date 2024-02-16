namespace WorkerSalary
{
    partial class EmployeeForm
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
            this.dataGrid_employess = new System.Windows.Forms.DataGridView();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.listBox_Employess = new System.Windows.Forms.ListBox();
            this.btn_RefreachPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_employess)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(309, 928);
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
            // 
            // dataGrid_employess
            // 
            this.dataGrid_employess.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_employess.ColumnHeadersHeight = 35;
            this.dataGrid_employess.EnableHeadersVisualStyles = false;
            this.dataGrid_employess.Location = new System.Drawing.Point(329, 110);
            this.dataGrid_employess.Name = "dataGrid_employess";
            this.dataGrid_employess.RowHeadersWidth = 50;
            this.dataGrid_employess.Size = new System.Drawing.Size(1246, 758);
            this.dataGrid_employess.TabIndex = 3;
            this.dataGrid_employess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_employess_CellClick);
            this.dataGrid_employess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_employess_CellContentClick);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEmployee.Location = new System.Drawing.Point(1382, 45);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(193, 59);
            this.btn_addEmployee.TabIndex = 4;
            this.btn_addEmployee.Text = "اضافة عامل";
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // listBox_Employess
            // 
            this.listBox_Employess.FormattingEnabled = true;
            this.listBox_Employess.Location = new System.Drawing.Point(1581, 110);
            this.listBox_Employess.Name = "listBox_Employess";
            this.listBox_Employess.Size = new System.Drawing.Size(318, 758);
            this.listBox_Employess.TabIndex = 5;
            this.listBox_Employess.SelectedIndexChanged += new System.EventHandler(this.listBox_Employess_SelectedIndexChanged);
            // 
            // btn_RefreachPage
            // 
            this.btn_RefreachPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_RefreachPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreachPage.Location = new System.Drawing.Point(1183, 45);
            this.btn_RefreachPage.Name = "btn_RefreachPage";
            this.btn_RefreachPage.Size = new System.Drawing.Size(193, 59);
            this.btn_RefreachPage.TabIndex = 6;
            this.btn_RefreachPage.Text = "اعادة تحميل الصفحه";
            this.btn_RefreachPage.UseVisualStyleBackColor = false;
            this.btn_RefreachPage.Click += new System.EventHandler(this.btn_RefreachPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1737, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "قائمة العمال";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 928);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RefreachPage);
            this.Controls.Add(this.listBox_Employess);
            this.Controls.Add(this.btn_addEmployee);
            this.Controls.Add(this.dataGrid_employess);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_employess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_goHomeScreen;
        private System.Windows.Forms.Button btn_goSalary;
        private System.Windows.Forms.Button btn_goEmployee;
        private System.Windows.Forms.DataGridView dataGrid_employess;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.ListBox listBox_Employess;
        private System.Windows.Forms.Button btn_RefreachPage;
        private System.Windows.Forms.Label label1;
    }
}