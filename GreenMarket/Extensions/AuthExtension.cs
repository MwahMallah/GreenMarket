using System.Text;
using GreenMarket.BL.Settings;
using GreenMarket.Common.Constants;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace GreenMarket.Extensions;

public static class AuthExtension
{
    // Extension method to add JWT authentication to the service collection
    public static void UseAuthentication(
        this IServiceCollection service, 
        IConfiguration configuration
    )
    {
        // Retrieve JWT options from the configuration
        var jwtOptions = configuration
            .GetSection(nameof(JwtOptions)).Get<JwtOptions>();

        // Register the JWT Bearer authentication scheme
        service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, bearerOptions =>
            {
                // Configure token validation parameters
                bearerOptions.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false, // Skip issuer validation
                    ValidateAudience = false, // Skip audience validation
                    ValidateLifetime = true, // Validate token expiration
                    ValidateIssuerSigningKey = true, // Validate the token's signature
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(jwtOptions!.SecretKey)) // Set the signing key
                };

                // Set up event handler to read token from cookies
                bearerOptions.Events = new JwtBearerEvents()
                {
                    OnMessageReceived = context =>
                    {
                        context.Token = context.Request.Cookies[Constants.AuthToken]; // Extract token from cookie
                        return Task.CompletedTask; // Complete the event handling
                    }
                };
            });
    }
}