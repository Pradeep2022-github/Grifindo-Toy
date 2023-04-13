using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Grifindo_Toy
{
    public partial class Employee : Form
    {

        public Employee()
        {
            InitializeComponent();
            ShowEmployees();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kithm\Documents\Griffindo_Payroll.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            FNam.Text = "";
            LNam.Text = "";
            Designation.Text = "";
            MBSalary.Text = "";
            OTRate.Text = "";
            Allow.Text = "";
            Gtax.Text = "";
            Key = 0;


        }
        private void ShowEmployees()

        {
            Con.Open();
            String Query = "Select * from EmployeeTB1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmployeeDataview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Add_Emp_Click_1(object sender, EventArgs e)
        {
            if (FNam.Text == "" || LNam.Text == "" || Designation.Text == "" || MBSalary.Text == "" || OTRate.Text == "" || Allow.Text == "" || Gtax.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTB1 (FirstName,LastName,Desgination,MonthlyBasicSalary,OTRate,Allowance,GTax,JoiningDate)values(@EFN,@ELN,@EDes,@EMBSal,@EOT,@EAw,@EGTx,@JD)", Con);
                    cmd.Parameters.AddWithValue("@EFN", FNam.Text);
                    cmd.Parameters.AddWithValue("@ELN", LNam.Text);
                    cmd.Parameters.AddWithValue("@EDes", Designation.Text);
                    cmd.Parameters.AddWithValue("@EMBSal", MBSalary.Text);
                    cmd.Parameters.AddWithValue("@EOT", OTRate.Text);
                    cmd.Parameters.AddWithValue("@EAw", Allow.Text);
                    cmd.Parameters.AddWithValue("@EGTx", Gtax.Text);
                    cmd.Parameters.AddWithValue("@JD", DOJ.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                    Con.Close();
                    ShowEmployees();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }
        int Key = 0;
        private void EmployeeDataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            FNam.Text = EmployeeDataview.SelectedRows[0].Cells[1].Value.ToString();
            LNam.Text = EmployeeDataview.SelectedRows[0].Cells[2].Value.ToString();
            Designation.Text = EmployeeDataview.SelectedRows[0].Cells[3].Value.ToString();
            MBSalary.Text = EmployeeDataview.SelectedRows[0].Cells[4].Value.ToString();
            OTRate.Text = EmployeeDataview.SelectedRows[0].Cells[5].Value.ToString();
            Allow.Text = EmployeeDataview.SelectedRows[0].Cells[6].Value.ToString();
            Gtax.Text = EmployeeDataview.SelectedRows[0].Cells[7].Value.ToString();
            DOJ.Text = EmployeeDataview.SelectedRows[0].Cells[8].Value.ToString();
            {
                Key = 0;
            }
            {
                Key = Convert.ToInt32(EmpId.Text = EmployeeDataview.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void UpdateEmp_Click(object sender, EventArgs e)
        {
            if (FNam.Text == "" || LNam.Text == "" || Designation.Text == "" || MBSalary.Text == "" || OTRate.Text == "" || Allow.Text == "" || Gtax.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EmployeeTB1 Set FirstName=@EFN,LastName=@ELN,Desgination=@EDes,MonthlyBasicSalary=@EMBSal,OTRate=@EOT,Allowance=@EAw,GTax=@EGTx,JoiningDate=@JD where EmpId=@Empkey", Con);
                    cmd.Parameters.AddWithValue("@EFN", FNam.Text);
                    cmd.Parameters.AddWithValue("@ELN", LNam.Text);
                    cmd.Parameters.AddWithValue("@EDes", Designation.Text);
                    cmd.Parameters.AddWithValue("@EMBSal", MBSalary.Text);
                    cmd.Parameters.AddWithValue("@EOT", OTRate.Text);
                    cmd.Parameters.AddWithValue("@EAw", Allow.Text);
                    cmd.Parameters.AddWithValue("@EGTx", Gtax.Text);
                    cmd.Parameters.AddWithValue("@JD", DOJ.Value.Date);
                    cmd.Parameters.AddWithValue("@Empkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated");
                    Con.Close();
                    ShowEmployees();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void Del_Emp_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from EmployeeTB1 where EmpId=@Empkey", Con);
                    cmd.Parameters.AddWithValue("@Empkey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");
                    Con.Close();
                    ShowEmployees();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //hide the home page
            this.Hide();

            // show the employees dashboard form
            Salary Salaryform = new Salary();
            Salaryform.Show();


        }

        private void Setting_btn_Emp_Form_Click(object sender, EventArgs e)
        {
            //hide the home page
            this.Hide();

            // show the employees dashboard form
            Salarysetting settingform = new Salarysetting();
            settingform.Show();

        }
    }

}


