using ServiceBatteryAndRadioFactory.Factories;
using ServiceBatteryAndRadioFactory.Models;
using ServiceBatteryAndRadioFactory.Services.Implementations.Battery;
using ServiceBatteryAndRadioFactory.Services.Implementations.Radio;
using ServiceBatteryAndRadioFactory.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Nos injection de dépendances
// Register battery implementations
builder.Services.AddTransient<LithiumBattery>();
builder.Services.AddTransient<NickelCadmiumBattery>();
builder.Services.AddTransient<AlkalineBattery>();

// Register the factories
builder.Services.AddTransient(typeof(IBatteryFactory<>), typeof(BatteryFactory<>));
builder.Services.AddTransient(typeof(IRadioFactory<>), typeof(RadioFactory<>));

// Register radio implementations
builder.Services.AddTransient<Sony>();
builder.Services.AddTransient<Samsung>();
builder.Services.AddTransient<LG>();



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
