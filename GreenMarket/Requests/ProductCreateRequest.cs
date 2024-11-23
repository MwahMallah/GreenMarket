using System.ComponentModel.DataAnnotations;
using GreenMarket.Common.Enums;

namespace GreenMarket.Requests;

public record ProductCreateRequest
{
    [Required]
    public required string Name { get; set; }
    public string? ImgUrl { get; set; }
    public string? Description { get; set; }
    public ProductSalesType Type { get; set; }
    [Required]
    public Guid CategoryId { get; set; }

    public IList<AttributeRequest> Attributes { get; set; } = [];

    public record AttributeRequest
    {
        public Guid Id { get; set; }
        public string? Value { get; set; }
    }
}