using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkerSalary.Models;

namespace WorkerSalary
{
    public partial class DeleteEmpForm : Form
    {
        int employeeId;
        Zain_CompanyEntities db = new Zain_CompanyEntities();
        public DeleteEmpForm(int empId)
        {
            InitializeComponent();
            employeeId = empId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = db.Employees.Find(employeeId);

                if (emp != null)
                {
                    RemoveEmployeeAndSalaries(emp);

                    MessageBox.Show("تم مسح العامل وسجلاته من عندك");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("العامل لم يعد موجود، أعد تحميل الصفحة");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }

        private void RemoveEmployeeAndSalaries(Employee employee)
        {
            var salaries = db.Salaries.Where(s => s.EmpId == employee.Id).ToList();

            db.Salaries.RemoveRange(salaries);

            db.Employees.Remove(employee);

            db.SaveChanges();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
