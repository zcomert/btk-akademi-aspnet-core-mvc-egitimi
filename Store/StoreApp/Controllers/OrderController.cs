using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IServiceManager _manager;

        public OrderController(IServiceManager manager)
        {
            _manager = manager;
        }

        public ViewResult Checkout() => View(new Order());
    }
}