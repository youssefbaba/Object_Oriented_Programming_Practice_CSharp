using System.Security.Cryptography.X509Certificates;

namespace Exercise_2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            Load  += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            SetActivePanel(userControlPersonnel1);
        }

        public void SetActivePanel(UserControl control)
        {
            userControlPersonnel1.Visible = false;
            userControlRepresentative1.Visible = false;
            userControlSeller1.Visible = false;
            userControlProducer1.Visible = false;
            control.Visible = true;
        }
        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControlPersonnel1);
        }
        private void btnRepresentative_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControlRepresentative1);  
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControlSeller1);
        }

        private void btnProducer_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControlProducer1);
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlSeller1_Load(object sender, EventArgs e)
        {

        }

        // Properties
        public static Personnel Personnel { get; set; }  = new Personnel();
    }
}
