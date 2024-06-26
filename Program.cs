﻿using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Services;

var builder = WebApplication.CreateBuilder(args);
string mySqlConnection = builder.Configuration.GetConnectionString("SalesWebMVCContext");
builder.Services.AddDbContext<SalesWebMVCContext>(options =>
    options.UseMySql(mySqlConnection,
            ServerVersion.AutoDetect(mySqlConnection))); 

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();
builder.Services.AddScoped<DepartmentService>();
builder.Services.AddScoped<SalesRecordService>();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
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
