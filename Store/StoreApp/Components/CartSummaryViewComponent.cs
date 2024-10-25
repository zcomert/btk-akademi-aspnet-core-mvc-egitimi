using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly Cart _cart;
        private int productQuantity { get; set; }
        public CartSummaryViewComponent(Cart cartService)
        {
            _cart = cartService;
        }

        public string Invoke()
        {
            foreach (var line in _cart.Lines)
            {
                productQuantity += line.Quantity;
            }

            return productQuantity.ToString();
        }
    }
}
