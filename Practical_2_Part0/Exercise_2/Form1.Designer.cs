namespace Exercise_2
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
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnRepresentative = new System.Windows.Forms.Button();
            this.btnSeller = new System.Windows.Forms.Button();
            this.btnProducer = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.userControlSeller1 = new Exercise_2.userControlSeller();
            this.userControlRepresentative1 = new Exercise_2.userControlRepresentative();
            this.userControlProducer1 = new Exercise_2.userControlProducer();
            this.userControlPersonnel1 = new Exercise_2.userControlPersonnel();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Location = new System.Drawing.Point(-1, -1);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(138, 46);
            this.btnPersonnel.TabIndex = 0;
            this.btnPersonnel.Text = "Personnel";
            this.btnPersonnel.UseVisualStyleBackColor = true;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnRepresentative
            // 
            this.btnRepresentative.Location = new System.Drawing.Point(133, -1);
            this.btnRepresentative.Name = "btnRepresentative";
            this.btnRepresentative.Size = new System.Drawing.Size(138, 46);
            this.btnRepresentative.TabIndex = 1;
            this.btnRepresentative.Text = "Representative";
            this.btnRepresentative.UseVisualStyleBackColor = true;
            this.btnRepresentative.Click += new System.EventHandler(this.btnRepresentative_Click);
            // 
            // btnSeller
            // 
            this.btnSeller.Location = new System.Drawing.Point(268, -1);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(138, 46);
            this.btnSeller.TabIndex = 2;
            this.btnSeller.Text = "Seller";
            this.btnSeller.UseVisualStyleBackColor = true;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // btnProducer
            // 
            this.btnProducer.Location = new System.Drawing.Point(401, -1);
            this.btnProducer.Name = "btnProducer";
            this.btnProducer.Size = new System.Drawing.Size(138, 46);
            this.btnProducer.TabIndex = 3;
            this.btnProducer.Text = "Producer";
            this.btnProducer.UseVisualStyleBackColor = true;
            this.btnProducer.Click += new System.EventHandler(this.btnProducer_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.userControlSeller1);
            this.panelControl.Controls.Add(this.userControlRepresentative1);
            this.panelControl.Controls.Add(this.userControlProducer1);
            this.panelControl.Controls.Add(this.userControlPersonnel1);
            this.panelControl.Location = new System.Drawing.Point(-1, 44);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(846, 445);
            this.panelControl.TabIndex = 4;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // userControlSeller1
            // 
            this.userControlSeller1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSeller1.Location = new System.Drawing.Point(0, 0);
            this.userControlSeller1.Name = "userControlSeller1";
            this.userControlSeller1.Size = new System.Drawing.Size(846, 445);
            this.userControlSeller1.TabIndex = 3;
            this.userControlSeller1.Load += new System.EventHandler(this.userControlSeller1_Load);
            // 
            // userControlRepresentative1
            // 
            this.userControlRepresentative1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRepresentative1.Location = new System.Drawing.Point(0, 0);
            this.userControlRepresentative1.Name = "userControlRepresentative1";
            this.userControlRepresentative1.Size = new System.Drawing.Size(846, 445);
            this.userControlRepresentative1.TabIndex = 2;
            // 
            // userControlProducer1
            // 
            this.userControlProducer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlProducer1.Location = new System.Drawing.Point(0, 0);
            this.userControlProducer1.Name = "userControlProducer1";
            this.userControlProducer1.Size = new System.Drawing.Size(846, 445);
            this.userControlProducer1.TabIndex = 1;
            // 
            // userControlPersonnel1
            // 
            this.userControlPersonnel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPersonnel1.Location = new System.Drawing.Point(0, 0);
            this.userControlPersonnel1.Name = "userControlPersonnel1";
            this.userControlPersonnel1.Size = new System.Drawing.Size(846, 445);
            this.userControlPersonnel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 636);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.btnProducer);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.btnRepresentative);
            this.Controls.Add(this.btnPersonnel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Button btnPersonnel;
        private Button btnRepresentative;
        private Button btnSeller;
        private Button btnProducer;
        private Panel panelControl;
        private userControlPersonnel userControlPersonnel1;
        private userControlProducer userControlProducer1;
        private userControlRepresentative userControlRepresentative1;
        private userControlSeller userControlSeller1;
    }
}