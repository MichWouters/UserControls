﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace UserControls
{
    public partial class DynamicControls : Form
    {
        private IPizzaRepo pizzaRepo;

        public DynamicControls()
        {
            InitializeComponent();
            pizzaRepo = new PizzaRepo();
            var pizzas = pizzaRepo.GetPizzas();
            GenerateControlsForPizzas(pizzas);
        }

        private void GenerateControlsForPizzas(IEnumerable<IPizza> pizzas)
        {
            int i = 1;
            foreach (IPizza pizza in pizzas)
            {
                MyUserControl myUserControl = new MyUserControl
                {
                    Name = $"MyUserControl{i}",
                    PizzaID = pizza.ID,
                    MyProductName = pizza.Name,
                    Price = pizza.Price.ToString(),
                    IsInStock = pizza.IsInStock,
                    Comments = pizza.Comments,
                    Image = pizza.Image
                };

                i++;

                flowLayoutPanel1.Controls.Add(myUserControl);
            }
        }
    }
}