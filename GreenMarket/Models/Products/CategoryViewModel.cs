using GreenMarket.DAL.Entities;

namespace GreenMarket.Models.Products;

public record CategoryViewModel
{
    public IEnumerable<CategoryEntity> Categories { get; set; } = new List<CategoryEntity>();
    public IEnumerable<CategoryEntity> ParentList { get; set; } = new List<CategoryEntity>();
}

