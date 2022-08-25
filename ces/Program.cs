using ces.ORM;
using ces.Repositories;
using ces.Repositories.Impl;
using ces.Services;
using ces.Services.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsetings.json", true, true)
    .Build();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddControllers();

// Add repository 
builder.Services.AddTransient<ICityRepository, CityRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();

using (ApplicationDbContext context = new ApplicationDbContext())
{
    context.Database.Migrate();
}

void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(
            configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
    #region Swagger
    services.AddSwaggerGen(c =>
    {
        c.IncludeXmlComments(string.Format(@"{0}\EFCore.CodeFirst.WebApi.xml", System.AppDomain.CurrentDomain.BaseDirectory));
        c.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "v1",
            Title = "EFCore.CodeFirst.WebApi",
        });
    });
    services.AddDbContext<ApplicationDbContext>();
    #endregion
    services.AddControllers();
}