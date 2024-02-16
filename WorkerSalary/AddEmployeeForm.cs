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
    public partial class AddEmployeeForm : Form
    {
        Zain_CompanyEntities db = new Zain_CompanyEntities();
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployee(string employeeName)
        {
            try
            {
                Employee newEmployee = new Employee()
                {
                    Name = employeeName,
                };

                db.Employees.Add(newEmployee);

                db.SaveChanges();

                MessageBox.Show("تم إضافة العامل بنجاح");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_empName.Text))
            {
                string employeeName = txt_empName.Text;
                AddEmployee(employeeName);
            }
            else
            {
                MessageBox.Show("يرجى إدخال اسم العامل");
            }
        }

    }
}
