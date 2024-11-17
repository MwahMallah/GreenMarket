using GreenMarket.DAL.Entities;

namespace GreenMarket.Models.Farmer;

public record EditProductViewModel
{
    public required ProductEntity Product { get; set; }
    public IEnumerable<AttributesViewModel> Attributes { get; set; } = [];

    public record AttributesViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
    }
}