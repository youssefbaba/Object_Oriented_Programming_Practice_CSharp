using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2
{
    public partial class userControlPersonnel : UserControl
    {
        public userControlPersonnel()
        {
            InitializeComponent();
        }

        private void btnPersonnelList_Click(object sender, EventArgs e)
        {

           
            if (Form1.Personnel.NumberEmployees() != 0)
            {
                labelMessageError.Text = string.Empty;
                listBoxPersonnelList.Items.Clear();
                listBoxPersonnelList.BeginUpdate();
                foreach (var item in Form1.Personnel.Show())
                {
                    listBoxPersonnelList.Items.Add(item.ToString());
                }
                listBoxPersonnelList.EndUpdate();
            }
            else
            {
                labelMessageError.Text = "Please try to add a new employee because your list is empty now !";
            }
        }

        private void btnAverageSalary_Click(object sender, EventArgs e)
        {
            if (Form1.Personnel.NumberEmployees() != 0)
            {
                textBoxAverageSalary.Text = Form1.Personnel.AverageSalary().ToString();
            }
            else
            {
                textBoxAverageSalary.Text = $"{0}";
            }
        }

        private void btnNumberEmployees_Click(object sender, EventArgs e)
        {
            if (Form1.Personnel.NumberEmployees() != 0)
            {
                textBoxNumberEmployees.Text = Form1.Personnel.NumberEmployees().ToString();
            }
            else
            {
                textBoxNumberEmployees.Text = $"{0}";
            }
        }

    }
}
