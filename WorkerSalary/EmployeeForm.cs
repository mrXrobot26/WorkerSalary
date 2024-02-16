using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkerSalary.Models;

namespace WorkerSalary
{
    public partial class EmployeeForm : Form
    {
        Zain_CompanyEntities db = new Zain_CompanyEntities();

        public EmployeeForm()
        {
            InitializeComponent();
            LoadEmployeeData();
            int Width = Screen.PrimaryScreen.Bounds.Width;
            int Height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(Width, Height);
            foreach (DataGridViewColumn column in dataGrid_employess.Columns)
            {
                column.Width = 300;
            }

        }

        private bool isDataBinding = false;

        private void LoadEmployeeData()
        {
            // Set the flag to false before data binding
            isDataBinding = true;

            var employees = db.Employees.ToList();
            var salaries = db.Salaries.ToList();

            var query = from emp in employees
                        join salary in salaries on emp.Id equals salary.EmpId into joinedData
                        from salaryData in joinedData.DefaultIfEmpty()
                        select new
                        {
                            EmployeeId = emp.Id,
                            EmployeeName = emp.Name,
                            WakeSalary = salaryData?.WakeSalary,
                            DateOfDay = salaryData?.DateOfDay
                        };

            dataGrid_employess.DataSource = query.ToList();

            listBox_Employess.DataSource = employees;

            listBox_Employess.DisplayMember = "Name";

            // Reset the flag to true after data binding
            isDataBinding = false;
        }

        private void btn_goSalary_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(() => Application.Run(new Salary()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_goHomeScreen_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(() => Application.Run(new HomePage()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void dataGrid_employess_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGrid_employess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void listBox_Employess_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check the flag to determine whether to process the event
            if (!isDataBinding && listBox_Employess.SelectedIndex != -1)
            {
                int empId = ((Employee)listBox_Employess.SelectedItem).Id;
                DeleteEmpForm deleteEmpForm = new DeleteEmpForm(empId);
                deleteEmpForm.ShowDialog();
            }
        }

        private void btn_RefreachPage_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }


    }
}
