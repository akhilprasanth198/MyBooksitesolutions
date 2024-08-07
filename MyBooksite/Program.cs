using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyBooksite.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDBContext>(Options =>
    Options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnection") ??throw 
    new InvalidCastException("Connection string ApplicationDB")));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

 app.Run();

























/*app.MapControllerRoute(
    name: "bookdefault",
    pattern: "{controller=Book}/{action=Details}/{id}");
app.MapControllerRoute(
    name: "authordefault",
    pattern: "{controller=Author}/{action=Detailsnew}/{id}");*/