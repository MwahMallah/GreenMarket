using GreenMarket.BL.Installers;
using GreenMarket.BL.Settings;
using GreenMarket.DAL;
using GreenMarket.DAL.Installers;
using GreenMarket.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<GreenMarketDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtOptions"));
builder.Services.InstallDal();
builder.Services.InstallBl();
builder.Services.UseAuthentication(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
app.Logger.LogInformation(connectionString);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}");

app.Run();