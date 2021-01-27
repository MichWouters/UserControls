using System;
using System.Windows.Forms;

namespace UserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myUserControl1.MyProductName = "A Product";
        }

        private void btnDynamic_Click(object sender, EventArgs e)
        {
            DynamicControls controls = new DynamicControls();
            controls.Show();
        }
    }
}