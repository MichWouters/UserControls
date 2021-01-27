using System.Collections.Generic;

namespace UserControls
{
    public class ShoppingCart : IShoppingCart
    {
        private List<IPizza> _pizzas;

        // SINGLETON Pattern => Only one instance of this item can exist
        private static ShoppingCart _cart;

        // Private constructor forbids external classes to create new instances
        private ShoppingCart()
        {
            _pizzas = new List<IPizza>();
        }

        // Singleton -> Create new object if one does not exist.
        // Then return the (existing) unique object.
        public static ShoppingCart GetShoppingCart()
        {
            if (_cart == null)
            {
                _cart = new ShoppingCart();
            }

            return _cart;
        }

        public void AddProductToCart(IPizza pizza)
        {
            _pizzas.Add(pizza);
        }

        // TODO: Implement other cart methods
    }
}