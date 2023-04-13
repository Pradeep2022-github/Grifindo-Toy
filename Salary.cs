using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Grifindo_Toy
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
            GetEmployees();
            GetHoliday();
            Getdates();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kithm\Documents\Griffindo_Payroll.mdf;Integrated Security=True;Connect Timeout=30");
        private void Clear()
        {
            FNam_Salary.Text = "";
            Absent_Salary.Text = "";
            OT_Salary.Text = "";
 
        }
        private void ShowSalary()
        {
            Con.Open();
            String Query = "Select * from SalaryDB";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SalaryCalcualtionview.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetEmployees()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select * from SalaryDateTable", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("EmpId", typeof(int));
            dt.Load(Rdr);
            Salary_EmpId.ValueMember = "EmpId";
            Salary_EmpId.DataSource = dt;
            Con.Close();
        }
        private void GetHoliday()
        {
            Con.Open();
            string Query = "Select * from SalaryDateTable Where EmpId=" + Salary_EmpId.SelectedValue.ToString(); 
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                // Set the value to the appropriate control
                // Assuming Holiday_Salary is the control to display the holiday value
                Holiday_Salary.Text = dr["Holiday"].ToString();
            }
            Con.Close();

            /*          Con.Open();
                      SqlCommand cmd = new SqlCommand("Select * from SalaryDateTable Where EmpId=" + Salary_EmpId.SelectedValue.ToString()+"", Con);
                      SqlDataReader Rdr;
                      Rdr = cmd.ExecuteReader();
                      DataTable dt = new DataTable();
                      dt.Columns.Add("EmpId", typeof(int));
                      dt.Load(Rdr);
                      Salary_EmpId.ValueMember = "EmpId";
                      Salary_EmpId.DataSource = dt;
                      Con.Close();    */
        }
        private void Getdates()
        {
            Con.Open();
            string Query = "Select * from SalaryDateTable Where EmpId=" + Salary_EmpId.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                // Set the value to the appropriate control
                // Assuming Holiday_Salary is the control to display the holiday value
                Start_Sal_CB.Text = dr["CycleStartDate"].ToString();
                End_Sal_CB.Text = dr["CycleEndDate"].ToString();
                Range_Sal_CB.Text = dr["PayCycleDRange"].ToString();

            }
            Con.Close();


            /*   Con.Open();
            string Query = "SELECT CycleStartDate, CycleEndDate, PayCycleDRange FROM SalaryDateTable WHERE EmpId=" + Salary_EmpId.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // Set the values to the appropriate controls
                // Assuming StartDate_Salary, EndDate_Salary, and DateRange_Salary are the controls to display the start date, end date, and date range values respectively
                Start_Sal_CB.Text = reader["CycleStartDate"].ToString();
                End_Sal_CB.Text = reader["CycleEndDate"].ToString();
                Range_Sal_CB.Text = reader["PayCycleDRange"].ToString();
            }
            reader.Close();
            Con.Close();    */
        }

        private void GetEmployeeName()
        {
            Con.Open();
            string Query = "Select * from EmployeeTB1 where EmpId =" + Salary_EmpId.SelectedValue.ToString();
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FNam_Salary.Text = dr["FirstName"].ToString();
                MonthlyPay.Text = dr["MonthlyBasicSalary"].ToString();
                OT_Salary_CB.Text = dr["OTRate"].ToString();
            }
            Con.Close();
        }
        private void Calculate_Click(object sender, EventArgs e)
        {

        }

        private void Salary_EmpId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetEmployeeName();
            GetHoliday();
            Getdates();
        }
        private void ButtonToEmpDash_Click(object sender, EventArgs e)
        {
            //hide the home page
            this.Hide();

            // show the employees dashboard form
            Employee employee = new Employee();
            employee.Show();
        }

        private void ButtonToSettingDash_Click(object sender, EventArgs e)
        {
            //hide the home page
            this.Hide();

            // show the employees dashboard form
            Salarysetting settingform = new Salarysetting();
            settingform.Show();
        }

        private void Add_Salary_Click(object sender, EventArgs e)
        {
            if (Absent_Salary.Text == "" || OT_Salary.Text == "" || OT_Salary_CB.Text == "")
            {
                MessageBox.Show("Add 0 if no value");
            }
            else
            {
                try
                {
                    // Insert salary data into the database
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO SalaryDB (EmpId, FNam,Holiday,AbsDay,Overtime) VALUES (@EmpId, @EFNam, @EHoliday, @EAbsDay,@EOvertime)", Con);
                    cmd.Parameters.AddWithValue("@EmpId", Salary_EmpId.Text);
                    cmd.Parameters.AddWithValue("@EFNam", FNam_Salary.Text);
                    cmd.Parameters.AddWithValue("@EHoliday", HolidatTkn_Salary.Text);
                    cmd.Parameters.AddWithValue("@EAbsDay", Convert.ToInt32(Absent_Salary.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@EOvertime", OT_Salary.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SalaryCalcualtionview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Key = 0;
            {
                Salary_EmpId.SelectedItem = SalaryCalcualtionview.SelectedRows[0].Cells[1].Value.ToString();
                FNam_Salary.Text = SalaryCalcualtionview.SelectedRows[0].Cells[2].Value.ToString();
                Salary_EmpId.SelectedItem = SalaryCalcualtionview.SelectedRows[0].Cells[1].Value.ToString();
                Absent_Salary.Text = SalaryCalcualtionview.SelectedRows[0].Cells[3].Value.ToString();
                Holiday_Salary.Text = SalaryCalcualtionview.SelectedRows[0].Cells[4].Value.ToString();
                OT_Salary.Text = SalaryCalcualtionview.SelectedRows[0].Cells[5].Value.ToString();
                NoPay_Salary.Text = SalaryCalcualtionview.SelectedRows[0].Cells[6].Value.ToString();
                OT_Salary_CB.Text = SalaryCalcualtionview.SelectedRows[0].Cells[3].Value.ToString();
                MonthlyPay.Text = SalaryCalcualtionview.SelectedRows[0].Cells[4].Value.ToString();
                Base_Pay.Text = SalaryCalcualtionview.SelectedRows[0].Cells[5].Value.ToString();
                Gross_Salary.Text = SalaryCalcualtionview.SelectedRows[0].Cells[6].Value.ToString();

                if (FNam_Salary.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(SalaryCalcualtionview.SelectedRows[0].Cells[0].Value.ToString());
                }
            }

        }

        private void Salary_EmpId_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmployeeName();
        }

        private void Edit_salary_Click(object sender, EventArgs e)
        {
            if (Absent_Salary.Text == "" || OT_Salary.Text == "" || OT_Salary_CB.Text == "")
            {
                MessageBox.Show("Add 0 if no value");
            }
            else
            {
                try
                {
                    // Insert salary data into the database
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update  SalaryDB Set EmpId= @EmpId,FNam=@EFNam,Holiday= @EHoliday,AbsDay=@EAbsDay,Overtime=@EOvertime where EmpId=@EmpId", Con);
                    cmd.Parameters.AddWithValue("@EmpId", Salary_EmpId.Text);
                    cmd.Parameters.AddWithValue("@EFNam", FNam_Salary.Text);
                    cmd.Parameters.AddWithValue("@EHoliday", Holiday_Salary.Text);
                    cmd.Parameters.AddWithValue("@EAbsDay", Convert.ToInt32(Absent_Salary.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@EOvertime", OT_Salary.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salarysetting Done");
                    Con.Close();
                    ShowSalary();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
        
}
