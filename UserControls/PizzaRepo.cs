using System.Collections.Generic;
using System.Linq;

namespace UserControls
{
    /// <summary>
    /// Repository class. Used for methods that Retrieve and Persist data.
    /// </summary>
    public class PizzaRepo : IPizzaRepo
    {
        public List<IPizza> GetPizzas()
        {
            const string PATH = @"C:\Users\michi\OneDrive\Pictures\Saved Pictures\";
            var pizzas = new List<IPizza>
            {
                new Pizza(1, "BBQ Chicken", 10, $"{PATH}margherita.jpg"),
                new Pizza(2, "Hawaii", 7.45, $"{PATH}meatlovers.jpg"),
                new Pizza(3, "Carpaccio", 11000, $"{PATH}pepperoni.jpg"),
                new Pizza(4, "Margherita", 5, $"{PATH}supreme.jpg"),
                new Pizza(5, "Diavolo"),
                new Pizza(6, "Curry Oriental"),
                new Pizza(7, "Funghi"),
                new Pizza(12, "Pepperoni"),
                new Pizza(13, "Cheesy Beezy"),
                new Pizza(14, "Meat Lovers"),
            };

            return pizzas;
        }

        public IPizza GetPizza(int id)
        {
            List<IPizza> allPizzas = GetPizzas();

            // LAMBDA Expression. Return the first object in which the ID property equals user input
            var selectedPizza = allPizzas.Where(x => x.ID == id).FirstOrDefault();

            // Lambda expression above is shorthand for code below
            //IPizza pizza;
            //foreach (IPizza item in allPizzas)
            //{
            //    if (item.ID == id)
            //    {
            //        pizza = item;
            //    }
            //}

            //return pizza;

            return selectedPizza;
        }
    }
}