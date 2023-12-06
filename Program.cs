using backend_development_for_dotnet.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(options => 
{
    options.IdleTimeout = TimeSpan.FromSeconds(20);
    options.Cookie.IsEssential = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddDbContext<DatabaseFirstDbContext>(options => options.UseMySQL("server=localhost;database=DatabaseFirstDB;user=root;password=password"));
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

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
