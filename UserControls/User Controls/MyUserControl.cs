using System.Windows.Forms;

namespace UserControls
{
    public partial class MyUserControl : UserControl
    {
        private ShoppingCart _cart;
        private IPizzaRepo _repo;

        public MyUserControl()
        {
            InitializeComponent();
            _cart = ShoppingCart.GetShoppingCart();
            _repo = new PizzaRepo();
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

        public void btnCart_Click(object sender, System.EventArgs e)
        {
            var pizza = _repo.GetPizza(PizzaID);
            _cart.AddProductToCart(pizza);
        }
    }
}