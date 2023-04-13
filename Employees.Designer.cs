using System;
using System.Windows.Forms;

namespace Grifindo_Toy
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DOJ = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Designation = new System.Windows.Forms.TextBox();
            this.Desig = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Gtax = new System.Windows.Forms.TextBox();
            this.Add_Emp = new System.Windows.Forms.Button();
            this.SeachBTNEmp = new System.Windows.Forms.Button();
            this.Del_Emp = new System.Windows.Forms.Button();
            this.UpdateEmp = new System.Windows.Forms.Button();
            this.Allow = new System.Windows.Forms.TextBox();
            this.OTRate = new System.Windows.Forms.TextBox();
            this.MBSalary = new System.Windows.Forms.TextBox();
            this.LNam = new System.Windows.Forms.TextBox();
            this.FNam = new System.Windows.Forms.TextBox();
            this.EmpId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonToEmpDash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Setting_btn_Emp_Form = new System.Windows.Forms.Button();
            this.EmployeeDataview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.DOJ);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Designation);
            this.panel1.Controls.Add(this.Desig);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.Gtax);
            this.panel1.Controls.Add(this.Add_Emp);
            this.panel1.Controls.Add(this.SeachBTNEmp);
            this.panel1.Controls.Add(this.Del_Emp);
            this.panel1.Controls.Add(this.UpdateEmp);
            this.panel1.Controls.Add(this.Allow);
            this.panel1.Controls.Add(this.OTRate);
            this.panel1.Controls.Add(this.MBSalary);
            this.panel1.Controls.Add(this.LNam);
            this.panel1.Controls.Add(this.FNam);
            this.panel1.Controls.Add(this.EmpId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(208, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 264);
            this.panel1.TabIndex = 4;
            // 
            // DOJ
            // 
            this.DOJ.Location = new System.Drawing.Point(405, 64);
            this.DOJ.Name = "DOJ";
            this.DOJ.Size = new System.Drawing.Size(200, 20);
            this.DOJ.TabIndex = 27;
            this.DOJ.Value = new System.DateTime(2023, 4, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date Of Joining";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Designation
            // 
            this.Designation.Location = new System.Drawing.Point(94, 100);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(100, 20);
            this.Designation.TabIndex = 24;
            // 
            // Desig
            // 
            this.Desig.AutoSize = true;
            this.Desig.Location = new System.Drawing.Point(13, 98);
            this.Desig.Name = "Desig";
            this.Desig.Size = new System.Drawing.Size(63, 13);
            this.Desig.TabIndex = 23;
            this.Desig.Text = "Designation";
            this.Desig.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(196, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Employee List";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "GTAX";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Gtax
            // 
            this.Gtax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gtax.Location = new System.Drawing.Point(94, 206);
            this.Gtax.Name = "Gtax";
            this.Gtax.Size = new System.Drawing.Size(100, 20);
            this.Gtax.TabIndex = 21;
            // 
            // Add_Emp
            // 
            this.Add_Emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Add_Emp.Location = new System.Drawing.Point(219, 207);
            this.Add_Emp.Name = "Add_Emp";
            this.Add_Emp.Size = new System.Drawing.Size(75, 23);
            this.Add_Emp.TabIndex = 20;
            this.Add_Emp.Text = "Add";
            this.Add_Emp.UseVisualStyleBackColor = false;
            this.Add_Emp.Click += new System.EventHandler(this.Add_Emp_Click_1);
            // 
            // SeachBTNEmp
            // 
            this.SeachBTNEmp.BackColor = System.Drawing.Color.Lime;
            this.SeachBTNEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SeachBTNEmp.Location = new System.Drawing.Point(200, 46);
            this.SeachBTNEmp.Name = "SeachBTNEmp";
            this.SeachBTNEmp.Size = new System.Drawing.Size(75, 23);
            this.SeachBTNEmp.TabIndex = 17;
            this.SeachBTNEmp.Text = "Search";
            this.SeachBTNEmp.UseVisualStyleBackColor = false;
            // 
            // Del_Emp
            // 
            this.Del_Emp.BackColor = System.Drawing.Color.Crimson;
            this.Del_Emp.Location = new System.Drawing.Point(405, 206);
            this.Del_Emp.Name = "Del_Emp";
            this.Del_Emp.Size = new System.Drawing.Size(75, 23);
            this.Del_Emp.TabIndex = 16;
            this.Del_Emp.Text = "Delete";
            this.Del_Emp.UseVisualStyleBackColor = false;
            this.Del_Emp.Click += new System.EventHandler(this.Del_Emp_Click);
            // 
            // UpdateEmp
            // 
            this.UpdateEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpdateEmp.Location = new System.Drawing.Point(315, 207);
            this.UpdateEmp.Name = "UpdateEmp";
            this.UpdateEmp.Size = new System.Drawing.Size(75, 23);
            this.UpdateEmp.TabIndex = 15;
            this.UpdateEmp.Text = "Update";
            this.UpdateEmp.UseVisualStyleBackColor = false;
            this.UpdateEmp.Click += new System.EventHandler(this.UpdateEmp_Click);
            // 
            // Allow
            // 
            this.Allow.Location = new System.Drawing.Point(94, 180);
            this.Allow.Name = "Allow";
            this.Allow.Size = new System.Drawing.Size(100, 20);
            this.Allow.TabIndex = 13;
            // 
            // OTRate
            // 
            this.OTRate.Location = new System.Drawing.Point(94, 154);
            this.OTRate.Name = "OTRate";
            this.OTRate.Size = new System.Drawing.Size(100, 20);
            this.OTRate.TabIndex = 12;
            // 
            // MBSalary
            // 
            this.MBSalary.Location = new System.Drawing.Point(94, 128);
            this.MBSalary.Name = "MBSalary";
            this.MBSalary.Size = new System.Drawing.Size(100, 20);
            this.MBSalary.TabIndex = 11;
            // 
            // LNam
            // 
            this.LNam.Location = new System.Drawing.Point(94, 74);
            this.LNam.Name = "LNam";
            this.LNam.Size = new System.Drawing.Size(100, 20);
            this.LNam.TabIndex = 10;
            // 
            // FNam
            // 
            this.FNam.Location = new System.Drawing.Point(94, 48);
            this.FNam.Name = "FNam";
            this.FNam.Size = new System.Drawing.Size(100, 20);
            this.FNam.TabIndex = 9;
            this.FNam.Tag = "@FNm";
            // 
            // EmpId
            // 
            this.EmpId.Location = new System.Drawing.Point(94, 17);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(100, 20);
            this.EmpId.TabIndex = 8;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Allowance :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Over time rate :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Monthly Salary :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Last Name :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "First Name :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Grifindo_Toy.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 406);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonToEmpDash
            // 
            this.ButtonToEmpDash.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonToEmpDash.Location = new System.Drawing.Point(12, 27);
            this.ButtonToEmpDash.Name = "ButtonToEmpDash";
            this.ButtonToEmpDash.Size = new System.Drawing.Size(165, 53);
            this.ButtonToEmpDash.TabIndex = 32;
            this.ButtonToEmpDash.Text = "EmployeeDashboard";
            this.ButtonToEmpDash.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 42);
            this.button1.TabIndex = 33;
            this.button1.Text = "Salary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setting_btn_Emp_Form
            // 
            this.Setting_btn_Emp_Form.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Setting_btn_Emp_Form.Location = new System.Drawing.Point(12, 134);
            this.Setting_btn_Emp_Form.Name = "Setting_btn_Emp_Form";
            this.Setting_btn_Emp_Form.Size = new System.Drawing.Size(165, 44);
            this.Setting_btn_Emp_Form.TabIndex = 34;
            this.Setting_btn_Emp_Form.Text = "Setting";
            this.Setting_btn_Emp_Form.UseVisualStyleBackColor = false;
            this.Setting_btn_Emp_Form.Click += new System.EventHandler(this.Setting_btn_Emp_Form_Click);
            // 
            // EmployeeDataview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmployeeDataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeDataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.EmployeeDataview.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.EmployeeDataview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeeDataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataview.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.EmployeeDataview.Location = new System.Drawing.Point(0, 262);
            this.EmployeeDataview.Name = "EmployeeDataview";
            this.EmployeeDataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataview.Size = new System.Drawing.Size(845, 171);
            this.EmployeeDataview.TabIndex = 35;
            this.EmployeeDataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataview_CellContentClick);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 430);
            this.Controls.Add(this.Setting_btn_Emp_Form);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonToEmpDash);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EmployeeDataview);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Employee";
            this.Text = "Employees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataview)).EndInit();
            this.ResumeLayout(false);

        }

        private void EmpDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox Allow;
        public System.Windows.Forms.TextBox OTRate;
        public System.Windows.Forms.TextBox MBSalary;
        public System.Windows.Forms.TextBox LNam;
        public System.Windows.Forms.TextBox FNam;
        public System.Windows.Forms.TextBox EmpId;
        public System.Windows.Forms.Button SeachBTNEmp;
        public System.Windows.Forms.Button Del_Emp;
        public System.Windows.Forms.Button UpdateEmp;
        public System.Windows.Forms.Button Add_Emp;
        public System.Windows.Forms.TextBox Gtax;
        public System.Windows.Forms.TextBox Designation;
        private System.Windows.Forms.Label Desig;
        private System.Windows.Forms.Button ButtonToEmpDash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Setting_btn_Emp_Form;
        public DataGridView EmployeeDataview;
        private Label label1;
        public DateTimePicker DOJ;
    }
}