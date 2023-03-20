var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "table",
    pattern: "{controller=Table}/{action=Index}");

app.MapControllerRoute(
    name: "card",
    pattern: "{controller=Card}/{action=Index}");

app.MapControllerRoute(
    name: "login",
    pattern: "{controller=Login}/{action=Index}");


app.Run();
