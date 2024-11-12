using GreenMarket.DAL.Entities;

namespace GreenMarket.Models.Products;

public record ProductViewModel
{
    public IEnumerable<ProductEntity> Products { get; set; } = [];
    public IEnumerable<CategoryEntity> ParentList { get; set; } = [];
}