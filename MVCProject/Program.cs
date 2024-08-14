using Microsoft.EntityFrameworkCore;
using MVCProject.Interfaces;
using MVCProject.Models;
using MVCProject.Repositories;

namespace MVCProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            // to use Injection
            //for connection service
            builder.Services.AddDbContext<Context>(option =>
            option.UseSqlServer(builder.Configuration.GetConnectionString("cs")));

            //Register all Interfaces with their classes that implement them
            builder.Services.AddScoped<IAdminRepo, AdminRepo>();
            builder.Services.AddScoped<ICarRepo, CarRepo>();
            builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
            builder.Services.AddScoped<IClientRepo, ClientRepo>();
            builder.Services.AddScoped<IPurchaseRepo, PurchaseRepo>();


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
        }
    }
}
