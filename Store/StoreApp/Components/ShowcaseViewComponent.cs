using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Components
{
    public class ShowcaseViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public ShowcaseViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke(string page = "default")
        {
            var products = _manager.ProductService.GetShowcaseProducts(false);
            return page.Equals("default")
                ?  View(products)
                :  View("List",products);
        }
    }
}