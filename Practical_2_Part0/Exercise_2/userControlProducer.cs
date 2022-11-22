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
    public partial class userControlProducer : UserControl
    {
        public userControlProducer()
        {
            InitializeComponent();
        }

        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstNameProducer.Text;
            string lastName = textBoxLastNameProducer.Text;
            int age;
            bool checkAge = int.TryParse(textBoxAgeProducer.Text, out age);
            if (checkAge)
            {
                labelErrorAge.Text = string.Empty;
            }
            else
            {
                labelErrorAge.Text = $"Please try to enter a valid number which is between {int.MinValue} and {int.MaxValue} !";
            }

            int yearRecruitment;
            bool checkYearRecruitment = int.TryParse(textBoxYearRecruitmentProducer.Text, out yearRecruitment);
            if (checkYearRecruitment)
            {
                labelErrorYearRecruitment.Text = string.Empty;
            }
            else
            {
                labelErrorYearRecruitment.Text = $"Please try to enter a valid number which is between {int.MinValue} and {int.MaxValue} !";
            }

            int numberUnits;
            bool checkNumberUnits = int.TryParse(textBoxNumberUnitsProducer.Text, out numberUnits);
            if (checkNumberUnits)
            {
                labelErrorNumberUnits.Text = string.Empty;
            }
            else
            {
                labelErrorNumberUnits.Text = $"Please try to enter a valid number which is between {double.MinValue} and {double.MaxValue} !";
            }
            if (checkAge && checkNumberUnits && checkYearRecruitment)
            {
                labelErrorAdd.Text = string.Empty;
                Form1.Personnel.AddEmployee(new Producer(firstName, lastName, age, yearRecruitment, numberUnits));
                ClearTextBoxes();
            }
            else
            {
                labelErrorAdd.Text = "Please try to correct these errors above !";
            }
        }
        private void ClearTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = string.Empty;
                }
            }
        }
    }
}
