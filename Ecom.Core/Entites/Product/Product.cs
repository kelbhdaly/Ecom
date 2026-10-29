using System.ComponentModel.DataAnnotations.Schema;

namespace Ecom.Core.Entites.Product
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }

        public List<Photo> Photos { get; set; } 
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = default!;
    }
}
