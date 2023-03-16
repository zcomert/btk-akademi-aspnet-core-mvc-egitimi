namespace Entities.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; }
        public Cart()
        {
            Lines = new List<CartLine>();
        }

        public void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines.Where(l => l.Product.ProductId.Equals(product.ProductId))
            .FirstOrDefault();

            if (line is null)
            {
                Lines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }

        }

        public void RemoveLine(Product product) =>
            Lines.RemoveAll(l => l.Product.ProductId.Equals(product.ProductId));
        
        public decimal ComputeTotalValue() => 
            Lines.Sum(e => e.Product.Price * e.Quantity);
        
        public void Clear() => Lines.Clear();
    }
}