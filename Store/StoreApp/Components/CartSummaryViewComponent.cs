using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly Cart _cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            _cart = cartService;
        }

        public string Invoke()
        {
            return _cart.Lines.Count().ToString();
        }
    }
}