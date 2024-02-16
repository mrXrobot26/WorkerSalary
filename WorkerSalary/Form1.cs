using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerSalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_calcSalary_Click(object sender, EventArgs e)
        {
            decimal salaryForDay = 0, priceOfHour;
            decimal workFrom, workTo, workHour, overWorkHour;
            int normalWorkHour = 9;

            if (decimal.TryParse(txt_workFrom.Text, out workFrom) &&
                decimal.TryParse(txt_workTo.Text, out workTo) &&
                decimal.TryParse(txt_priceOfHour.Text, out priceOfHour))
            {
                workHour = workTo - workFrom;

                if (workHour <= normalWorkHour)
                {
                    salaryForDay = workHour * priceOfHour;
                }
                else
                {
                    salaryForDay += normalWorkHour * priceOfHour;
                    overWorkHour = workHour - normalWorkHour;
                    salaryForDay += overWorkHour * (priceOfHour * 2);
                }

                lbl_salary.Text = salaryForDay.ToString();

            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for hours and price.");
            }
        }

    }
}
