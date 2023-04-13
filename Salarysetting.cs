using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grifindo_Toy
{
    public partial class Salarysetting : Form
    {
        public Salarysetting()
        {
            InitializeComponent();
            ShowSalarysetting();
            GetEmployees();
            GetEmployeeName();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kithm\Documents\Griffindo_Payroll.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            FNam.Text = "";
            HolidayAnnual.Text = "";
            RangeofSalary.Text = "";
            Start.Text = "";
            End.Text = "";
            Key = 0;
        }
        private void ShowSalarysetting()

        {
            Con.Open();
            String Query = "Select * from SalaryDateTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Salarysettingview.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetEmployees()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from EmployeeTB1", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            EmpIdCB.ValueMember = "EmpId";
            EmpIdCB.DataSource = dt;
            Con.Close();
        }
        private void GetEmployeeName()
        {
            Con.Open();
            string Query = "Select * from EmployeeTB1 where EmpId =" + EmpIdCB.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FNam.Text = dr["FirstName"].ToString();
            }
            Con.Close();
        }

        private void displayEmployeedetails()
        {
            Con.Open();
            string Query = "Select * from SalaryDateTable where EmpId =" + EmpIdCB.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FNam.Text = dr["FirstName"].ToString();
                HolidayAnnual.Text = dr["Holiday"].ToString();
                RangeofSalary.Text = dr["PayCycleDRange"].ToString();
                Start.Text = dr["CycleStartDate"].ToString();
                End.Text = dr["CycleEndDate"].ToString();


            }
            Con.Close();
        }
   



        private void Set_Click(object sender, System.EventArgs e)
        {
            if (FNam.Text == "" || HolidayAnnual.Text == "" || RangeofSalary.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    int salaryRange = Convert.ToInt32(RangeofSalary.Text);
                    if (salaryRange > 31)
                    {
                        MessageBox.Show("You can't enter more than 31 for Range of Salary");
                        return;
                    }


                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SalaryDateTable (EmpId,FirstName,PayCycleDRange,Holiday,CycleStartDate,CycleEndDate)values(@EID,@EFN,@EPaycr,@EHol,@ES,@EE)", Con);
                    cmd.Parameters.AddWithValue("@EID", EmpIdCB.Text);
                    cmd.Parameters.AddWithValue("@EFN", FNam.Text);
                    cmd.Parameters.AddWithValue("@EPaycr", RangeofSalary.Text);
                    cmd.Parameters.AddWithValue("@EHol", HolidayAnnual.Text);
                    cmd.Parameters.AddWithValue("@ES", Start.Value.Date);
                    cmd.Parameters.AddWithValue("@EE", End.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salarysetting Done");
                    Con.Close();
                    ShowSalarysetting();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }
        int Key = 0;
        private void Salarysettingview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            FNam.Text = Salarysettingview.SelectedRows[0].Cells[1].Value.ToString();
            RangeofSalary.Text = Salarysettingview.SelectedRows[0].Cells[3].Value.ToString();
            HolidayAnnual.Text = Salarysettingview.SelectedRows[0].Cells[4].Value.ToString();
            Start.Text = Salarysettingview.SelectedRows[0].Cells[5].Value.ToString();
            End.Text = Salarysettingview.SelectedRows[0].Cells[6].Value.ToString();
   //         if (FNam.Text == "")
            {
                Key = 0;
            }
            {
                Key = Convert.ToInt32(EmpIdCB.SelectedItem = Salarysettingview.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EmpIdCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmployeeName();
            displayEmployeedetails();
        }

        private void UpdateEmpSetting_Click(object sender, EventArgs e)
        {
            if (FNam.Text == "" || HolidayAnnual.Text == "" || RangeofSalary.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    int salaryRange = Convert.ToInt32(RangeofSalary.Text);
                    if (salaryRange > 31)
                    {
                        MessageBox.Show("You can't enter more than 31 for Range of Salary");
                        return;
                    }


                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update SalaryDateTable Set EmpId=@EID,FirstName=@EFN,PayCycleDRange=@EPaycr,Holiday=@EHol,CycleStartDate=@ES,CycleEndDate=@EE where EmpId=@EID", Con);
                    cmd.Parameters.AddWithValue("@EID", EmpIdCB.Text);
                    cmd.Parameters.AddWithValue("@EFN", FNam.Text);
                    cmd.Parameters.AddWithValue("@EPaycr", RangeofSalary.Text);
                    cmd.Parameters.AddWithValue("@EHol", HolidayAnnual.Text);
                    cmd.Parameters.AddWithValue("@ES", Start.Value.Date);
                    cmd.Parameters.AddWithValue("@EE", End.Value.Date);
                    cmd.Parameters.AddWithValue("@Settingkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salarysetting Done");
                    Con.Close();
                    ShowSalarysetting();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
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

        private void Del_Emp_Setting_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("Delete from SalaryDateTable where SettingId=@SettingId and EmpId=@EmpId", Con);
                    cmd.Parameters.AddWithValue("@EmpId", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");
                    Con.Close();
                    ShowSalarysetting();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }
    }
}
