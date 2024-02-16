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

namespace WorkerSalary
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void HomePage_Load(object sender, EventArgs e)
        {
            int Width = Screen.PrimaryScreen.Bounds.Width;
            int Height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0,0 );
            this.Size = new Size(Width, Height);
        }

        private void btn_goEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(() => Application.Run(new EmployeeForm()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btn_goSalary_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(() => Application.Run(new Salary()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
