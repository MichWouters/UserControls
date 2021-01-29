using System;
using System.Windows.Forms;

namespace UserControls
{
    public partial class Form1 : Form
    {
        private IShoppingCart _cart;
        private IPizzaRepo _repo;

        public Form1()
        {
            InitializeComponent();

            _cart = ShoppingCart.GetShoppingCart();
            _repo = new PizzaRepo();

            // Event handling -> Hook up the delegate in the User Control class to a listener in this class
            //myUserControl1.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
            //myUserControl2.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
            //myUserControl3.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
            //myUserControl4.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
            //myUserControl5.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;

            // Do the same but dynamic. Foreach MyUserControl in control, hook up listener
            foreach (var control in this.Controls)
            {
                MyUserControl myUserControl = control as MyUserControl;

                if (myUserControl != null)
                {
                    myUserControl.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
                }
            }
        }

        private void btnDynamic_Click(object sender, EventArgs e)
        {
            DynamicControls controls = new DynamicControls();
            controls.Show();
        }

        // Event Handler -> Listeners, Listens for Events 
        // Catch event from children classes(User Controls)
        private void AddToCartButtonClickedInUserControl(object sender, EventArgs e)
        {
            // Cast object class to MyUserClass
            MyUserControl myControl = sender as MyUserControl;

            int productId = myControl.PizzaID;
            AddProductToCart(productId);
        }

        private void AddProductToCart(int productId)
        {
            var pizza = _repo.GetPizza(productId);
            _cart.AddProductToCart(pizza);
        }

        private void myUserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}