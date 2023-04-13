using System;

namespace Grifindo_Toy
{
    partial class Salary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HolidatTkn_Salary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Base_Pay = new System.Windows.Forms.TextBox();
            this.MonthlyPay = new System.Windows.Forms.ComboBox();
            this.BasePay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OT_Salary_CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GrossPay = new System.Windows.Forms.Label();
            this.Gross_Salary = new System.Windows.Forms.TextBox();
            this.BasePay_Salary = new System.Windows.Forms.Label();
            this.Start_Sal_CB = new System.Windows.Forms.ComboBox();
            this.End_Sal_CB = new System.Windows.Forms.ComboBox();
            this.Range_Sal_CB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit_salary = new System.Windows.Forms.Button();
            this.Add_Salary = new System.Windows.Forms.Button();
            this.Holiday_Salary = new System.Windows.Forms.ComboBox();
            this.Salary_EmpId = new System.Windows.Forms.ComboBox();
            this.Absentdays = new System.Windows.Forms.Label();
            this.FNam_Salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.NoPay_Salary = new System.Windows.Forms.TextBox();
            this.OT_Salary = new System.Windows.Forms.TextBox();
            this.Absent_Salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.No_Paysalary = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Hoilday_salary = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonToEmpDash = new System.Windows.Forms.Button();
            this.ButtonToSettingDash = new System.Windows.Forms.Button();
            this.SalaryBTN = new System.Windows.Forms.Button();
            this.SalaryCalcualtionview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryCalcualtionview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.HolidatTkn_Salary);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Base_Pay);
            this.panel1.Controls.Add(this.MonthlyPay);
            this.panel1.Controls.Add(this.BasePay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.OT_Salary_CB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GrossPay);
            this.panel1.Controls.Add(this.Gross_Salary);
            this.panel1.Controls.Add(this.BasePay_Salary);
            this.panel1.Controls.Add(this.Start_Sal_CB);
            this.panel1.Controls.Add(this.End_Sal_CB);
            this.panel1.Controls.Add(this.Range_Sal_CB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Edit_salary);
            this.panel1.Controls.Add(this.Add_Salary);
            this.panel1.Controls.Add(this.Holiday_Salary);
            this.panel1.Controls.Add(this.Salary_EmpId);
            this.panel1.Controls.Add(this.Absentdays);
            this.panel1.Controls.Add(this.FNam_Salary);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Calculate);
            this.panel1.Controls.Add(this.NoPay_Salary);
            this.panel1.Controls.Add(this.OT_Salary);
            this.panel1.Controls.Add(this.Absent_Salary);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.No_Paysalary);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Hoilday_salary);
            this.panel1.Location = new System.Drawing.Point(201, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 299);
            this.panel1.TabIndex = 8;
            // 
            // HolidatTkn_Salary
            // 
            this.HolidatTkn_Salary.Location = new System.Drawing.Point(91, 181);
            this.HolidatTkn_Salary.Name = "HolidatTkn_Salary";
            this.HolidatTkn_Salary.Size = new System.Drawing.Size(103, 20);
            this.HolidatTkn_Salary.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Holiday Taken :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Base_Pay
            // 
            this.Base_Pay.Enabled = false;
            this.Base_Pay.Location = new System.Drawing.Point(344, 214);
            this.Base_Pay.Name = "Base_Pay";
            this.Base_Pay.Size = new System.Drawing.Size(100, 20);
            this.Base_Pay.TabIndex = 48;
            // 
            // MonthlyPay
            // 
            this.MonthlyPay.FormattingEnabled = true;
            this.MonthlyPay.Location = new System.Drawing.Point(220, 213);
            this.MonthlyPay.Name = "MonthlyPay";
            this.MonthlyPay.Size = new System.Drawing.Size(103, 21);
            this.MonthlyPay.TabIndex = 47;
            // 
            // BasePay
            // 
            this.BasePay.AutoSize = true;
            this.BasePay.Location = new System.Drawing.Point(341, 198);
            this.BasePay.Name = "BasePay";
            this.BasePay.Size = new System.Drawing.Size(49, 13);
            this.BasePay.TabIndex = 46;
            this.BasePay.Text = "BasePay";
            this.BasePay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 45;
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OT_Salary_CB
            // 
            this.OT_Salary_CB.FormattingEnabled = true;
            this.OT_Salary_CB.Location = new System.Drawing.Point(478, 61);
            this.OT_Salary_CB.Name = "OT_Salary_CB";
            this.OT_Salary_CB.Size = new System.Drawing.Size(103, 21);
            this.OT_Salary_CB.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "OTRate";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GrossPay
            // 
            this.GrossPay.AutoSize = true;
            this.GrossPay.Location = new System.Drawing.Point(465, 198);
            this.GrossPay.Name = "GrossPay";
            this.GrossPay.Size = new System.Drawing.Size(52, 13);
            this.GrossPay.TabIndex = 40;
            this.GrossPay.Text = "GrossPay";
            this.GrossPay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Gross_Salary
            // 
            this.Gross_Salary.Enabled = false;
            this.Gross_Salary.Location = new System.Drawing.Point(468, 213);
            this.Gross_Salary.Name = "Gross_Salary";
            this.Gross_Salary.Size = new System.Drawing.Size(100, 20);
            this.Gross_Salary.TabIndex = 39;
            // 
            // BasePay_Salary
            // 
            this.BasePay_Salary.AutoSize = true;
            this.BasePay_Salary.Location = new System.Drawing.Point(217, 197);
            this.BasePay_Salary.Name = "BasePay_Salary";
            this.BasePay_Salary.Size = new System.Drawing.Size(62, 13);
            this.BasePay_Salary.TabIndex = 38;
            this.BasePay_Salary.Text = "MonthlyPay";
            this.BasePay_Salary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Start_Sal_CB
            // 
            this.Start_Sal_CB.FormattingEnabled = true;
            this.Start_Sal_CB.Location = new System.Drawing.Point(311, 60);
            this.Start_Sal_CB.Name = "Start_Sal_CB";
            this.Start_Sal_CB.Size = new System.Drawing.Size(103, 21);
            this.Start_Sal_CB.TabIndex = 35;
            // 
            // End_Sal_CB
            // 
            this.End_Sal_CB.FormattingEnabled = true;
            this.End_Sal_CB.Location = new System.Drawing.Point(311, 99);
            this.End_Sal_CB.Name = "End_Sal_CB";
            this.End_Sal_CB.Size = new System.Drawing.Size(103, 21);
            this.End_Sal_CB.TabIndex = 34;
            // 
            // Range_Sal_CB
            // 
            this.Range_Sal_CB.FormattingEnabled = true;
            this.Range_Sal_CB.Location = new System.Drawing.Point(311, 139);
            this.Range_Sal_CB.Name = "Range_Sal_CB";
            this.Range_Sal_CB.Size = new System.Drawing.Size(103, 21);
            this.Range_Sal_CB.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cycle Date Range";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Cycle End Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cycle Start Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Edit_salary
            // 
            this.Edit_salary.BackColor = System.Drawing.Color.Red;
            this.Edit_salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_salary.Location = new System.Drawing.Point(344, 245);
            this.Edit_salary.Name = "Edit_salary";
            this.Edit_salary.Size = new System.Drawing.Size(118, 23);
            this.Edit_salary.TabIndex = 29;
            this.Edit_salary.Text = "Edit";
            this.Edit_salary.UseVisualStyleBackColor = false;
            this.Edit_salary.Click += new System.EventHandler(this.Edit_salary_Click);
            // 
            // Add_Salary
            // 
            this.Add_Salary.BackColor = System.Drawing.Color.OrangeRed;
            this.Add_Salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Salary.Location = new System.Drawing.Point(220, 246);
            this.Add_Salary.Name = "Add_Salary";
            this.Add_Salary.Size = new System.Drawing.Size(118, 23);
            this.Add_Salary.TabIndex = 28;
            this.Add_Salary.Text = "Add More";
            this.Add_Salary.UseVisualStyleBackColor = false;
            this.Add_Salary.Click += new System.EventHandler(this.Add_Salary_Click);
            // 
            // Holiday_Salary
            // 
            this.Holiday_Salary.Enabled = false;
            this.Holiday_Salary.FormattingEnabled = true;
            this.Holiday_Salary.Location = new System.Drawing.Point(91, 160);
            this.Holiday_Salary.Name = "Holiday_Salary";
            this.Holiday_Salary.Size = new System.Drawing.Size(103, 21);
            this.Holiday_Salary.TabIndex = 27;
            // 
            // Salary_EmpId
            // 
            this.Salary_EmpId.FormattingEnabled = true;
            this.Salary_EmpId.Location = new System.Drawing.Point(91, 20);
            this.Salary_EmpId.Name = "Salary_EmpId";
            this.Salary_EmpId.Size = new System.Drawing.Size(103, 21);
            this.Salary_EmpId.TabIndex = 26;
            this.Salary_EmpId.SelectedIndexChanged += new System.EventHandler(this.Salary_EmpId_SelectedIndexChanged);
            this.Salary_EmpId.SelectionChangeCommitted += new System.EventHandler(this.Salary_EmpId_SelectionChangeCommitted);
            // 
            // Absentdays
            // 
            this.Absentdays.AutoSize = true;
            this.Absentdays.Location = new System.Drawing.Point(12, 116);
            this.Absentdays.Name = "Absentdays";
            this.Absentdays.Size = new System.Drawing.Size(71, 13);
            this.Absentdays.TabIndex = 25;
            this.Absentdays.Text = "Absent days :";
            this.Absentdays.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FNam_Salary
            // 
            this.FNam_Salary.Enabled = false;
            this.FNam_Salary.Location = new System.Drawing.Point(94, 61);
            this.FNam_Salary.Name = "FNam_Salary";
            this.FNam_Salary.Size = new System.Drawing.Size(100, 20);
            this.FNam_Salary.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "First Name :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pay Sheet";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(200, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.Lime;
            this.Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate.Location = new System.Drawing.Point(468, 245);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(118, 23);
            this.Calculate.TabIndex = 14;
            this.Calculate.Text = "Calculate the pay";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // NoPay_Salary
            // 
            this.NoPay_Salary.Location = new System.Drawing.Point(94, 248);
            this.NoPay_Salary.Name = "NoPay_Salary";
            this.NoPay_Salary.Size = new System.Drawing.Size(100, 20);
            this.NoPay_Salary.TabIndex = 13;
            // 
            // OT_Salary
            // 
            this.OT_Salary.Location = new System.Drawing.Point(94, 215);
            this.OT_Salary.Name = "OT_Salary";
            this.OT_Salary.Size = new System.Drawing.Size(100, 20);
            this.OT_Salary.TabIndex = 12;
            // 
            // Absent_Salary
            // 
            this.Absent_Salary.Location = new System.Drawing.Point(94, 116);
            this.Absent_Salary.Name = "Absent_Salary";
            this.Absent_Salary.Size = new System.Drawing.Size(100, 20);
            this.Absent_Salary.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee ID :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // No_Paysalary
            // 
            this.No_Paysalary.AutoSize = true;
            this.No_Paysalary.Location = new System.Drawing.Point(12, 251);
            this.No_Paysalary.Name = "No_Paysalary";
            this.No_Paysalary.Size = new System.Drawing.Size(48, 13);
            this.No_Paysalary.TabIndex = 6;
            this.No_Paysalary.Text = "No Pay :";
            this.No_Paysalary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "OT hours  :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Hoilday_salary
            // 
            this.Hoilday_salary.AutoSize = true;
            this.Hoilday_salary.Location = new System.Drawing.Point(12, 160);
            this.Hoilday_salary.Name = "Hoilday_salary";
            this.Hoilday_salary.Size = new System.Drawing.Size(51, 13);
            this.Hoilday_salary.TabIndex = 4;
            this.Hoilday_salary.Text = "Holiday  :";
            this.Hoilday_salary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Grifindo_Toy.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonToEmpDash
            // 
            this.ButtonToEmpDash.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonToEmpDash.Location = new System.Drawing.Point(12, 56);
            this.ButtonToEmpDash.Name = "ButtonToEmpDash";
            this.ButtonToEmpDash.Size = new System.Drawing.Size(165, 53);
            this.ButtonToEmpDash.TabIndex = 31;
            this.ButtonToEmpDash.Text = "EmployeeDashboard";
            this.ButtonToEmpDash.UseVisualStyleBackColor = false;
            this.ButtonToEmpDash.Click += new System.EventHandler(this.ButtonToEmpDash_Click);
            // 
            // ButtonToSettingDash
            // 
            this.ButtonToSettingDash.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonToSettingDash.Location = new System.Drawing.Point(12, 219);
            this.ButtonToSettingDash.Name = "ButtonToSettingDash";
            this.ButtonToSettingDash.Size = new System.Drawing.Size(165, 53);
            this.ButtonToSettingDash.TabIndex = 33;
            this.ButtonToSettingDash.Text = "Setting";
            this.ButtonToSettingDash.UseVisualStyleBackColor = false;
            this.ButtonToSettingDash.Click += new System.EventHandler(this.ButtonToSettingDash_Click);
            // 
            // SalaryBTN
            // 
            this.SalaryBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SalaryBTN.Location = new System.Drawing.Point(12, 137);
            this.SalaryBTN.Name = "SalaryBTN";
            this.SalaryBTN.Size = new System.Drawing.Size(165, 53);
            this.SalaryBTN.TabIndex = 34;
            this.SalaryBTN.Text = "Salary";
            this.SalaryBTN.UseVisualStyleBackColor = false;
            this.SalaryBTN.Click += new System.EventHandler(this.SalaryBTN_Click);
            // 
            // SalaryCalcualtionview
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SalaryCalcualtionview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SalaryCalcualtionview.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.SalaryCalcualtionview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryCalcualtionview.Location = new System.Drawing.Point(-5, 307);
            this.SalaryCalcualtionview.Name = "SalaryCalcualtionview";
            this.SalaryCalcualtionview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SalaryCalcualtionview.Size = new System.Drawing.Size(805, 171);
            this.SalaryCalcualtionview.TabIndex = 26;
            this.SalaryCalcualtionview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalaryCalcualtionview_CellContentClick);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalaryCalcualtionview);
            this.Controls.Add(this.SalaryBTN);
            this.Controls.Add(this.ButtonToSettingDash);
            this.Controls.Add(this.ButtonToEmpDash);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Salary";
            this.Text = "Salary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryCalcualtionview)).EndInit();
            this.ResumeLayout(false);

        }

        private void SalaryBTN_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label No_Paysalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Hoilday_salary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Absentdays;
        private System.Windows.Forms.Button ButtonToEmpDash;
        private System.Windows.Forms.Button ButtonToSettingDash;
        private System.Windows.Forms.Button SalaryBTN;
        public System.Windows.Forms.DataGridView SalaryCalcualtionview;
        public System.Windows.Forms.ComboBox Salary_EmpId;
        public System.Windows.Forms.Button Edit_salary;
        public System.Windows.Forms.Button Add_Salary;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button Calculate;
        public System.Windows.Forms.TextBox NoPay_Salary;
        public System.Windows.Forms.TextBox OT_Salary;
        public System.Windows.Forms.TextBox Absent_Salary;
        public System.Windows.Forms.TextBox FNam_Salary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Start_Sal_CB;
        public System.Windows.Forms.ComboBox End_Sal_CB;
        public System.Windows.Forms.ComboBox Range_Sal_CB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox OT_Salary_CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GrossPay;
        public System.Windows.Forms.TextBox Gross_Salary;
        private System.Windows.Forms.Label BasePay_Salary;
        public System.Windows.Forms.ComboBox Holiday_Salary;
        public System.Windows.Forms.TextBox Base_Pay;
        public System.Windows.Forms.ComboBox MonthlyPay;
        private System.Windows.Forms.Label BasePay;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox HolidatTkn_Salary;
        private System.Windows.Forms.Label label7;
    }
}