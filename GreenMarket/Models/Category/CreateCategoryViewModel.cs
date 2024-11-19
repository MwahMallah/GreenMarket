using System.ComponentModel.DataAnnotations;
using GreenMarket.DAL.Entities;

namespace GreenMarket.Models.Category;

public record CreateCategoryViewModel
{
    [Required]
    public string Name { get; set; }
    public string? ImgUrl { get; set; }
    public IEnumerable<AttributeViewModel> Attributes { get; set; } = [];
    public IEnumerable<CategoryEntity> Categories { get; set; } = [];
    public Guid SelectedCategoryId { get; set; }
    
    public class AttributeViewModel
    {
        public string Name { get; set; } = null!;
        public Guid CategoryId { get; set; }
    }
}