using System.Security.Claims;
using GreenMarket.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GreenMarket.Extensions;

public static class GetCurrentUserIdExtension
{
    public static Guid? GetCurrentUserId(this Controller controller)
    {
        var userIdClaim = controller.User.Claims
            .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
        if (userIdClaim == null)
            return null;
        
        var userId = Guid.Parse(userIdClaim.Value);
        return userId;
    }
}