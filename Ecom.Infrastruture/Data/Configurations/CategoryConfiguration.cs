using Ecom.Core.Entites.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecom.Infrastruture.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x=> x.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Id).IsRequired();
            builder.HasData(new Category { Id = 1, Name = "Electronics" , Description = "Electronic items" });

        }
    }
}
