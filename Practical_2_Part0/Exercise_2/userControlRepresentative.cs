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
    public partial class userControlRepresentative : UserControl
    {
        public userControlRepresentative()
        {
            InitializeComponent();
        }
        private void btnAddRepresentative_Click(object sender, EventArgs e)
        {

            Personnel personnel1 = new Personnel();

            string firstName = textBoxFirstNameRepresentative.Text;
            string lastName = textBoxLastNameRepresentative.Text;
            int age;
            bool checkAge = int.TryParse(textBoxAgeRepresentative.Text, out age);
            if (checkAge)
            {
                labelErrorAge.Text = string.Empty;
            }
            else
            {
                labelErrorAge.Text = $"Please try to enter a valid number which is between {int.MinValue} and {int.MaxValue} !";
            }

            int yearRecruitment;
            bool checkYearRecruitment = int.TryParse(textBoxYearRecruitmentRepresentative.Text, out yearRecruitment);
            if (checkYearRecruitment)
            {
                labelErrorYearRecruitment.Text = string.Empty;
            }
            else
            {
                labelErrorYearRecruitment.Text = $"Please try to enter a valid number which is between {int.MinValue} and {int.MaxValue} !";
            }

            double income;
            bool checkIncome = double.TryParse(textBoxIncomeRepresentative.Text, out income);
            if (checkIncome)
            {
                labelErrorIncome.Text = string.Empty;
            }
            else
            {
                labelErrorIncome.Text = $"Please try to enter a valid number which is between {double.MinValue} and {double.MaxValue} !";
            }
            if (checkAge && checkIncome && checkYearRecruitment)
            {
                labelErrorAdd.Text = string.Empty;
                Form1.Personnel.AddEmployee(new Representative(firstName, lastName, age, yearRecruitment, income));
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
