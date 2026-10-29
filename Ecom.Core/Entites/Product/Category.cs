namespace Ecom.Core.Entites.Product
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
