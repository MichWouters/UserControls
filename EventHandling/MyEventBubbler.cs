using System;
using System.Windows.Forms;

namespace EventHandling
{
    public partial class MyEventBubbler : UserControl
    {
        public MyEventBubbler()
        {
            InitializeComponent();
        }

        public string ButtonText
        {
            get
            {
                return button1.Text;
            }
            set
            {
                button1.Text = value;
            }
        }

        public bool MyCheckbox
        {
            get
            {
                return checkBox1.Checked;
            }
            set
            {
                checkBox1.Checked = value;
            }
        }

        // Event handling in child -> Raise a flag/event when something has changed
        public event EventHandler ButtonClickedMeClicked;
        public event EventHandler CheckboxChanged;

        protected virtual void OnButtonClickMeClicked(EventArgs e)
        {
            ButtonClickedMeClicked?.Invoke(this, e);
        }

        protected virtual void OnCheckBoxChanged(EventArgs e)
        {
            CheckboxChanged?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnButtonClickMeClicked(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckBoxChanged(e);
        }
    }
}