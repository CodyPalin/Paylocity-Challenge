namespace Paylocity_Challenge
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Employees = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeeList = new System.Windows.Forms.ListBox();
            this.Summary = new System.Windows.Forms.TabPage();
            this.YearlyCost = new System.Windows.Forms.Label();
            this.NumEmployees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeInfo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Employees.SuspendLayout();
            this.Summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Employees);
            this.tabControl1.Controls.Add(this.Summary);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 450);
            this.tabControl1.TabIndex = 4;
            // 
            // Employees
            // 
            this.Employees.BackColor = System.Drawing.SystemColors.Control;
            this.Employees.Controls.Add(this.EmployeeInfo);
            this.Employees.Controls.Add(this.button2);
            this.Employees.Controls.Add(this.button1);
            this.Employees.Controls.Add(this.EmployeeList);
            this.Employees.Location = new System.Drawing.Point(4, 22);
            this.Employees.Name = "Employees";
            this.Employees.Padding = new System.Windows.Forms.Padding(3);
            this.Employees.Size = new System.Drawing.Size(380, 424);
            this.Employees.TabIndex = 0;
            this.Employees.Text = "Employees";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(272, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Dependent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddDependent_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeList.DisplayMember = "name";
            this.EmployeeList.FormattingEnabled = true;
            this.EmployeeList.Location = new System.Drawing.Point(0, 43);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(380, 355);
            this.EmployeeList.TabIndex = 0;
            this.EmployeeList.SelectedIndexChanged += new System.EventHandler(this.EmployeeList_SelectedIndexChanged);
            // 
            // Summary
            // 
            this.Summary.BackColor = System.Drawing.SystemColors.Control;
            this.Summary.Controls.Add(this.YearlyCost);
            this.Summary.Controls.Add(this.NumEmployees);
            this.Summary.Controls.Add(this.label2);
            this.Summary.Controls.Add(this.label1);
            this.Summary.Location = new System.Drawing.Point(4, 22);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(380, 424);
            this.Summary.TabIndex = 2;
            this.Summary.Text = "Summary";
            // 
            // YearlyCost
            // 
            this.YearlyCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YearlyCost.AutoSize = true;
            this.YearlyCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearlyCost.Location = new System.Drawing.Point(304, 91);
            this.YearlyCost.Name = "YearlyCost";
            this.YearlyCost.Size = new System.Drawing.Size(27, 20);
            this.YearlyCost.TabIndex = 3;
            this.YearlyCost.Text = "$0";
            // 
            // NumEmployees
            // 
            this.NumEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumEmployees.AutoSize = true;
            this.NumEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumEmployees.Location = new System.Drawing.Point(313, 45);
            this.NumEmployees.Name = "NumEmployees";
            this.NumEmployees.Size = new System.Drawing.Size(18, 20);
            this.NumEmployees.TabIndex = 2;
            this.NumEmployees.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost Per Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of employees:";
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeInfo.AutoSize = true;
            this.EmployeeInfo.Location = new System.Drawing.Point(6, 402);
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Size = new System.Drawing.Size(92, 13);
            this.EmployeeInfo.TabIndex = 3;
            this.EmployeeInfo.Text = "Add an employee.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Employee Cost Application";
            this.tabControl1.ResumeLayout(false);
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox EmployeeList;
        private System.Windows.Forms.TabPage Summary;
        private System.Windows.Forms.Label YearlyCost;
        private System.Windows.Forms.Label NumEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmployeeInfo;
    }
}

