using System.ComponentModel.DataAnnotations;
using GreenMarket.DAL.Entities;

namespace GreenMarket.Models.Moderator;

public record EditCategoryViewModel
{
    [Required]
    public IEnumerable<AttributeViewModel> Attributes { get; set; } = [];
    public CategoryEntity Category { get; set; }
    public record AttributeViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid CategoryId { get; set; }
    }
}