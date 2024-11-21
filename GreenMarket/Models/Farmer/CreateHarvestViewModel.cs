using GreenMarket.DAL.Entities;

namespace GreenMarket.Models.Farmer;

public record CreateHarvestViewModel
{
    public IEnumerable<ProductEntity> Products { get; set; } = [];
    public HarvestEntity Harvest { get; set; }
}