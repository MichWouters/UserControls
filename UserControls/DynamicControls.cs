using System.Collections.Generic;
using System.Windows.Forms;

namespace UserControls
{
    public partial class DynamicControls : Form
    {
        public DynamicControls()
        {
            InitializeComponent();
            var pizzas = GetPizzas();
            GenerateControlsForPizzas(pizzas);
        }

        private void GenerateControlsForPizzas(IEnumerable<IPizza> pizzas)
        {
            int X = 0;
            foreach (IPizza pizza in pizzas)
            {
                MyUserControl myUserControl = new MyUserControl();
                myUserControl.MyProductName = pizza.Name;
                myUserControl.Price = pizza.Price.ToString();
                myUserControl.IsInStock = pizza.IsInStock;
                myUserControl.Comments = pizza.Comments;
                myUserControl.Image = pizza.Image;


                flowLayoutPanel1.Controls.Add(myUserControl);
            }
        }

        private List<IPizza> GetPizzas()
        {
            const string PATH = @"C:\Users\michi\OneDrive\Pictures\Saved Pictures\";
            var pizzas = new List<IPizza>
            {
                new Pizza("BBQ Chicken", 10, $"{PATH}margherita.jpg"),
                new Pizza("Hawaii", 7.45, $"{PATH}meatlovers.jpg"),
                new Pizza("Carpaccio", 11000, $"{PATH}pepperoni.jpg"),
                new Pizza("Margherita", 5, $"{PATH}supreme.jpg"),
                new Pizza("Diavolo"),
                new Pizza("Curry Oriental"),
                new Pizza("Funghi"),
            };

            return pizzas;
        }
    }
}