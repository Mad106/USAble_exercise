using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using USAble_proj1.Data;
using USAble_proj1.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<USAble_proj1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("USAble_proj1Context") ?? throw new InvalidOperationException("Connection string 'USAble_proj1Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
