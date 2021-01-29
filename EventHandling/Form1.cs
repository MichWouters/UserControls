using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myEventBubbler1.ButtonText = "Click Me";
            myEventBubbler1.ButtonClickedMeClicked += OnButtonInUserControl_Clicked;
            myEventBubbler2.ButtonClickedMeClicked += OnButtonInUserControl_Clicked;

            myEventBubbler1.CheckboxChanged += OnCheckboxInUCChanged;
            myEventBubbler2.CheckboxChanged += OnCheckboxInUCChanged;
        }

        // Event Handling -> Listen for event
        private void OnButtonInUserControl_Clicked(object sender, EventArgs e)
        {
            MyEventBubbler myUserControl = sender as MyEventBubbler;

            string myButtonText = myUserControl.ButtonText;

            label1.Text = myButtonText;
        }

        private void OnCheckboxInUCChanged(object sender, EventArgs e)
        {
            MyEventBubbler myUserControl = sender as MyEventBubbler;

            MessageBox.Show($"Checkbox is checked = {myUserControl.MyCheckbox}");
        }
    }
}
