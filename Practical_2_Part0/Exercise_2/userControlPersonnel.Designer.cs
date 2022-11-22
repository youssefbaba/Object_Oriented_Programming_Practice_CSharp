namespace Exercise_2
{
    partial class userControlPersonnel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPersonnelList = new System.Windows.Forms.Button();
            this.btnAverageSalary = new System.Windows.Forms.Button();
            this.btnNumberEmployees = new System.Windows.Forms.Button();
            this.listBoxPersonnelList = new System.Windows.Forms.ListBox();
            this.textBoxAverageSalary = new System.Windows.Forms.TextBox();
            this.textBoxNumberEmployees = new System.Windows.Forms.TextBox();
            this.labelMessageError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonnelList
            // 
            this.btnPersonnelList.Location = new System.Drawing.Point(0, 72);
            this.btnPersonnelList.Name = "btnPersonnelList";
            this.btnPersonnelList.Size = new System.Drawing.Size(185, 25);
            this.btnPersonnelList.TabIndex = 0;
            this.btnPersonnelList.Text = "Personnel List";
            this.btnPersonnelList.UseVisualStyleBackColor = true;
            this.btnPersonnelList.Click += new System.EventHandler(this.btnPersonnelList_Click);
            // 
            // btnAverageSalary
            // 
            this.btnAverageSalary.Location = new System.Drawing.Point(0, 296);
            this.btnAverageSalary.Name = "btnAverageSalary";
            this.btnAverageSalary.Size = new System.Drawing.Size(185, 25);
            this.btnAverageSalary.TabIndex = 1;
            this.btnAverageSalary.Text = "Average Salary";
            this.btnAverageSalary.UseVisualStyleBackColor = true;
            this.btnAverageSalary.Click += new System.EventHandler(this.btnAverageSalary_Click);
            // 
            // btnNumberEmployees
            // 
            this.btnNumberEmployees.Location = new System.Drawing.Point(320, 296);
            this.btnNumberEmployees.Name = "btnNumberEmployees";
            this.btnNumberEmployees.Size = new System.Drawing.Size(185, 25);
            this.btnNumberEmployees.TabIndex = 2;
            this.btnNumberEmployees.Text = "Number Of Employees";
            this.btnNumberEmployees.UseVisualStyleBackColor = true;
            this.btnNumberEmployees.Click += new System.EventHandler(this.btnNumberEmployees_Click);
            // 
            // listBoxPersonnelList
            // 
            this.listBoxPersonnelList.FormattingEnabled = true;
            this.listBoxPersonnelList.ItemHeight = 17;
            this.listBoxPersonnelList.Location = new System.Drawing.Point(0, 133);
            this.listBoxPersonnelList.Name = "listBoxPersonnelList";
            this.listBoxPersonnelList.Size = new System.Drawing.Size(693, 123);
            this.listBoxPersonnelList.TabIndex = 3;
            // 
            // textBoxAverageSalary
            // 
            this.textBoxAverageSalary.Location = new System.Drawing.Point(0, 336);
            this.textBoxAverageSalary.Name = "textBoxAverageSalary";
            this.textBoxAverageSalary.Size = new System.Drawing.Size(185, 25);
            this.textBoxAverageSalary.TabIndex = 4;
            // 
            // textBoxNumberEmployees
            // 
            this.textBoxNumberEmployees.Location = new System.Drawing.Point(320, 336);
            this.textBoxNumberEmployees.Name = "textBoxNumberEmployees";
            this.textBoxNumberEmployees.Size = new System.Drawing.Size(185, 25);
            this.textBoxNumberEmployees.TabIndex = 5;
            // 
            // labelMessageError
            // 
            this.labelMessageError.AutoSize = true;
            this.labelMessageError.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMessageError.ForeColor = System.Drawing.Color.Red;
            this.labelMessageError.Location = new System.Drawing.Point(2, 102);
            this.labelMessageError.Name = "labelMessageError";
            this.labelMessageError.Size = new System.Drawing.Size(0, 17);
            this.labelMessageError.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(374, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Personnel Page";
            // 
            // userControlPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMessageError);
            this.Controls.Add(this.textBoxNumberEmployees);
            this.Controls.Add(this.textBoxAverageSalary);
            this.Controls.Add(this.listBoxPersonnelList);
            this.Controls.Add(this.btnNumberEmployees);
            this.Controls.Add(this.btnAverageSalary);
            this.Controls.Add(this.btnPersonnelList);
            this.Name = "userControlPersonnel";
            this.Size = new System.Drawing.Size(846, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPersonnelList;
        private Button btnAverageSalary;
        private Button btnNumberEmployees;
        private ListBox listBoxPersonnelList;
        private TextBox textBoxAverageSalary;
        private TextBox textBoxNumberEmployees;
        private Label labelMessageError;
        private Label label1;
    }
}
