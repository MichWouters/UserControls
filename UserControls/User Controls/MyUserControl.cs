using System;
using System.Windows.Forms;

namespace UserControls
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        public int PizzaID { get; set; }

        public string MyProductName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string Price
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string Comments
        {
            get { return txtComments.Text; }
            set { txtComments.Text = value; }
        }

        public bool IsInStock
        {
            get { return chkInStock.Checked; }
            set { chkInStock.Checked = value; }
        }

        private string _image;

        public string Image
        {
            set
            {
                if (value != null)
                {
                    _image = value;
                    pictureBox1.ImageLocation = _image;
                    pictureBox1.Load(_image);
                }
            }
        }

        // Event Handler -> Raise an event from a child class
        // Delegate field -> Accepts a method instead of a value or instance
        public event EventHandler AddToCartButtonClicked;

        protected virtual void OnAddToCartButtonClicked(EventArgs e)
        {
            AddToCartButtonClicked?.Invoke(this, e);
        }

        public void btnCart_Click(object sender, System.EventArgs e)
        {
            // Pass child event to parent by raising it in an event which can be caught in parent
            OnAddToCartButtonClicked(e);
        }

        private void txtComments_TextChanged(object sender, EventArgs e)
        {

        }
    }
}