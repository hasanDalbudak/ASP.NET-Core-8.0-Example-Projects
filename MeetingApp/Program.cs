var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();   


// MVC
// Razor Pages            --> Bunların hepsi ASP.NET projesi
// Rest API          

/*
app.MapGet("/", () => "Hello World!");
app.MapGet("/abc", () => "ABC deneme");
*/


// {controller=home}/{action=index}/{id?}
//app.MapDefaultControllerRoute();

app.MapControllerRoute(                                       //üstteki ve alttaki kod birbirinin aynısı aslında.
    name: "default",
    pattern: "{controller=home}/{action=Index}/{id?}"
);

app.Run();
