using ClassTask25.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>( opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
}); 

var app = builder.Build();


app.MapControllerRoute(
     name: "areas",
     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
   );

   app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{Action=index}/{id?}"
    );
   
app.UseStaticFiles();

   app.Run();
