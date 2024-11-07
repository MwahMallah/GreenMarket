using System.ComponentModel.DataAnnotations;
using GreenMarket.Common.Enums;
using GreenMarket.DAL.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GreenMarket.Models;

public record CreateUserViewModel
{
    public UserEntity UserEntity { get; set; }
    
    public IEnumerable<SelectListItem> RolesList => Enum.GetValues(typeof(UserRole))
        .Cast<UserRole>()
        .Where(role => role != UserRole.Admin)
        .Select(role => new SelectListItem()
        {
            Value = role.ToString(),
            Text = role.ToString()
        });
}