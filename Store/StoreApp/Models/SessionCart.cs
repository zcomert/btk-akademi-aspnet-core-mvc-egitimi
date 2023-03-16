using Entities.Models;
using StoreApp.Infrastructe.Extensions;

namespace StoreApp.Models
{
    public class SessionCart : Cart
    {
        public ISession? Session { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()
                .HttpContext?.Session;

            SessionCart cart = session?.GetJson<SessionCart>("cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }
    }
}