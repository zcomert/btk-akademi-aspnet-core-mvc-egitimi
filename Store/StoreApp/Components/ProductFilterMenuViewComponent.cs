using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Components
{
    public class ProductFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}