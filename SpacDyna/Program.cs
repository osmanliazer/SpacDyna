

using Microsoft.EntityFrameworkCore;
using SpacDyna.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SpacContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Category}/{action=Index}/{id?}"
          );
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.Run();

