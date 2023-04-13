using System;
using System.Windows.Forms;

namespace Grifindo_Toy
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void ButtonToEmpDash_Click(object sender, EventArgs e)
        {
            //hide the home page
            this.Hide();

            // show the employees dashboard form
            Employee employee = new Employee();
            employee.Show();
        }

        private void ButtonToSalaryDash_Click(object sender, EventArgs e)
        {
            //hide the home page
            this.Hide();

            // show the employees dashboard form
            Salary Salaryform = new Salary();
            Salaryform.Show();
        }

        private void ButtonToSettingDash_Click(object sender, EventArgs e)
        {

        }
    }
}
