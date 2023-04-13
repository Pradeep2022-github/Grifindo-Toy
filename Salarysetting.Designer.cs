namespace Grifindo_Toy
{
    partial class Salarysetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpIdCB = new System.Windows.Forms.ComboBox();
            this.Set = new System.Windows.Forms.Button();
            this.Del_Emp_Setting = new System.Windows.Forms.Button();
            this.UpdateEmpSetting = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.FNam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.RangeofSalary = new System.Windows.Forms.TextBox();
            this.HolidayAnnual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Salarysettingview = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonToEmpDash = new System.Windows.Forms.Button();
            this.ButtonToSalaryDash = new System.Windows.Forms.Button();
            this.ButtonToSettingDash = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salarysettingview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.EmpIdCB);
            this.panel1.Controls.Add(this.Set);
            this.panel1.Controls.Add(this.Del_Emp_Setting);
            this.panel1.Controls.Add(this.UpdateEmpSetting);
            this.panel1.Controls.Add(this.End);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.FNam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.RangeofSalary);
            this.panel1.Controls.Add(this.HolidayAnnual);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(201, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 426);
            this.panel1.TabIndex = 30;
            // 
            // EmpIdCB
            // 
            this.EmpIdCB.BackColor = System.Drawing.Color.Plum;
            this.EmpIdCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpIdCB.FormattingEnabled = true;
            this.EmpIdCB.Location = new System.Drawing.Point(144, 18);
            this.EmpIdCB.Name = "EmpIdCB";
            this.EmpIdCB.Size = new System.Drawing.Size(101, 21);
            this.EmpIdCB.TabIndex = 33;
            this.EmpIdCB.SelectionChangeCommitted += new System.EventHandler(this.EmpIdCB_SelectionChangeCommitted);
            // 
            // Set
            // 
            this.Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Set.Location = new System.Drawing.Point(149, 166);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(75, 23);
            this.Set.TabIndex = 32;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = false;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Del_Emp_Setting
            // 
            this.Del_Emp_Setting.BackColor = System.Drawing.Color.Crimson;
            this.Del_Emp_Setting.Location = new System.Drawing.Point(335, 166);
            this.Del_Emp_Setting.Name = "Del_Emp_Setting";
            this.Del_Emp_Setting.Size = new System.Drawing.Size(75, 23);
            this.Del_Emp_Setting.TabIndex = 31;
            this.Del_Emp_Setting.Text = "Remove";
            this.Del_Emp_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Del_Emp_Setting.UseVisualStyleBackColor = false;
            this.Del_Emp_Setting.Click += new System.EventHandler(this.Del_Emp_Setting_Click);
            // 
            // UpdateEmpSetting
            // 
            this.UpdateEmpSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UpdateEmpSetting.Location = new System.Drawing.Point(245, 166);
            this.UpdateEmpSetting.Name = "UpdateEmpSetting";
            this.UpdateEmpSetting.Size = new System.Drawing.Size(75, 23);
            this.UpdateEmpSetting.TabIndex = 30;
            this.UpdateEmpSetting.Text = "Edit";
            this.UpdateEmpSetting.UseVisualStyleBackColor = false;
            this.UpdateEmpSetting.Click += new System.EventHandler(this.UpdateEmpSetting_Click);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(419, 68);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(131, 20);
            this.End.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cycle End Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(269, 68);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(131, 20);
            this.Start.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Annual Leave Allocation :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FNam
            // 
            this.FNam.Enabled = false;
            this.FNam.Location = new System.Drawing.Point(320, 18);
            this.FNam.Name = "FNam";
            this.FNam.Size = new System.Drawing.Size(100, 20);
            this.FNam.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 21);
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
            this.label10.Location = new System.Drawing.Point(131, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Salary Setting View";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(426, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // RangeofSalary
            // 
            this.RangeofSalary.Location = new System.Drawing.Point(144, 114);
            this.RangeofSalary.Name = "RangeofSalary";
            this.RangeofSalary.Size = new System.Drawing.Size(100, 20);
            this.RangeofSalary.TabIndex = 12;
            // 
            // HolidayAnnual
            // 
            this.HolidayAnnual.Location = new System.Drawing.Point(144, 68);
            this.HolidayAnnual.Name = "HolidayAnnual";
            this.HolidayAnnual.Size = new System.Drawing.Size(100, 20);
            this.HolidayAnnual.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee ID :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cycle Date Range";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cycle Start Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Salarysettingview
            // 
            this.Salarysettingview.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.Salarysettingview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Salarysettingview.Location = new System.Drawing.Point(1, 275);
            this.Salarysettingview.Name = "Salarysettingview";
            this.Salarysettingview.Size = new System.Drawing.Size(799, 171);
            this.Salarysettingview.TabIndex = 18;
            this.Salarysettingview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Salarysettingview_CellContentClick);
            this.Salarysettingview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Salarysettingview_CellContentClick);
            this.Salarysettingview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Salarysettingview_CellContentClick);
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
            this.pictureBox2.Size = new System.Drawing.Size(212, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonToEmpDash
            // 
            this.ButtonToEmpDash.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonToEmpDash.Location = new System.Drawing.Point(12, 47);
            this.ButtonToEmpDash.Name = "ButtonToEmpDash";
            this.ButtonToEmpDash.Size = new System.Drawing.Size(165, 53);
            this.ButtonToEmpDash.TabIndex = 31;
            this.ButtonToEmpDash.Text = "EmployeeDashboard";
            this.ButtonToEmpDash.UseVisualStyleBackColor = false;
            this.ButtonToEmpDash.Click += new System.EventHandler(this.ButtonToEmpDash_Click);
            // 
            // ButtonToSalaryDash
            // 
            this.ButtonToSalaryDash.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonToSalaryDash.Location = new System.Drawing.Point(12, 126);
            this.ButtonToSalaryDash.Name = "ButtonToSalaryDash";
            this.ButtonToSalaryDash.Size = new System.Drawing.Size(165, 53);
            this.ButtonToSalaryDash.TabIndex = 35;
            this.ButtonToSalaryDash.Text = "Salary";
            this.ButtonToSalaryDash.UseVisualStyleBackColor = false;
            this.ButtonToSalaryDash.Click += new System.EventHandler(this.ButtonToSalaryDash_Click);
            // 
            // ButtonToSettingDash
            // 
            this.ButtonToSettingDash.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonToSettingDash.Location = new System.Drawing.Point(12, 216);
            this.ButtonToSettingDash.Name = "ButtonToSettingDash";
            this.ButtonToSettingDash.Size = new System.Drawing.Size(165, 53);
            this.ButtonToSettingDash.TabIndex = 36;
            this.ButtonToSettingDash.Text = "Setting";
            this.ButtonToSettingDash.UseVisualStyleBackColor = false;
            // 
            // Salarysetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salarysettingview);
            this.Controls.Add(this.ButtonToSettingDash);
            this.Controls.Add(this.ButtonToSalaryDash);
            this.Controls.Add(this.ButtonToEmpDash);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Salarysetting";
            this.Text = "Salary Setting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salarysettingview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox RangeofSalary;
        private System.Windows.Forms.TextBox HolidayAnnual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker End;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.Button ButtonToEmpDash;
        private System.Windows.Forms.Button ButtonToSalaryDash;
        private System.Windows.Forms.Button ButtonToSettingDash;
        public System.Windows.Forms.DataGridView Salarysettingview;
        public System.Windows.Forms.Button Set;
        public System.Windows.Forms.Button Del_Emp_Setting;
        public System.Windows.Forms.Button UpdateEmpSetting;
        private System.Windows.Forms.ComboBox EmpIdCB;
        public System.Windows.Forms.TextBox FNam;
    }
}