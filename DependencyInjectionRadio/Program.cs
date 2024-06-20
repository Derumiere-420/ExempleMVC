using ServiceBatteryAndRadioFactory.Factories;
using ServiceBatteryAndRadioFactory.Models;
using ServiceBatteryAndRadioFactory.Services.Implementations;
using ServiceBatteryAndRadioFactory.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Nos injection de d�pendances
builder.Services.AddTransient<LithiumBattery>();
builder.Services.AddTransient<NickelCadmiumBattery>();
builder.Services.AddTransient<AlkalineBattery>();
builder.Services.AddSingleton<IBatteryFactory, BatteryFactory>();



// Add services to the container.
builder.Services.AddControllersWithViews();



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
