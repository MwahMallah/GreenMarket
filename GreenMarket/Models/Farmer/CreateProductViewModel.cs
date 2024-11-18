using GreenMarket.DAL.Entities;

namespace GreenMarket.Models.Farmer;

public record CreateProductViewModel
{
    public ProductEntity Product { get; set; } = null!;
    public IEnumerable<CategoryEntity> CategoryList = [];
}