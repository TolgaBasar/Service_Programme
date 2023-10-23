using AltinayStaj2.Data;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;
using Microsoft.EntityFrameworkCore;
using AltinayStaj2.Models;
using AltinayStaj2;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
    
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

using (var dbContext = new ApplicationDbContext())
{
    //dbContext.Database.EnsureCreated(); veritabaný oluþturmak için 

    var carInstaller = new CarInstall(dbContext);
    //carInstaller.Install();

    var deleteCar = new DeleteCar(dbContext);
   // deleteCar.RemoveCar(1);

    var userInstaller = new UserInstall(dbContext);
    //userInstaller.InstallUsers();

    var deleteUser = new DeleteUser(dbContext);
    //deleteUser.RemoveUser(21);
}


app.Run();
